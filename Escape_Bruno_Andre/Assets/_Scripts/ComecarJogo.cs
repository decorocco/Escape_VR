using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComecarJogo : MonoBehaviour
{
    GameManager gm;

    void OnEnable()
    {
        gm = GameManager.GetInstance();
    }

    public void Comecarclick() 
    {
        gm.ChangeState(GameManager.GameState.GAME);
    }
    
}
