using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public string state;
    public MapSpawner map;
    public Movement move;
    public Score score;
    public MusicManager music;
    public Menu menu;
    // Start is called before the first frame update
    void Start()
    {
        state = "Idle";
        move.ResetGravity(0);
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Obstacle")){
            Die();
        }
    }

    public void Die(){
        state = "Dead";
        move.ResetGravity(0);
        score.End();
        music.PlayDie();
       
        StartCoroutine(Delay());

    }

    public void RestartAgain(){
         menu.ChangeMenu(true);
        transform.position = new Vector3(-8.93f, -0.69f, 0);
        

    }
    public void StartGame(){
        
        state = "Playing";
        move.ResetGravity(3);
        map.ClearStorage();
        menu.ChangeMenu(false);

    }

    IEnumerator Delay(){
        yield return new WaitForSeconds(1);
        RestartAgain();
    }

}
