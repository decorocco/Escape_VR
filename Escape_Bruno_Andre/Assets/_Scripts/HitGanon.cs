using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGanon : MonoBehaviour
{
    GameManager gm;

    AudioSource audioSource = gameObject.GetComponent<AudioSource>();
    void Start()
    {
        gm = GameManager.GetInstance();
    }

    private void OnCollisionEnter(Collision other) {
        if (gm.gameState == GameManager.GameState.GAME){
            audioSource.Stop();
        }
    }
}
