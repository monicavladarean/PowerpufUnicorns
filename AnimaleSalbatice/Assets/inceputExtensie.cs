using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalVariable
{
    public int lupCheck, caprioaraCheck;

    private static GlobalVariable instance;

    public static GlobalVariable Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GlobalVariable();
            }

            return instance;
        }
    }
}

public class inceputExtensie : MonoBehaviour
{
    GameObject caprioara,vulpe,urs,veverita,lup;
    int count;

    int inceputAudioStarted = 0, ok = 1;

    AudioSource inceputAudio;

    GameObject helpButton;
    AudioSource helpAudio;

    // Start is called before the first frame update
    void Start()
    {

        caprioara = GameObject.Find("caprioara");
        urs = GameObject.Find("urs");
        vulpe = GameObject.Find("vulpe");
        veverita = GameObject.Find("veverita");
        lup = GameObject.Find("lup");

        inceputAudio = GameObject.Find("inceputExtensie").GetComponent<AudioSource>();

        if (GlobalVariable.Instance.lupCheck != 1 && GlobalVariable.Instance.caprioaraCheck != 1) 
        {
           inceputAudio.Play(0);
        }

        helpButton = GameObject.Find("semnIntrebare");
        helpAudio = GameObject.Find("sarcinaHelp").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inceputAudio.isPlaying && ok == 1)
        {
            ok = 0;
        }
        else if (!inceputAudio.isPlaying && Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "semnIntrebare")
                {
                    helpAudio.Play(0);
                }
                if (!helpAudio.isPlaying)
                {
                    if (hit.collider.name == "lup")
                    {
                        SceneManager.LoadScene("lupExtensie");
                    }
                    else if (hit.collider.name == "urs")
                    {
                        SceneManager.LoadScene("ursExtensie");
                    }
                    else if (hit.collider.name == "veverita")
                    {
                        SceneManager.LoadScene("veveritaExtensie");
                    }
                    else if (hit.collider.name == "vulpe")
                    {
                        SceneManager.LoadScene("vulpeExtensie");
                    }
                    else if (hit.collider.name == "caprioara")
                    {
                        SceneManager.LoadScene("caprioaraExtensie");
                    }
                }
            }
        }
    }
}
