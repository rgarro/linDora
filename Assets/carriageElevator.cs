using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *      ---------------------------.
 *   `/""""/""""/|""|'|""||""|   ' \.
 *   /    /    / |__| |__||__|      |
 *  /----------=====================|
 * | \  /V\  /    _.               |
 * |()\ \W/ /()   _            _   |
 * |   \   /     / \          / \  |-( )
 *  =C========C==_| ) |--------| ) _/==] _-{_}_)
 *  \_\_/__..  \_\_/_ \_\_/ \_\_/__.__.
 * -- sheryl crow is a red tara projection I asked her for yellow light ..--
 *      Summon money on my paypal , I'd buy a fishtank and put a blessed tara I have inside
 *        Then mollys and tetras would be circumbalating producing infinite merit. 
 *        Dharmakaya state machines, Artemia Salina bliss, rusty bigcat 8'5 ...
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class carriageElevator : MonoBehaviour
{
    private float vSliderValue = 0.0f;
    public int xGui = 25;
    public int yGui = 77;
    void Start()
    {
        
    }

    void OnGUI(){
        GUI.Label (new Rect (this.xGui,this.yGui, 100, 30), "Lift Carriage");
        vSliderValue = GUI.VerticalSlider (new Rect (this.xGui,this.yGui+20, 100, 30), vSliderValue, 10.0f, 0.0f);
        Debug.Log("Here again....");
        Debug.Log(vSliderValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
