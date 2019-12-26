using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public Vector3 screenPos;
    public Vector3 offset;
    void OnMouseDown() 
    {
        screenPos = Camera.main.WorldToScreenPoint(transform.position);  
        offset = screenPos - Input.mousePosition;
    }
    void OnMouseDrag() 
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + offset);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
