using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coins;
    
    // Start is called before the first frame update
    void Start()
    {
        
        {
            coins = coins + 1;
            //SetActive(false)
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
