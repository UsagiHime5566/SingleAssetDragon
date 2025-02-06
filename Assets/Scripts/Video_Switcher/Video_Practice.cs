using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Practice : MonoBehaviour
{
    public VideoPlayer[] VideoContains;
    //0 null
    //1 ����Front
    //2 �צa��Floor1
    //3 ����Back
    //4 �a��Floor2
    //5 �k��Right
    //6 ����Left

    public VideoClip[] videoClips;
    // Start is called before the first frame update
    void Start()
    {
        SetVideos(videoClips);
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
