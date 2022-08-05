using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW3 : MonoBehaviour
{
    string heroname = "Loy";
    int heropower = 20;
    string villanname = "jake";
    int villanpower = 19;
    float playerspeed = 2,5f;
    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villanpower)
        {

        }    
        else if (heropower == villanpower)
        {

        }
        else (heropower < villanpower)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setspeed (float newspeed)
    {
        print("old speed is" + playerspeed);
        playerspeed = newspeed;
        print("new speedis" + playerspeed);
    }
}
