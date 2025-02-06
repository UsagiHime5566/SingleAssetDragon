using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Material[] SkyBox_M;
    public string CurrentMode;
    //public GameObject VideoObject;

    public GameObject InteractObject;

    public GameObject Dragon_Object;
    //public GameObject Crab_Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            if (CurrentMode == "Video") 
            {
                CurrentMode = "Interact";
                InteractObject.SetActive(true);
                //VideoObject.SetActive(false);

                Dragon_Object.SetActive(false);
                //Crab_Object.SetActive(false);
                RenderSettings.skybox = SkyBox_M[0];
            }
            else if (CurrentMode == "Interact")
            {
                CurrentMode = "Video";
                //VideoObject.SetActive(true);
                InteractObject.SetActive(false);
                RenderSettings.skybox = SkyBox_M[0];
            }

        }
        if (CurrentMode == "Interact")
        {
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                Dragon_Object.SetActive(true);
                //Crab_Object.SetActive(false);
                RenderSettings.skybox = SkyBox_M[1];
            }
            else if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                Dragon_Object.SetActive(false);
                //Crab_Object.SetActive(true);
                RenderSettings.skybox = SkyBox_M[2];
            }else if(Input.GetKeyUp(KeyCode.Alpha3))
            {
                Dragon_Object.SetActive(false);
                //Crab_Object.SetActive(false);
                RenderSettings.skybox = SkyBox_M[3];
            }
        }
    }
}
