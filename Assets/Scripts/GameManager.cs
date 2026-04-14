using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public Canvas canvas;
    public GameObject HelpUI;
    public Button button;
    private bool paused;
    public GameObject BinaryUI;
    public bool PlayerCanMove;
    public FirstPersonMovement playerMovement;
    public bool CursorVisible;
    public GameObject player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HelpUI.SetActive(false);
        PlayerCanMove = true;
        Cursor.visible = false;
        CursorVisible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            ToggleHelpUI();
            
        }

        if (paused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

        if (PlayerCanMove)
        {
            playerMovement.enabled = true;
           
        }
        else
        {
            playerMovement.enabled = false;
            
        }

        if (CursorVisible)
        {
            Cursor.visible = true;
            
        }
        else
        {
            Cursor.visible = false;
        }
    }

    public void ToggleHelpUI()
    {
        paused = (!paused);
        HelpUI.SetActive(!HelpUI.activeSelf);
    }

    public void ToggleBinaryUI()
    {
        PlayerCanMove = (!PlayerCanMove);
        player.SetActive(!player.activeSelf);
        BinaryUI.SetActive(!BinaryUI.activeSelf);
        CursorVisible = !CursorVisible;

    }
}
