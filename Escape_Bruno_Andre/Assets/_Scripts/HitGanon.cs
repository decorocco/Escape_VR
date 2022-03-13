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

    void Update()
    {
        if (gm.gameState == GameManager.GameState.GAME){
            
        }
    }
}
