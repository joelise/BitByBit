using TMPro;
using UnityEngine;

public class FinishTutorial : MonoBehaviour
{
    //public GameObject EndUI;
    //public TMP_Text TimeText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.GameEnd();
        }
    }
}
