using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGanon : MonoBehaviour
{
    GameManager gm;

    void Start()
    {
        gm = GameManager.GetInstance();
    }

    private bool col = false;
    private void OnCollisionEnter(Collision other) {
        if (gm.gameState == GameManager.GameState.GAME && col == false){
            Debug.Log(gm.score);
            col = true;
            Destroy(this.gameObject);
            gm.score +=1;
            
        }
    }
}
