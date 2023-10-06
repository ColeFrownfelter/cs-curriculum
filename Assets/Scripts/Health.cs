using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health= 5;
    // Start is called before the first frame update
    void Start()
    {
        
        {
            health = health - 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
