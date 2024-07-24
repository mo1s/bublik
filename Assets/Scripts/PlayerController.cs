using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    void Start()
    {
        
    }
    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Horizontal");

        float v = verticalSpeed * Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(h,v,0);
    }
}
