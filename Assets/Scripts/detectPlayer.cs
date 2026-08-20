using UnityEngine;

public class detectPlayer : MonoBehaviour
{

    public DetectGoOutScript detectGoOutScript1;
    public DetectGoOutScript detectGoOutScript2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        detectGoOutScript1.SwapMaterial();
        detectGoOutScript2.SwapMaterial();
    }
}
