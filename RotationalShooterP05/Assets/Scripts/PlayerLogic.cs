﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D tempCollision)
    {
        if(tempCollision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
