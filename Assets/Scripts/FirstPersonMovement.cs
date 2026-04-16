using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float runSpeed = 8f;
    [SerializeField] private float crouchSpeed = 2f;

    [Header("References")]
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private InputActionReference moveAction;
    [SerializeField] private InputActionReference jumpAction;
    [SerializeField] private InputActionReference clickAction;
    

    [Header("Gravity/Physics")]
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private float gravity = -12f;
    [SerializeField] private float initialFallVelocity = -2f;

    private CharacterController _characterController;
    private Vector2 _moveInput;
    private bool _isGrounded;
    private float _verticalVelocity;

    //public Button button;
    public bool CanMove;

    public GameManager gameManager;
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (gameManager.PlayerCanMove == true)
        {
            CanMove = true;
        }
        else
        {
            CanMove = false;
        }
            _isGrounded = _characterController.isGrounded;

        if (CanMove == true)
        {
            _characterController.enabled = true;
            HandleGravity();
            HandleMovement();
        }
        if (CanMove == false)
        {
            moveAction.action.Disable();
        }
       
    }

    private void OnEnable()
    {
        moveAction.action.performed += StoreMovementInput;
        moveAction.action.canceled += StoreMovementInput;
        jumpAction.action.performed += Jump;
        clickAction.action.Enable();
    }

    private void OnDisable()
    {
        moveAction.action.performed -= StoreMovementInput;
        moveAction.action.canceled -= StoreMovementInput;
        jumpAction.action.performed -= Jump;
    }

    private void StoreMovementInput(InputAction.CallbackContext context)
    {
        
        _moveInput = context.ReadValue<Vector2>();
    }

    private void Jump(InputAction.CallbackContext context)
    {
        if (_isGrounded)
        {
            _verticalVelocity = jumpForce;
        }
    }

    private void HandleGravity()
    {
        if (_isGrounded && _verticalVelocity < 0)
        {
            _verticalVelocity = initialFallVelocity;
        }

        _verticalVelocity += gravity * Time.deltaTime;
    }

    private void HandleMovement()
    {
        
        var move = cameraTransform.TransformDirection(new Vector3(_moveInput.x, 0, _moveInput.y)).normalized;
        var currentSpeed = walkSpeed;
        var finalMove = move * currentSpeed;
        finalMove.y = _verticalVelocity;

        var collisions = _characterController.Move(finalMove * Time.deltaTime);

        if ((collisions & CollisionFlags.Above) != 0)
        {
            _verticalVelocity = initialFallVelocity;
        }
    }
}
