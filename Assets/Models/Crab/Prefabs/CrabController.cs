using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabController : MonoBehaviour
{
    Animator CrabAnimator;
    public float crossTime = 0.2f;
    public float movespeed = 1;

    float ConstRotationY() { return Random.Range(-75, 75); }
    public float RotationY;

    public bool WalltouchTrigger;
    float ConstFrequenceTime() { return Random.Range(5, 8); }
    public float Frequency;

    public enum CrabState
    {
        Eat,
        LeftRun,
        RightRun,
        LeftMove,
        RigtMove,
        ING
    }
    public CrabState CurrentState;
    public CrabState PreviousState;

    // Start is called before the first frame update
    private void Awake()
    {
        CrabAnimator = GetComponent<Animator>();
    }
    void Start()
    {
        CurrentState = CrabState.Eat;
        RotationY = ConstRotationY();
    }

    // Update is called once per frame
    void Update()
    {
        MoveAreaDetect();
        CrabAction();
        CrabStateSwitch();
        RaycastHit hit;
        Ray ray = new Ray(transform.position + Vector3.up * 2, Vector3.down);
        if (Physics.Raycast(ray, out hit, 10, 1 << 7)) 
        {
            // 將物件的位置調整到地形高度
            Vector3 newPosition = hit.point;
            transform.position = newPosition + Vector3.up * 0.01f;

            // 獲取碰撞物體的法向量
            Vector3 normal = hit.normal;

            // 計算射線方向
            Vector3 rayDirection = ray.direction;

            // 計算入射角度（兩向量的夾角）
            float incidentAngle = Vector3.Angle(rayDirection, -normal);
            transform.localRotation = Quaternion.Euler(incidentAngle, RotationY, 0);
            //Debug.Log(incidentAngle);
            
        }
    }
    public void CrabAction()
    {
        switch(PreviousState)
        {
            case CrabState.Eat:
                CrabAnimator.CrossFadeInFixedTime("Eat", crossTime);
                CurrentState = CrabState.Eat;
                PreviousState = CrabState.ING;
                break;
            case CrabState.LeftMove:
                CrabAnimator.CrossFadeInFixedTime("LookL", crossTime);
                PreviousState = CrabState.ING;
                CurrentState = CrabState.LeftMove;

                break;
            case CrabState.RigtMove:
                CrabAnimator.CrossFadeInFixedTime("LookR", crossTime);
                PreviousState = CrabState.ING;
                CurrentState = CrabState.RigtMove;
 
                break;
            case CrabState.LeftRun:
                CrabAnimator.CrossFadeInFixedTime("LookLB", crossTime);
                PreviousState = CrabState.ING;
                CurrentState = CrabState.LeftRun;

                break;
            case CrabState.RightRun:
                CrabAnimator.CrossFadeInFixedTime("LookRB", crossTime);
                PreviousState = CrabState.ING;
                CurrentState = CrabState.RightRun;

                break;
        }
        switch (CurrentState)
        {
            case CrabState.Eat:
                CurrentState = CrabState.Eat;
                break;
            case CrabState.LeftMove:
                CrabMove(.5f, Vector3.left);
                break;
            case CrabState.RigtMove:
                CrabMove(.5f, Vector3.right);
                break;
            case CrabState.LeftRun:
                CrabMove(1, Vector3.left);
                break;
            case CrabState.RightRun:
                CrabMove(1, Vector3.right);
                break;
        }
    }
    public void CrabStateSwitch()
    {
        if(WalltouchTrigger)
        {
            if (transform.position.x <= -4f)
            {
                RotationY = 0;
                CurrentState = CrabState.RightRun;
            }
            else if (transform.position.x >= 4f)
            {
                RotationY = 0;
                CurrentState = CrabState.LeftRun;
            }
            else if (transform.position.z >= 4f)
            {
                RotationY = 90;
                CurrentState = CrabState.RightRun;
            }
            else if (transform.position.z <= -4f)
            {
                RotationY = -90;
                CurrentState = CrabState.RightRun;
            }
            else
            {
                WalltouchTrigger = false;
                PreviousState = (CrabState)Random.Range(0, 4);
                RotationY = ConstRotationY();
                Frequency = ConstFrequenceTime();
            }
        }
        else 
        {
            Frequency -= Time.deltaTime;
            if (Frequency <= 0)
            {
                AutoSwitch();
            }
        }
    }

    public void CrabMove(float Speed,Vector3 Direction)
    {
        Vector3 moveDirection = transform.TransformDirection(Direction);

        // 透過Transform.Translate方法移動物件
        transform.Translate(moveDirection* movespeed* Speed * Time.deltaTime, Space.World);
    }


    void MoveAreaDetect()
    {
        if(transform.position.x <= -4f || transform.position.x >= 4f ||
           transform.position.z <= -4f || transform.position.z >= 4f)
        {
            WalltouchTrigger = true;
        }
            
    }
    void AutoSwitch()
    {
        WalltouchTrigger = false;
        PreviousState = (CrabState)Random.Range(0, 4);
        RotationY = ConstRotationY();
        Frequency = ConstFrequenceTime();
    }
    void TouchCrabs()
    {
        WalltouchTrigger = false;
        PreviousState = (CrabState)Random.Range(1, 4);
        RotationY = ConstRotationY();
        Frequency = ConstFrequenceTime();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Crab")
        {
            TouchCrabs();
        }
    }

}
