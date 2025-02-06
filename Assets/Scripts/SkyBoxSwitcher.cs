using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxSwitcher : MonoBehaviour
{
    public Material[] skymaterials;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            RenderSettings.skybox = skymaterials[0];
        }
        else if(Input.GetKeyUp(KeyCode.Alpha2))
        {
            RenderSettings.skybox = skymaterials[1];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            RenderSettings.skybox = skymaterials[2];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            RenderSettings.skybox = skymaterials[3];
        }
    }
}
