using UnityEngine;

public class Binary : MonoBehaviour
{
    [SerializeField] private int binaryLength = 5;
    private string currentBinary;
    private int correctDecimal;

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
            currentBinary += Random.Range(0, 2).ToString();
        }

        correctDecimal = BinaryToDecimal(currentBinary);
        Debug.Log("Binary: " + currentBinary);
        Debug.Log("Decimal Answer: " + correctDecimal);
    }

    private int BinaryToDecimal(string binary)
    {
        return System.Convert.ToInt32(binary, 2);
    }
}
