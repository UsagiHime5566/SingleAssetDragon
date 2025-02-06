using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using com.rfilkov.kinect;
using UnityEngine.UI;

public class PersonDetect : MonoBehaviour
{
    //public KinectManager kinect;
 
    public Vector3 OffsetVec;

    public InputField InputX;
    public InputField InputZ;

    public Text OffsetX;
    public Text OffsetZ;

    public ulong PickUser;
    public GameObject UserView;

    public bool Followed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Followed)
        {
            DetectionOffset(); //根據輸入數值調整偏移數值
            
            // if (kinect.GetUsersCount() == 0)
            // {
            //     UserHeadReset();
            // }
            // else if(kinect.GetUsersCount() > 0 && PickUser == 999)
            // {
            //     for (int i = 0; i < kinect.GetUsersCount(); i++)
            //     {
            //         ulong PickuserID = kinect.GetUserIdByIndex(i);
            //         Vector3 PickHandR = kinect.GetJointPosition(PickuserID, KinectInterop.JointType.HandtipRight);
            //         Vector3 PickHead = kinect.GetJointPosition(PickuserID, KinectInterop.JointType.Head);
            //         if (PickHead.y < PickHandR.y && PickUser != PickuserID)
            //         {
            //             PickUser = PickuserID; //舉手選人
            //         }
            //     }
                
            // }
            // else if (kinect.GetUsersCount() > 0 && PickUser != 999)
            // {
            //     UserHeadFollow();
            // }
        }
        else
        {
            UserHeadReset();
        }
       
        


    }
    public void BTSave()
    {
        OffsetX.text = InputX.text;
        OffsetZ.text = InputZ.text;
    }

    void DetectionOffset()
    {
        OffsetVec = new Vector3(float.Parse(OffsetX.text), 0, float.Parse(OffsetZ.text));
    }
    //根據輸入數值調整偏移數值
    void UserHeadFollow()
    {
        //Vector3 PickHead = kinect.GetJointPosition(PickUser, KinectInterop.JointType.Head);
        //UserView.transform.position = new Vector3(PickHead.x + OffsetVec.x, -0.005f, -0.525f);
    }
    //相機跟隨
    void UserHeadReset()
    {
        PickUser = 999;
        UserView.transform.position = new Vector3(0, -0.005f, -0.525f);
    }
    //相機歸零
}
