using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleAnimMotionPlayer : MonoBehaviour
{
    private Animator arnAnim;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("here with the anim");
        this.arnAnim = GetComponent<Animator>();
        this.arnAnim.Play("turningradar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
