using UnityEngine;
using TMPro;
using System;

public class Binary : MonoBehaviour
{
    [SerializeField] private int binaryLength = 5;
    private string currentBinary;
    private int correctDecimal;

    [SerializeField] private TMP_Text binaryText;
    public TMP_InputField InputText;

    public GameObject wall;
    public GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GenerateBinary();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateBinary()
    {
        currentBinary = "";

        for (int i = 0; i < binaryLength; i++)
        {
            currentBinary += UnityEngine.Random.Range(0, 2).ToString();
        }

        correctDecimal = BinaryToDecimal(currentBinary);

        binaryText.text = currentBinary;
        Debug.Log("Binary: " + currentBinary);
        Debug.Log("Decimal Answer: " + correctDecimal);
    }

    private int BinaryToDecimal(string binary)
    {
        return System.Convert.ToInt32(binary, 2);
    }

    public void SubmitAnswer()
    {
        string correctAnswer = correctDecimal.ToString();
        string playerAnswer = InputText.text;

        if (playerAnswer == correctAnswer)
        {

            Debug.Log("Correct");
            gameManager.ToggleBinaryUI();
            wall.GetComponent<Renderer>().material.color = new Color(59f / 255f, 255f / 255f, 0f / 255f, 72f/255f);
        }
        else
        {
            Debug.Log("Incorrect");
            gameManager.ToggleBinaryUI();
            wall.GetComponent<Renderer>().material.color = new Color(255f / 255f, 26f / 255f, 0f / 255f, 72f / 255f);
        }

        InputText.text = "";
    }

    
}
