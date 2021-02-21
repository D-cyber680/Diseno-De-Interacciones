using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema : MonoBehaviour
{

    public static Boolean esta_en_lista(String[] nombres, String nombre)
    {
        Boolean esta = false;
        foreach (String name in nombres)
        {
            if (name == nombre)
            {
                esta = true;
                break;
            }
            else
            {
                esta = false;
            }
        }
        return esta;
    }
    // Start is called before the first frame update
    void Start()
    {
        Boolean x;
        String[] nombres = { "Abimael", "Araceli", "Brandon", "Cristian", "Daniel",
            "Edgar","Ivan","Isaac","Nereo"};
        Debug.Log("Esta Brandon? ");
        x = esta_en_lista(nombres, "Brandon");
        if (x)
        {
            Debug.Log("Si");
        }
        else
        {
            Debug.Log("No");
        }
    }

  
    
}
