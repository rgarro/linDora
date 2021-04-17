using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Will play state from animator 
*
*/
public class simpleAnimMotionPlayer : MonoBehaviour
{
    private Animator arnAnim;
    public string stateName = "turningradar";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("here with the animation");
        this.arnAnim = GetComponent<Animator>();
        //Get the animator clip information from the Animator Controller
        this.arnAnim.Play(this.stateName);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (null != this.arnAnim)
            {
                Debug.Log(this.stateName);
                Debug.Log(arnAnim);
                this.arnAnim.Play("turningradar",2);
            }
        }
    }
}
