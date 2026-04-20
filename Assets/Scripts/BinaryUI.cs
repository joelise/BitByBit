using TMPro;
using UnityEngine;

public class BinaryUI : MonoBehaviour
{
    [SerializeField] private TMP_Text binaryText;
    [SerializeField] private TMP_Text UIBinaryText;
    public TMP_InputField InputText;

    public Binary binaryScript;

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



}
