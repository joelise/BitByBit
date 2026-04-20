using UnityEngine;
using TMPro;
using System;

public class Binary : MonoBehaviour
{
    [Header("Binary")]
    [SerializeField] private int binaryLength = 4;
    private int correctDecimal;
    private string currentBinary;

    [Header("UI")]
    [SerializeField] private TMP_Text gateBinaryText;
    [SerializeField] private TMP_Text uiBinaryText;
    [SerializeField] private TMP_InputField playerInput;

    [Header("Gate")]
    [SerializeField] private Gate binaryGate;

    private void Start()
    {
        GenerateBinary();
        playerInput.onSubmit.AddListener(CheckAnswer);
    }

    private void GenerateBinary()
    {
        currentBinary = "";

        for (int i = 0; i < binaryLength; i++)
        {
            currentBinary += UnityEngine.Random.Range(0, 2).ToString();
        }

        gateBinaryText.text = currentBinary;
        uiBinaryText.text = currentBinary;
        correctDecimal = BinaryToDecimal(currentBinary);
        Debug.Log(correctDecimal);
    }

    private int BinaryToDecimal(string binary)
    {
        return System.Convert.ToInt32(binary, 2);
    }

    public void CheckAnswer(string playerAnswer)
    {
        string correctAnswer = correctDecimal.ToString();

        if (playerAnswer == correctAnswer)
        {
           
            binaryGate.OpenGate();
        }
        else
        {
            
            binaryGate.CloseGate();
        }

        playerInput.text = "";
    }

    /*[Header("Binary")]
    [SerializeField] private int binaryLength = 5;
    public string currentBinary;
    private int correctDecimal;
    public static event Action OnCorrectAnswer;

    [Header("UI")]
    [SerializeField] private TMP_Text binaryText;
    [SerializeField] private TMP_Text UIBinaryText;
    public TMP_InputField InputText;

    [SerializeField] private TMP_Text nextBinaryText;
    //[SerializeField] private TMP_Text nextUIBinaryText;

    [Header("References")]
    public GameObject wall;
    [SerializeField] private GameObject button;
    public Renderer WallRenderer;
    public BoxCollider WallCollider;
    public Binary binaryScript;
    [SerializeField] private Gate binaryGate;

    private void Start()
    {
        GenerateBinary();
    }
    public void GenerateBinary()
    {
        currentBinary = "";

        for (int i = 0; i < binaryLength; i++)
        {
            currentBinary += UnityEngine.Random.Range(0, 2).ToString();
        }

        correctDecimal = BinaryToDecimal(currentBinary);

        //binaryText.text = currentBinary;
        //UIBinaryText.text = currentBinary;
        //Debug.Log("Binary: " + currentBinary);
        //Debug.Log("Decimal Answer: " + correctDecimal);
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
            binaryGate.OpenGate();
            //wall.GetComponent<Renderer>().material.color = new Color(59f / 255f, 255f / 255f, 0f / 255f, 72f / 255f);
            WallRenderer.material.color = new Color(59f / 255f, 255f / 255f, 0f / 255f, 72f / 255f);
            //wall.GetComponent<BoxCollider>().enabled = false;
            WallCollider.enabled = false;
            button.layer = 0;
            //GenerateNext();
            UIBinaryText.text = currentBinary;
            binaryScript.enabled = false;
           

        }
        else
        {
            Debug.Log("Incorrect");
            GameManager.instance.ToggleBinaryUI();
            binaryGate.CloseGate();
            wall.GetComponent<Renderer>().material.color = new Color(255f / 255f, 26f / 255f, 0f / 255f, 72f / 255f);
        }

        InputText.text = "";

    }

    public void CheckAnswer(string playerInput)
    {
        string correctAnswer = correctDecimal.ToString();

        if (playerInput == correctAnswer)
        {
            OnCorrectAnswer?.Invoke();
        }
    }*/




}
