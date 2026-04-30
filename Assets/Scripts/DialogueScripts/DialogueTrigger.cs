using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private bool hasTriggered = false;

    public bool isPath = false;
    
    public GameObject[] otherTriggers;

    private void OnTriggerEnter(Collider other)
    {
        if (isPath && hasTriggered)
        {
            foreach (GameObject t in otherTriggers)
            {
                t.SetActive(false);
            }
        }

        if (hasTriggered)
            return;






        if (other.CompareTag("Player"))
        {
            DialogueManager.Instance.TextPanel.SetActive(true);
            DialogueManager.Instance.StartDialogue(dialogue);

            hasTriggered = true;
            //DialogueManager.Instance.TextPanel.SetActive(true);
           
        }
    }
}
