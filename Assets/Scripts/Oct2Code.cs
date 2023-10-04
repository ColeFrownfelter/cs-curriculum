using UnityEngine;
using TMPro;



int health;
int coins;
bool iframes;
float iframeTimer;

OnTriggerEnter2D();
{
    //check if coin
    //destroy coin or SetActive(false)
    //coins++
}

public class Oct2Code : MonoBehaviour
{
    // Start is called before the first frame update
    
    Update()
    {
        if (iframes) 
        {
            iframeTimer = Time.deltaTime;
            if (ifrmeTimer < 0)
            {
                //not invincible
                //reset timer
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //check if spike
        //void ChangeHealth(int 1)
        if (iframes)
        {
            iframes = true;
            health -= 1;
            if (health < 1)
            {
                death();
            }

        }
    }
    // Update is called once per frame
}
