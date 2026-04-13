using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public Canvas canvas;
    public GameObject HelpUI;
    private bool paused;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HelpUI.SetActive(false);
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
    }

    public void ToggleHelpUI()
    {
        paused = (!paused);
        HelpUI.SetActive(!HelpUI.activeSelf);
    }
}
