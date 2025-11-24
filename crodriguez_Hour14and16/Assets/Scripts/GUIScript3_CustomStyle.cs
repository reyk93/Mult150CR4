using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript3_CustomStyle : MonoBehaviour
{
    public GUIStyle style;

    void OnGUI() 
    {
        if (GUI.Button(new Rect(5, 5, 100, 30),"Hello World", style)) 
        {
        
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
