using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrack : MonoBehaviour
{
    public Transform target;
    
    
    // Update is called once per frame
    void Update()
    {
        //direction to target
        Vector2 direction = (target.position - transform.position);
        
        //Rotation to target (rod)
        float angle = Mathf.Atan2(direction.y, direction.x);
        
        //New Location
        Vector2 newLocation = (Vector2)transform.position + direction.normalized * Time.deltaTime;
        
        //Rotate to face target
        transform.rotation = Quaternion.Euler(x: 0, y: 0, z: angle * Mathf.Rad2Deg);
    }
}
