﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *      ,*-~"`^"*u_                                _u*"^`"~-*,
 *  p!^       /  jPw                            w9j \        ^!p
 *w^.._      /      "\_                      _/"     \        _.^w
 *     *_   /          \_      _    _      _/         \     _*
 *       q /           / \q   ( `--` )   p/ \          \   p
 *       jj5****._    /    ^\_) o  o (_/^    \    _.****6jj
 *                *_ /      "==) ;; (=="      \ _*
 *                 `/.w***,   /(    )\   ,***w.\"
 *                  ^ ilmk ^c/ )    ( \c^      ^
 *                          'V')_)(_('V'
 * visite la baticueva Llorente del Murcielago ..
 * ya le han dicho si al matrimonio gay y nos han excomulgado a todos...
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class BatHead : MonoBehaviour
{
    public Texture2D soundCloudIcon;
    protected bool audio_is_on = true;
    public AudioSource audioData;

    void Start()
    {
        this.audioData = GetComponent<AudioSource>();
        this.audioData.Play(0);
    }

    void OnGUI(){
        if (GUI.Button (new Rect (10,10, 55, 50), soundCloudIcon)) 
        {
            if(this.audio_is_on){
                this.audioData.Pause();
                this.audio_is_on = false;
            }else{
                this.audioData.Play(0);
                this.audio_is_on = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
