using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Practice : MonoBehaviour
{
    public VideoPlayer[] VideoContains;
    //0 null
    //1 正面Front
    //2 斜地面Floor1
    //3 斜牆面Back
    //4 地面Floor2
    //5 右牆Right
    //6 左牆Left

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
