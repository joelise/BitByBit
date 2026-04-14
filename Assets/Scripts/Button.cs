using UnityEngine;

public class Button : MonoBehaviour, IInteractable
{
    public GameObject binaryUI;
    public bool show;

    public GameManager gameManager;
    public Binary binary;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        binaryUI.SetActive(false);
        show = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (show)
        {
            //Cursor.lockState = CursorLockMode.None;

            //Cursor.visible = true;
            //binaryUI.SetActive(true);
           

        }
    }

    void IInteractable.Interact()
    {
        Interacted();
    }

    void Interacted()
    {
        binary.GenerateBinary();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        gameManager.ToggleBinaryUI();
    }
}
