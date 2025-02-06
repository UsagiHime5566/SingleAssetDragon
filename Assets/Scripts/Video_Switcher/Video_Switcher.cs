using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Switcher : MonoBehaviour
{
    //正面Front>斜地面Floor1>地面Floor2>斜牆面Back
    public VideoPlayer[] VideoContains;
    //0 null
    //1 正面Front
    //2 斜地面Floor1
    //3 斜牆面Back
    //4 地面Floor2
    //5 右牆Right
    //6 左牆Left

    public VideoClip[] videoClipOne;
    public VideoClip[] videoClipTwo;
    public VideoClip[] videoClipThree;
    public VideoClip[] videoClipFour;
    public VideoClip[] videoClipFive;
    public VideoClip[] videoClipSix;
    public VideoClip[] videoClipSeven;
    public VideoClip[] videoClipEight;
    public VideoClip[] videoClipNine;
    public VideoClip[] videoClipTen;
    public VideoClip[] videoClipEleven;
    public VideoClip[] videoClipTwelve;
    public VideoClip[] videoClipThirteen;
    public VideoClip[] videoClipFourteen;
    public VideoClip[] videoClipFifteen;
    public VideoClip[] videoClipSixteen;
    public VideoClip[] videoClipSeventeen; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            //SetVideos(videoClipOne);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            SetVideos(videoClipTwo);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            //SetVideos(videoClipThree);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            //SetVideos(videoClipFour);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            SetVideos(videoClipFive);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            SetVideos(videoClipSix);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            SetVideos(videoClipSeven);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            SetVideos(videoClipEight);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            SetVideos(videoClipNine);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            SetVideos(videoClipTen);
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            SetVideos(videoClipEleven);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            SetVideos(videoClipTwelve);
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            SetVideos(videoClipThirteen);
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            SetVideos(videoClipFourteen);
        }
        else if (Input.GetKeyUp(KeyCode.T))
        {
            SetVideos(videoClipFifteen);
        }
        else if (Input.GetKeyUp(KeyCode.Y))
        {
            SetVideos(videoClipSixteen);
        }
        else if (Input.GetKeyUp(KeyCode.U))
        {
            SetVideos(videoClipSeventeen);
        }
    }
    void SetVideos(VideoClip[] Videos)
    {
        for (int V = 1; V < Videos.Length; V++)
        {
            if (Videos[V] != null)
            {
                VideoContains[V].clip = Videos[V];
            }
            else
            {
                VideoContains[V].clip = null;
                VideoContains[V].Stop();
            }
           
        }
        for (int P = 1; P < Videos.Length; P++)
        {
            if (VideoContains[P] != null)
            {
                VideoContains[P].Play();
                VideoContains[P].targetTexture.Release();
            }
                
        }
    }
}
