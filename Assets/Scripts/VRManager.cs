using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VRManager : MonoBehaviour
{
    public CanvasGroup HowTo;
    public GameObject HowToPlane;
    public float fadeTime = 0.7f;

    public float waitToPlayGame = 5;
    public float hightToPlayGame = 3;

    public float waitToStopGame = 5;
    public float hightToStopGame = 1;

    public float moveSpeed; // 移動速率
    private Vector3 initialControllerPosition; // 初始手把位置

    public Transform RightHand;
    public Transform Head;
    public float RightHandPosAmp = 20;
    public float timeToControl = 0;
    public float timeToStop = 0;


    // void Start()
    // {
    //     initialControllerPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch); // 獲取初始手把位置
    // }

    // void Update()
    // {
    //     if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.LTouch))
    //     {
    //         Debug.Log("左手把的 A 按鈕被按下了！");

    //         //if(HowTo.alpha == 0) HowTo.DOFade(1, fadeTime);
    //         //else HowTo.DOFade(0, fadeTime);

    //         HowToPlane.SetActive(!HowToPlane.activeSelf);
    //     }

    //     // 檢測右手把的 A 按鈕
    //     if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
    //     {
    //         Debug.Log("右手把的 A 按鈕被按下了！");

    //         InteractMode.instance.SetGameMode(InteractMode.Mode.Artist);
    //     }

    //     if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
    //     {
    //         Debug.Log("左手把的板機按鈕被按下了！");
    //         InteractMode.instance.vfxSwipe.BurstActionSwipe();
    //     }

    //     // 檢測右手把的 A 按鈕
    //     if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
    //     {
    //         Debug.Log("右手把的板機按鈕被按下了！");
    //         InteractMode.instance.vfxSwipe.BurstActionSwipe();
    //     }

    //     // 獲取目前手把位置
    //     // Vector3 currentControllerPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);

    //     // // 計算手把位置的變化
    //     // Vector3 controllerPositionDelta = currentControllerPosition - initialControllerPosition;

    //     // // 將手把位置變化應用到蛇形物體的移動
    //     // //TargetOBJ.transform.Translate(controllerPositionDelta * moveSpeed * Time.deltaTime);
    //     // SnakeMove.instance.DragonBallTranslate(controllerPositionDelta);

    //     // // 更新初始手把位置
    //     // initialControllerPosition = currentControllerPosition;

    //     // 獲取目前手把位置
    //     //SnakeMove.instance.DragonBallSetPos(new Vector3(RightHand.position.x, RightHand.position.y - Head.position.y, RightHand.position.z) * RightHandPosAmp);
    //     return;
    //     SnakeMove.instance.DragonBallSetPos((RightHand.position - Head.position) * RightHandPosAmp);


    //     if (RightHand.position.y > Head.position.y)
    //     {
    //         //Debug.Log("RightHand");
    //         timeToControl += Time.deltaTime;

    //         if (timeToControl > waitToPlayGame)
    //         {
    //             InteractMode.instance.SetGameMode(InteractMode.Mode.Dance);
    //             timeToControl = 0;
    //         }
    //     }

    //     // if (RightHand.position.y < Head.position.y + 1)
    //     // {
    //     //     //Debug.Log("RightHand");
    //     //     timeToStop += Time.deltaTime;

    //     //     if(timeToStop > waitToStopGame){
    //     //         InteractMode.instance.SetGameMode(InteractMode.Mode.Artist);
    //     //         timeToStop = 0;
    //     //     }
    //     // }
    // }

}
