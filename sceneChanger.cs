﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(int buttonNumber)
    {
        Application.LoadLevel(Application.loadedLevel.GetHashCode() + buttonNumber);
    }
}
