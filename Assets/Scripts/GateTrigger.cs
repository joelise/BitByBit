using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    [SerializeField] private Binary binary;
    [SerializeField] private BinaryUI ui;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            ui.SetGate(binary);
        
    }
}
