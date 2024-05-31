using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float offset;

    
    

    void Update()
    {
        transform.position = new Vector3(player.position.x + offset, transform.position.y, transform.position.z);
        
    }
}
