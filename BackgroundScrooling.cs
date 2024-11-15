using UnityEngine;

public class BackgroundScrooling : MonoBehaviour
{
    public MeshRenderer mr;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(speed*Time.deltaTime, 0);
        
    }
}
