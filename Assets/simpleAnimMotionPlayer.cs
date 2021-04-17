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
    private AnimatorClipInfo[] m_AnimatorClipInfo;
    public string stateName = "TurningState";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("here with the anim");
        this.arnAnim = GetComponent<Animator>();
        //Get the animator clip information from the Animator Controller
        m_AnimatorClipInfo = arnAnim.GetCurrentAnimatorClipInfo(0);
        //Output the name of the starting clip
        Debug.Log("Starting clip : " + m_AnimatorClipInfo[0].clip);
        this.arnAnim.Play(this.stateName);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (null != this.arnAnim)
            {
                Debug.Log(this.stateName);
                this.arnAnim.Play(this.stateName, 0, 0.25f);
            }
        }
    }
}
