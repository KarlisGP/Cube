using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        //transform.position = new Vector3(5, 7, 2);
        transform.localScale = Vector3.one * 2.3f;
        
        Material material = Renderer.material;
        
        material.color = Random.ColorHSV();
    }
    void Update()
    {
        transform.Rotate(30.0f * Time.deltaTime, 0.0f, 0.0f);
        
    }
}
