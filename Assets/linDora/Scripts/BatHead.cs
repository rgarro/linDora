using System.Collections;
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
 * ya le han dicho si al matrimonio gay y nos han excomulgado en llorente de Torrenueva ...
 *
 * @author Rolando <rgarro@gmail.com>
 */
public class BatHead : MonoBehaviour
{
    public Texture2D soundCloudIcon;
    void Start()
    {
        
    }

    void OnGUI(){
        if (GUI.Button (new Rect (10,10, 100, 50), soundCloudIcon)) 
        {
            print ("you clicked the icon");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
