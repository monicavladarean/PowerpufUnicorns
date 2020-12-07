using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MamePuiCode : MonoBehaviour
{
    GameObject lup, veverita, urs, vulpe, caprioara;
    GameObject caprioaraBebe, lupBebe, ursBebe, vulpeBebe, veveritaBebe;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 1;

        caprioara = GameObject.Find("Caprioara"); //1
        lup = GameObject.Find("Lup"); //2
        urs = GameObject.Find("Urs"); //3
        vulpe = GameObject.Find("Vulpe"); //4
        veverita = GameObject.Find("Veverita"); //5

        caprioaraBebe = GameObject.Find("CaprioaraBebe");
        ursBebe = GameObject.Find("UrsBebe");
        vulpeBebe = GameObject.Find("VulpeBebe");
        veveritaBebe = GameObject.Find("VeveritaBebe");
        lupBebe = GameObject.Find("LupBebe");

        caprioaraBebe.transform.position = new Vector3(0.41f, -3.09f, -2f);
        lupBebe.transform.position = new Vector3(-1000f, -1000f, -1000f);
        ursBebe.transform.position = new Vector3(-1000f, -1000f, -1000f);
        veveritaBebe.transform.position = new Vector3(-1000f, -1000f, -1000f);
        vulpeBebe.transform.position = new Vector3(-1000f, -1000f, -1000f);

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

                if (hit.collider.name == "Caprioara")
                {
                    if (count == 1)
                    {
                        Debug.Log("Caprioara is clicked by mouse");
                        caprioara.SetActive(false);
                        count++;
                        caprioaraBebe.transform.position = new Vector3(-1000f, -1000f, -1000f);
                        lupBebe.transform.position = new Vector3(0.41f, -3.09f, -2f);
                    }
                }

                else if (hit.collider.name == "Lup")
                {
                    if (count == 2)
                    {
                        Debug.Log("Lup is clicked by mouse");
                        lup.SetActive(false);
                        count++;
                        lupBebe.transform.position = new Vector3(-1000f, -1000f, -1000f);
                        ursBebe.transform.position = new Vector3(0.41f, -3.09f, -2f);
                    }
                }

                else if (hit.collider.name == "Urs")
                {
                    if (count == 3)
                    {
                        Debug.Log("Urs is clicked by mouse");
                        urs.SetActive(false);
                        count++;
                        ursBebe.transform.position = new Vector3(-1000f, -1000f, -1000f);
                        vulpeBebe.transform.position = new Vector3(0.41f, -3.09f, -2f);
                    }
                }

                else if (hit.collider.name == "Vulpe")
                {
                    if (count == 4)
                    {
                        Debug.Log("Vulpe is clicked by mouse");
                        vulpe.SetActive(false);
                        count++;
                        vulpeBebe.transform.position = new Vector3(-1000f, -1000f, -1000f);
                        veveritaBebe.transform.position = new Vector3(0.41f, -3.09f, -2f);
                    }
                }

                else if (hit.collider.name == "Veverita")
                {
                    if (count == 5)
                    {
                        Debug.Log("Veverita is clicked by mouse");
                        veverita.SetActive(false);
                        count++;
                        veveritaBebe.transform.position = new Vector3(-1000f, -1000f, -1000f);
                    }
                }
            }
        }
    }
}
