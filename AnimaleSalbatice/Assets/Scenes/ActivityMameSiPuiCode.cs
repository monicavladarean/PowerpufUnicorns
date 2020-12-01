using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityCode : MonoBehaviour
{
    //private GameObject[] animals;

    // Start is called before the first frame update
    void Start()
    {
        /*animals[0] = GameObject.FindWithTag("Lup");
        animals[1] = GameObject.FindWithTag("Vulpe");
        animals[2] = GameObject.FindWithTag("Veverita");
        animals[3] = GameObject.FindWithTag("Caprioara");
        animals[4] = GameObject.FindWithTag("Urs");*/
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit) )
            {
                if (hit.collider.name == "Lup")
                {
                    Debug.Log("Lup is clicked by mouse");
                    GameObject.Find("Lup").SetActive(false);
                }

                if (hit.collider.name == "Veverita")
                {
                    Debug.Log("Veverita is clicked by mouse");
                    GameObject.Find("Veverita").SetActive(false);
                }

                if (hit.collider.name == "Vulpe")
                {
                    Debug.Log("Vulpe is clicked by mouse");
                    GameObject.Find("Vulpe").SetActive(false);
                }

                if (hit.collider.name == "Urs")
                {
                    Debug.Log("Urs is clicked by mouse");
                    GameObject.Find("Urs").SetActive(false);
                }

                if (hit.collider.name == "Caprioara")
                {
                    Debug.Log("Caprioara is clicked by mouse");
                    GameObject.Find("Caprioara").SetActive(false);
                }
            }
        }
    }
}
