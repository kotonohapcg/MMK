﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GameStart()
    {
        SceneManager.LoadScene("DifficultScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
