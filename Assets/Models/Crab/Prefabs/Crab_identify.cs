using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_identify : MonoBehaviour
{
    public Texture[] MainTexture;
    public SkinnedMeshRenderer[] CrabMesh;
    
    private void Awake()
    {
        CrabMesh = new SkinnedMeshRenderer[23];
        CrabMesh = GetComponentsInChildren<SkinnedMeshRenderer>();
    }
    void Start()
    {
        float scaleV = Random.Range(.85f, 1.5f);
        //float scaleV = Random.Range(.5f, 2f);
        gameObject.transform.localScale = new Vector3(scaleV, scaleV, scaleV);
        int R = Random.Range(0, MainTexture.Length);
        for (int i = 0; i < CrabMesh.Length; i++)
        {
            Material Crab_M = CrabMesh[i].material;
            Crab_M.SetTexture("_BaseMap", MainTexture[R]);
            Crab_M.SetTexture("_EmissionMap", MainTexture[R]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
