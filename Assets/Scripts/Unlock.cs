using UnityEngine;

public class Unlock : MonoBehaviour
{
    public string CorrectCode;
    private bool unlocked = false;

    public void EnterCode(string playerInput)
    {
        if (unlocked)
            return;

        if (playerInput == CorrectCode)
        {
            unlocked = true;
            Debug.Log("Unlocked");
        }

        else
        {
            Debug.Log("False");
        }
    }
}
