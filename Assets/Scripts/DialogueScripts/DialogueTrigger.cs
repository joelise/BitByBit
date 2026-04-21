using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
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
