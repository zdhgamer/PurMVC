﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainApp : MonoBehaviour {

    private void Awake()
    {
        
    }

    private void Start()
    {
        AppFacade.Instance.StartUp();
    }
}
