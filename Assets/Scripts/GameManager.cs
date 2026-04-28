using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("References")]
    public FirstPersonMovement playerMovement;
    public GameObject Player;
    public GameObject HelpText;
   // public Button button;

    [Header("UI")]
    public GameObject HelpUI;
    public GameObject NoteUI;
  
    public GameObject BinaryUI;
    public bool CursorVisible;
    public bool UiVisible;
    public bool CursorLocked;
    private bool paused;
    

    public bool PlayerCanMove;
    public float timer = 0f;

    public int AttemptCount = 0;
   
    private void Awake()
    {
        // Checks there is only one GameManager instance
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);      // Doesn't destory gameManager between scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        AttemptCount = 0;
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            ToggleHelpUI();
            HelpText.SetActive(false);
            AttemptCount = 0;
        }
           
       

        
        timer += Time.deltaTime;


        

        if (PlayerCanMove)
        {
            playerMovement.enabled = true;
           
        }
        else
        {
            playerMovement.enabled = false;
            
        }

        //Cursor.visible = UiVisible;
        if (UiVisible)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (AttemptCount >= 3)
        {
            //ToggleHelpText();
           // Debug.Log("HelpText");
        }

       // if (CursorLocked)
       // {
            
       // }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleNoteUI();
        }

       


        //ToggleHelpText();
    }

    public void Setup()
    {
        HelpText.SetActive(false);
        HelpUI.SetActive(false);
        BinaryUI.SetActive(false);
        PlayerCanMove = true;
        Cursor.visible = false;
        CursorVisible = false;
        CursorLocked = true;
    }

    public void ToggleHelpUI()
    {
        // Toggles the HelpUI on/off and stops player movement
        paused = (!paused);
        UiVisible = (!UiVisible);
        Player.SetActive(!Player.activeSelf);
        HelpUI.SetActive(!HelpUI.activeSelf);
       
    }

    public void ToggleBinaryUI()
    {
        // Toggles Binary Ui on/off and stops player movement
        PlayerCanMove = (!PlayerCanMove);
        UiVisible = (!UiVisible);
        Player.SetActive(!Player.activeSelf);
        BinaryUI.SetActive(!BinaryUI.activeSelf);
    }

    public void ToggleHelpText()
    {
        HelpText.SetActive(!HelpText.activeSelf);

    }

    public void ToggleNoteUI()
    {
        CursorLocked = (!CursorLocked);
        PlayerCanMove = (!PlayerCanMove);
        UiVisible = (!UiVisible);
        Player.SetActive(!Player.activeSelf);
        NoteUI.SetActive(!NoteUI.activeSelf);
    }

    public void OpenScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }


}
