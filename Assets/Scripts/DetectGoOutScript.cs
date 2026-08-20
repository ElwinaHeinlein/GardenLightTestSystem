using UnityEngine;

public class DetectGoOutScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    private MeshRenderer meshRenderer;

    
    public Material newMaterial; 
    
    
    
    public int materialSlotIndex = 0; 

    void Start()
    {
        
        meshRenderer = GetComponent<MeshRenderer>();
    }

    
    public void SwapMaterial()
    {
        
        if (meshRenderer == null || newMaterial == null) return;

        
        Material[] currentMaterials = meshRenderer.materials;

        
        if (materialSlotIndex >= 0 && materialSlotIndex < currentMaterials.Length)
        {
            
            currentMaterials[materialSlotIndex] = newMaterial;

            
            meshRenderer.materials = currentMaterials;
            
        }
        else
        {
            Debug.LogWarning("Material slot index is out of bounds!");
        }
    }
}

