using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//传送物体
public class CarrierObj : MonoBehaviour
{
    //物体移动速度
    public float speed = 1.2f;

    //只要产生碰撞执行（每帧调用一次）
    public void OnCollisionStay(Collision collision)
    {
        //对传送带上的物体移动效果
        if(collision.gameObject!=null)
        {
            MoveObj(collision.gameObject);
        }
    }

    //物体移动
    public void MoveObj(GameObject gameObject)
    {
        gameObject.transform.Translate(Vector3.forward*speed*Time.deltaTime/*Time.fixeddeltaTime*/,Space.World);
        //gameObject.transform.Translate(-1*Vector3.forward * speed * Time.deltaTime, Space.World);【反向移动】
    }
   
}
