using UnityEngine;

public class Button : MonoBehaviour, IInteractable
{
    public GameObject binaryUI;
    public bool show;

    //public GameManager gameManager;
    public Binary binary;

    void IInteractable.Interact()
    {
        Interacted();
    }

    void Interacted()
    {
        binary.GenerateBinary();
        //Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        GameManager.instance.ToggleBinaryUI();
        //gameManager.ToggleBinaryUI();
    }
}
