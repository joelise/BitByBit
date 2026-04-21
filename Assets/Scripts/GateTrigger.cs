using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    [SerializeField] private Binary binary;
    [SerializeField] private BinaryUI ui;

    public bool FirstTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (FirstTrigger)
        {
            //GameManager.instance.ToggleHelpUI();
            //FirstTrigger = false;
        }
            
        if (other.CompareTag("Player"))
            ui.SetGate(binary);
        
    }
}
