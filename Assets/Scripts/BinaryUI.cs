using TMPro;
using UnityEngine;

public class BinaryUI : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerInput;
    [SerializeField] private TMP_Text overlayText;

    public Binary currentGateBinary;

    private void Start()
    {
        playerInput.onSubmit.AddListener(SubmitAnswer);
    }

    public void SetGate(Binary binary)
    {
        currentGateBinary = binary;
        currentGateBinary.SetBinary(overlayText);
    }

    void SubmitAnswer(string input)
    {
        currentGateBinary.CheckAnswer(input);
        playerInput.text = "";
    }

    /*//[SerializeField] private TMP_Text binaryText;
    //[SerializeField] private TMP_Text UIBinaryText;
    public TMP_InputField InputText;

    //public Binary binaryScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //binaryText.text = binaryScript.currentBinary;
        //UIBinaryText.text = binaryScript.currentBinary;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string PlayerAnswer()
    {
        return InputText.text;
    }*/



}
