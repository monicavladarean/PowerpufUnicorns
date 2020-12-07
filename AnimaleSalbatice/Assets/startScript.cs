﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startScript : MonoBehaviour
{
    GameObject startButon;

    // Start is called before the first frame update
    void Start()
    {
        startButon = GameObject.Find("startButon");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.name == "startButon")
                {
                    Debug.Log("game starts");
                    SceneManager.LoadScene("ActivityMamesiPui");
                }
            }
        }
    }
}
