using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("References")]
    public FirstPersonMovement playerMovement;
    public GameObject Player;
   // public Button button;

    [Header("UI")]
   // public GameObject HelpUI;
   // public GameObject BinaryUI;
    public bool CursorVisible;
    public bool UiVisible;

    private bool paused;
    

    public bool PlayerCanMove;
    public float timer = 0f;
   
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
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            ToggleHelpUI();


        
        timer += Time.deltaTime;


        

        if (PlayerCanMove)
        {
            playerMovement.enabled = true;
           
        }
        else
        {
            playerMovement.enabled = false;
            
        }

        if (UiVisible)
        {
            Cursor.visible = true;
            
            
        }
        else
        {
            Cursor.visible = false;
        }
    }

    public void Setup()
    {
        //HelpUI.SetActive(false);
        //BinaryUI.SetActive(false);
        PlayerCanMove = true;
        Cursor.visible = false;
        CursorVisible = false;
    }

    public void ToggleHelpUI()
    {
        // Toggles the HelpUI on/off and stops player movement
        //paused = (!paused);
        UiVisible = (!UiVisible);
        Player.SetActive(!Player.activeSelf);
       // HelpUI.SetActive(!HelpUI.activeSelf);
       
    }

    public void ToggleBinaryUI()
    {
        // Toggles Binary Ui on/off and stops player movement
        //PlayerCanMove = (!PlayerCanMove);
        UiVisible = (!UiVisible);
        Player.SetActive(!Player.activeSelf);
        //BinaryUI.SetActive(!BinaryUI.activeSelf);
    }

    public void OpenScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

}
