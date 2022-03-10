using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abre : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        animator.SetTrigger("abrir");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
