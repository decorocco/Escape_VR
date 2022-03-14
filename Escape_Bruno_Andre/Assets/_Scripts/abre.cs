using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abre : MonoBehaviour
{

    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        //animator = gameObject.GetComponent<Animator>();
        //animator.SetTrigger("abrir");
        gm = GameManager.GetInstance();
    }

    
    // Update is called once per frame
    void Update()
    {
        if (gm.gameState == GameManager.GameState.GAME)
            if (gm.score >= 3)
            {
                Destroy(this.gameObject);
                gm.ChangeState(GameManager.GameState.ENDGAME);
            }
    }
}
