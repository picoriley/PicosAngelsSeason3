﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    void Awake()
    {
        // hostile singleton
        if (instance)
        {
            Debug.Log("Destroying irrelevant GameController instance");
            Destroy(instance.gameObject);
        }

        instance = this;
        Dialogue.instance.SetText("Ahahahaaha");
    }
    
    // Use this for initialization
    void Start ()
    {

    }
    
    // Update is called once per frame
    void Update ()
    {
        
    }
}
