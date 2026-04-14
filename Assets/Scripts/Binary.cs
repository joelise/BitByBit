using UnityEngine;
using TMPro;
using System;

public class Binary : MonoBehaviour
{
    [Header("Binary")]
    [SerializeField] private int binaryLength = 5;
    private string currentBinary;
    private int correctDecimal;

    [Header("UI")]
    [SerializeField] private TMP_Text binaryText;
    public TMP_InputField InputText;

    public GameObject wall;
    
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
            GameManager.instance.ToggleBinaryUI();
           
            wall.GetComponent<Renderer>().material.color = new Color(59f / 255f, 255f / 255f, 0f / 255f, 72f/255f);
        }
        else
        {
            Debug.Log("Incorrect");
            GameManager.instance.ToggleBinaryUI();
            wall.GetComponent<Renderer>().material.color = new Color(255f / 255f, 26f / 255f, 0f / 255f, 72f / 255f);
        }

        InputText.text = "";
    }

    
}
