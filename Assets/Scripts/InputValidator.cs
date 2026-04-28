using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputValidator : MonoBehaviour
{
    public TMP_InputField inputField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputField.onValidateInput += ValidateMathInput;
    }

    private char ValidateMathInput(string text, int charIndex, char addedChar)
    {
        string allowedChars = "0123456789";

        if (allowedChars.Contains(addedChar.ToString()))
        {
            return addedChar;
        }

        return '\0';
    }
}
