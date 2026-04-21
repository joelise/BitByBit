using UnityEngine;

public class Gate : MonoBehaviour
{

    [SerializeField] private Renderer gateRenderer;
    [SerializeField] private BoxCollider gateCollider;
    [SerializeField] private Material correctMat;
    [SerializeField] private Material incorrectMat;
    [SerializeField] private GameObject button;
    private Material gateMaterial;

    private void Awake()
    {
        gateMaterial = new Material(gateRenderer.material);
        gateRenderer.material = gateMaterial;

    }

    public void OpenGate()
    {
        GameManager.instance.ToggleBinaryUI();
        gateRenderer.material = correctMat;
        gateCollider.enabled = false;
        button.layer = 0;

    }

    public void CloseGate()
    {
        GameManager.instance.ToggleBinaryUI();
        gateRenderer.material = incorrectMat;
        gateCollider.enabled = true;
       
    }

    /*[SerializeField] private Renderer gateRenderer;
    [SerializeField] private BoxCollider gateCollider;
    [SerializeField] private Binary binaryCode;
    [SerializeField] private BoxCollider trigger;

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

    public void OnTriggerEnter(Collider other)
    {
        binaryCode.CurrentGate = true;

        other = trigger;
        if (other.CompareTag("Player"))
            binaryCode.OnEnable();

    }

    public void OnTriggerExit(Collider other)
    {
        binaryCode.CurrentGate = false;
        other = trigger;
        if (other.CompareTag("Player"))
            binaryCode.OnDisable();
    }*/

}
