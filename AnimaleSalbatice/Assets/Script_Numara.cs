using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_Numara : MonoBehaviour
{
    GameObject nr_1, nr_2, nr_3, peste, mie, ghind, iarb, carne, pic;
    int count;
    int finalAudioStarted;

    AudioSource inceputAudio;
    AudioSource finalAudio;

    // Start is called before the first frame update
    void Start()
    {
        finalAudioStarted = 0;
        count = 1;

        nr_1 = GameObject.Find("unu");
        nr_2 = GameObject.Find("doi");
        nr_3 = GameObject.Find("trei");
        peste = GameObject.Find("pesti");
        mie = GameObject.Find("miere");
        ghind = GameObject.Find("ghinde");
        iarb = GameObject.Find("iarba");
        carne = GameObject.Find("carnuri");
        pic = GameObject.Find("picnic");

        nr_1.transform.position = new Vector3(-1000f, -1000f, -1000f);
        nr_2.transform.position = new Vector3(-1000f, -1000f, -1000f);
        nr_3.transform.position = new Vector3(-1000f, -1000f, -1000f);
        pic.transform.position = new Vector3(-1000f, -1000f, -1000f);

        inceputAudio = GameObject.Find("inceput_2").GetComponent<AudioSource>();
        inceputAudio.Play(0);
        finalAudio = GameObject.Find("final_joc (1)").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inceputAudio.isPlaying &&  Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "iarba")
                {
                    if (count == 1)
                    {
                        Debug.Log("vreau ca 1 sa apara");
                        count++;
                        nr_1.transform.position = new Vector3(-0.10139f, -0.16f, -2f);
                        Debug.Log("1 a aparut");
                        iarb.transform.position = new Vector3(-1000f, -1000f, -1000f);
                        Debug.Log("iarba a disparut");
                    }
                }
                else if (hit.collider.name == "pesti")
                {
                    if (count == 2)
                    {
                        Debug.Log("vreau ca 1 sa dispara");
                        nr_1.transform.position = new Vector3(-1000f, -1000f, -1000f);
                        count++;
                        nr_3.transform.position = new Vector3(-0.10139f, -0.16f, -2f);
                        Debug.Log("3 a aparut");
                        peste.transform.position = new Vector3(-1000f, -1000f, -1000f);
                    }
                }
                else if (hit.collider.name == "ghinde")
                {
                    if (count == 3)
                    {
                        Debug.Log("vreau ca 3 sa dispara");
                        nr_3.transform.position = new Vector3(-1000f, -1000f, -1000f);
                        count++;
                        nr_2.transform.position = new Vector3(-0.10139f, -0.16f, -2f);
                        Debug.Log("2 a aparut");
                        ghind.transform.position = new Vector3(-1000f, -1000f, -1000f);
                    }
                }
                else if (hit.collider.name == "miere")
                {
                    if (count == 4)
                    {
                        Debug.Log("vreau ca 2 sa dispara");
                        nr_2.transform.position = new Vector3(-1000f, -1000f, -1000f);
                        count++;
                        nr_1.transform.position = new Vector3(-0.10139f, -0.16f, -2f);
                        Debug.Log("1 a aparut");
                        mie.transform.position = new Vector3(-1000f, -1000f, -1000f);
                    }
                }
                else if (hit.collider.name == "carnuri")
                {
                    if (count == 5)
                    {
                        Debug.Log("vreau ca 1 sa dispara");
                        nr_1.transform.position = new Vector3(-1000f, -1000f, -1000f);
                        count++;
                        nr_2.transform.position = new Vector3(-0.10139f, -0.16f, -2f);
                        Debug.Log("2 a aparut");
                        carne.transform.position = new Vector3(-1000f, -1000f, -1000f);
                    }
                }
                else if (hit.collider.name == "doi")
                {
                    if (count == 6)
                    {
                        Debug.Log("vreau ca 2 sa dispara");
                        nr_2.transform.position = new Vector3(-1000f, -1000f, -1000f);
                        count++;
                        pic.transform.position = new Vector3(0.62f, -0.1f, -2f);
                        Debug.Log("Picnicul e gata!!!");
                        finalAudioStarted = 1;
                        finalAudio.Play(0);
                    }
                }
            }
        }
        if (finalAudioStarted == 1 && !finalAudio.isPlaying)
        {
            SceneManager.LoadScene("Mancare");
        }
    }
}
