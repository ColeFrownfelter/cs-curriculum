using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool overworld;
    
    // Start is called before the first frame update
    public float xspeed;
    public float yspeed;
    public float xDirection;
    public float yDirection;
    public float xVector;
    public float yVector;
    
    void Start()
    {
        xspeed = 4f;
        if (overworld)
        {
            xspeed = 3f;
            yspeed = 3f;
        }
        else
        {
            yspeed = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * xspeed * Time.deltaTime;
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * yspeed * Time.deltaTime;

        transform.position = transform.position + new Vector3(xVector, yVector, z: 0);
    }
}
