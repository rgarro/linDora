﻿using System.Collections;
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
 *
 * Cada dia el capitalismo se esta haciendo mas fuerte ...
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class carriageElevator : MonoBehaviour
{
    private float vSliderValue = 0.0f;
    public int xGui = 25;
    public int yGui = 77;
    public float carriageGroundLevel;
    public float carriageTopLevel;
    public GameObject carriageMesh;
    public double decimalRatio = -0.222;//Larry and Curly split the loot in the ratio 3:7.

    void Start()
    {
        
    }

    void OnGUI(){
        GUI.Label (new Rect (this.xGui,this.yGui, 100, 30), "Lift Carriage");
        vSliderValue = GUI.VerticalSlider (new Rect (this.xGui,this.yGui+20, 200, 100), vSliderValue, 10.0f, 0.0f);
       double zPos = (vSliderValue > 0 )? vSliderValue*this.decimalRatio:1.92;
        Debug.Log(zPos);
        this.carriageMesh.transform.position = new Vector3((float)1.0595,-17,(float)zPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}