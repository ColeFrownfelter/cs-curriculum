using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool overworld;
    
    // Start is called before the first frame update
    float walkingspeed;

    float xDirection;

    float xVector;
    
    void Start()
    {
        walkingspeed = 5f;
        if (overworld)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * walkingspeed * Time.deltaTime;

        transform.position = transform.position + new Vector3(xVector, y: 0, z: 0);
    }
}
