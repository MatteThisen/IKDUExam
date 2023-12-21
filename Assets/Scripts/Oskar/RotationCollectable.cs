using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCollectable : MonoBehaviour
{
    public float rotationSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates the object 
        transform.Rotate(0, rotationSpeed, 0 * Time.deltaTime);
    }
}
