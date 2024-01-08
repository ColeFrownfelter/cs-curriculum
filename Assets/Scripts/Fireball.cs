using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretProjectile : MonoBehaviour
{
    public float destroyWait = 3f;
    public float fireballvelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        fireballvelocity = 5f;
        Invoke("DestroyFireball",destroyWait);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation:new Vector2(x:fireballvelocity*Time.deltaTime, y:0f));
    }

    void DestroyFireball()
    {
        Destroy(gameObject);
    }
}
