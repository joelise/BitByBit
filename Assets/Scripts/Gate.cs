using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] private Renderer gateRenderer;
    [SerializeField] private BoxCollider gateCollider;

    private Material gateMaterial;

    private void Awake()
    {
        gateMaterial = new Material(gateRenderer.material);
        gateRenderer.material = gateMaterial;
    }
    
    public void OpenGate()
    {
        GameManager.instance.ToggleBinaryUI();
        gateMaterial.color = new Color(59f / 255f, 255f / 255f, 0f / 255f, 72f / 255f);
        gateCollider.enabled = false;
    }

    public void CloseGate()
    {
        GameManager.instance.ToggleBinaryUI();
        gateMaterial.color = new Color(255f / 255f, 26f / 255f, 0f / 255f, 72f / 255f);
        gateCollider.enabled = true;
    }
}
