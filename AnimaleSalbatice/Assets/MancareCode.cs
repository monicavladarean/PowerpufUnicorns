using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MancareCode : MonoBehaviour
{
    private int count;
    private GameObject farfurie_lup, farfurie_vulpe, farfurie_caprioara, farfurie_urs, farfurie_veverita, peste, miere, iarba, ghinde, carne, carneLaLup;
    private string lastTagClicked;

    private Dictionary<string, int> errorCount;

    void Start()
    {
        count = 0;
        farfurie_lup = GameObject.Find("farfurie-lup");
        farfurie_caprioara = GameObject.Find("farfurie-caprioara");
        farfurie_vulpe = GameObject.Find("farfurie-vulpe");
        farfurie_veverita = GameObject.Find("farfurie-veverita");
        farfurie_urs = GameObject.Find("farfurie-urs");

        peste = GameObject.Find("peste");
        carne = GameObject.Find("carne");
        ghinde = GameObject.Find("ghinde");
        miere = GameObject.Find("miere");
        iarba = GameObject.Find("iarba");


        lastTagClicked = "";

        errorCount = new Dictionary<string, int>();

        errorCount.Add("peste", 0);
        errorCount.Add("carne", 0);
        errorCount.Add("miere", 0);
        errorCount.Add("ghinde", 0);
        errorCount.Add("iarba", 0);

    }

    void verificareEroriCaSaFacemJocul()
    {
        //luam din dict mancarea care a fost gresit de 2 ori
        string key = "";
        foreach (KeyValuePair<string, int> entry in this.errorCount)
        {
            if (entry.Value == 2)
            {
                key = entry.Key;
                break;
            }
        }
        if (key != "")
        {
            Debug.Log("ii facem partea acuma pt " + key);
            mancareaMergeSinguraLaFarfurie();
            lastTagClicked = "";
            errorCount[key] = 0;
        }
    }


    void mancareaMergeSinguraLaFarfurie()
    {
        if (this.lastTagClicked == "peste")
        {
            // peste.GetComponent<Renderer>().enabled = false;
            peste.transform.position = new Vector3(0.17f, -3.8f, -3f);
            peste.transform.localScale = new Vector3(0.4067419f, 0.3532811f, 1f);
            count++;
        }

        else if (this.lastTagClicked == "ghinde")
        {
            //  farfurie_veverita.GetComponent<Renderer>().enabled = false;
            ghinde.transform.position = new Vector3(4.7f, -3.4f, -3f);
            ghinde.transform.localScale = new Vector3(0.5249423f, 0.5696594f, 1f);
            count++;
        }

        else if (this.lastTagClicked == "iarba")
        {
            //  farfurie_caprioara.GetComponent<Renderer>().enabled = false;
            iarba.transform.position = new Vector3(1.4f, 2f, -3f);
            iarba.transform.localScale = new Vector3(0.5329899f, 0.4602287f, 1f);
            count++;
        }
        else if (this.lastTagClicked == "miere")
        {
            // farfurie_urs.GetComponent<Renderer>().enabled = false;
            miere.transform.position = new Vector3(2.29f, -1.37f, -3f);
            miere.transform.localScale = new Vector3(0.6076733f, 0.6160328f, 1f);
            count++;
        }
        else if (this.lastTagClicked == "carne")
        {
            // farfurie_lup.GetComponent<Renderer>().enabled = false;
            carne.transform.position = new Vector3(-3.4f, -3.4f, -3f);
            carne.transform.localScale = new Vector3(0.4105837f, 0.5157263f, 1f);
            count++;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //mouse is clicked
            RaycastHit hit;
            Debug.Log("hit ");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log("ray");
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.tag);
                if (hit.collider.tag == "peste")
                {

                    lastTagClicked = "peste";
                    Debug.Log("peste clicked ");

                }
                else if (hit.collider.tag == "farfurie-vulpe")
                {
                    if (lastTagClicked == "peste")
                    {
                        Debug.Log("farfurie-vulpe clicked");
                        mancareaMergeSinguraLaFarfurie();
                        lastTagClicked = "";
                    }
                    else
                    {
                        //amintire sa apese pe mancare si apoi pe farfurie
                        if (lastTagClicked == "")
                        {
                            Debug.Log("sunet pt amintire sa apese pe mancare si apoi pe farfurie");
                        }
                        else
                        {
                            Debug.Log("a gresit farfuria aleasa si atunci mai incearca odata si la 2 greseli ii rezolvam partea");
                            this.errorCount[lastTagClicked] = this.errorCount[lastTagClicked] + 1;
                            verificareEroriCaSaFacemJocul();

                        }
                    }
                }




                else if (hit.collider.tag == "ghinde")
                {
                    Debug.Log("ghinde clicked");
                    lastTagClicked = "ghinde";
                }
                else if (hit.collider.tag == "farfurie-veverita")
                {
                    if (lastTagClicked == "ghinde")
                    {
                        Debug.Log("farfurie-veverita clicked");
                        mancareaMergeSinguraLaFarfurie();
                        lastTagClicked = "";
                    }
                    else
                    {
                        //amintire sa apese pe mancare si apoi farfuria
                        if (lastTagClicked == "")
                        {
                            Debug.Log("sunet pt amintire sa apese pe mancare si apoi pe farfurie");
                        }
                        else
                        {
                            Debug.Log("a gresit farfuria aleasa si atunci mai incearca odata si la 2 greseli ii rezolvam partea");
                            this.errorCount[lastTagClicked] = this.errorCount[lastTagClicked] + 1;
                            verificareEroriCaSaFacemJocul();
                        }
                    }
                }

                else if (hit.collider.tag == "iarba")
                {
                    Debug.Log("iarba clicked");
                    lastTagClicked = "iarba";

                }
                else if (hit.collider.tag == "farfurie-caprioara")
                {
                    if (lastTagClicked == "iarba")
                    {
                        Debug.Log("farfurie-caprioara clicked");
                        mancareaMergeSinguraLaFarfurie();
                        lastTagClicked = "";
                    }
                    else
                    {
                        //amintire sa apese pe macare si apoi pe farfurie
                        if (lastTagClicked == "")
                        {
                            Debug.Log("sunet pt amintire sa apese pe mancare si apoi pe farfurie");
                        }
                        else
                        {
                            Debug.Log("a gresit farfuria aleasa si atunci mai incearca odata si la 2 greseli ii rezolvam partea");
                            this.errorCount[lastTagClicked] = this.errorCount[lastTagClicked] + 1;
                            verificareEroriCaSaFacemJocul();
                        }
                    }
                }

                else if (hit.collider.tag == "miere")
                {
                    Debug.Log("miere clicked");
                    lastTagClicked = "miere";
                }
                else if (hit.collider.tag == "farfurie-urs")
                {
                    if (lastTagClicked == "miere")
                    {
                        Debug.Log("farfurie-urs clicked");

                        mancareaMergeSinguraLaFarfurie();
                        lastTagClicked = "";
                    }
                    else
                    {
                        //amintire sa apese pe mancare si apoi pe farfurie
                        if (lastTagClicked == "")
                        {
                            Debug.Log("sunet pt amintire sa apese pe mancate si apoi pe farfurie");
                        }
                        else
                        {
                            Debug.Log("a gresit farfuria aleasa si atunci mai incearca odata si la 2 greseli ii rezolvam partea");
                            this.errorCount[lastTagClicked] = this.errorCount[lastTagClicked] + 1;
                            verificareEroriCaSaFacemJocul();
                        }
                    }
                }

                else if (hit.collider.tag == "carne")
                {
                    Debug.Log("carne clicked");
                    lastTagClicked = "carne";

                }
                else if (hit.collider.tag == "farfurie-lup")
                {
                    if (lastTagClicked == "carne")
                    {
                        Debug.Log("farfurie-lup clicked");
                        mancareaMergeSinguraLaFarfurie();
                        lastTagClicked = "";
                    }
                    else
                    {
                        //amintire sa apese pe mancare si apoi pe farfurie
                        if (lastTagClicked == "")
                        {
                            Debug.Log("sunet pt amintire sa apese pe mancare si apoi pe farfurie");
                        }
                        else
                        {
                            Debug.Log("a gresit farfuria aleasa si atunci mai incearca odata si la 2 greseli ii rezolvam partea");
                            this.errorCount[lastTagClicked] = this.errorCount[lastTagClicked] + 1;
                            verificareEroriCaSaFacemJocul();
                        }
                    }
                }

                if (count == 5)
                {
                    SceneManager.LoadScene("Activity4");
                }

            }
        }
    }

}


