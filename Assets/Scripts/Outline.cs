using UnityEngine;

public class Outline : MonoBehaviour
{
   
    private new Renderer renderer;
    private Material originalMaterial;
    public Material OutlineMaterial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        originalMaterial = renderer.material;
    }

    public void ShowOutline(bool show)
    {
        if (show)
        {
            renderer.material = OutlineMaterial;
        }
        else
        {
            renderer.material = originalMaterial;
        }
    }
}
