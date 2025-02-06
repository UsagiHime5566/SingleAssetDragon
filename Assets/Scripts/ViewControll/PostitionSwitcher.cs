using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostitionSwitcher : MonoBehaviour
{
    public GameObject UserHead;
    public GameObject PostitionCube;

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            UserHead.transform.position -= Time.deltaTime * new Vector3(1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            UserHead.transform.position += Time.deltaTime * new Vector3(1, 0, 0);
        }
        
        if(Input.GetKeyUp(KeyCode.P))
        {
            PostitionCube.SetActive(!PostitionCube.activeSelf);
        }
    }
}
