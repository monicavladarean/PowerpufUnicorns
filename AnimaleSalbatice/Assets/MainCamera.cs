using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCamera : MonoBehaviour
{

    MainCamera mainCamera;
    Image image1;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<MainCamera>();
    }

    // Update is called once per frame
    void Update() {
        
    }
}
