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
 * 
 *   float in the sum R√y 99 red ballons Gobi Vajrayogini 
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class carriageElevator : MonoBehaviour
{
    private float lootSliderValue = 0.0f;
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
        lootSliderValue = GUI.VerticalSlider (new Rect (this.xGui,this.yGui+20, 200, 100), lootSliderValue, 10.0f, 0.0f);
        double zPos = (lootSliderValue > 0 )? lootSliderValue*this.decimalRatio:1.92;
        float fZPos = (float)zPos;
        this.carriageMesh.transform.localPosition = new Vector3(this.carriageMesh.transform.localPosition.x,this.carriageMesh.transform.localPosition.y,fZPos);
    }

    // Update is called once per frame
    void Update()
    {
        //will play sound onSlide
    }
}
