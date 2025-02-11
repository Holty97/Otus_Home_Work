using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HW2 : MonoBehaviour
{
    public NPC npc1;


    // Start is called before the first frame update
    void Start()
    {
        First();
        Second();
    }

    private void First()
    {
        int a = 1;
        float b = 2f;
        bool c = true;
        string d = "Идем гулять";
        
        Debug.LogError(a);
        Debug.LogError(b);
        Debug.LogError(c);
        Debug.LogError(d);
    }

    private void Second()
    {
        Debug.Log("Health on Start:" + npc1.health);
        npc1.Damage(25);
        npc1.Damage(25.27f);
        
        npc1.BaseDamageMultiplier(12.5f,15);
        
    }
    
}
