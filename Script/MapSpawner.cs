using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    public GameObject floor;
    public Transform storage;
    public int offset;


    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Ground")){
            GameObject floorpiece = Instantiate(floor) as GameObject;
            floorpiece.transform.position = new Vector3(transform.position.x + offset, -4.59f, 0);
            floorpiece.transform.SetParent(storage);
        }
    }

    public void ClearStorage(){
        int x;
        for(x = 0; x < storage.childCount; x++){
            Destroy(storage.GetChild(x).gameObject);
        }
    }
}
