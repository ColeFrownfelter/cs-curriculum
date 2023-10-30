using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Hud hud; // Start is called before the first frame update
    public float timer;
    public float originalTimer = 1.5f;
    
    void Start()
    {
        timer = originalTimer;
        hud = GameObject.FindObjectOfType<Hud>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            //turn off iframes
            //timer = originalTimer
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print(message:"hit something");
        if (other.gameObject.CompareTag("Spikes"))
        {
            print(message:"hit a spike");
            hud.health = hud.health - 1;
        }

        if (other.gameObject.CompareTag("Heart"))
        {
            hud.health = hud.health + 1;
            other.gameObject.SetActive(false);
        }

    }
}