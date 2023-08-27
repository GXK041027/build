using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��������
public class CarrierObj : MonoBehaviour
{
    //�����ƶ��ٶ�
    public float speed = 1.2f;

    //ֻҪ������ײִ�У�ÿ֡����һ�Σ�
    public void OnCollisionStay(Collision collision)
    {
        //�Դ��ʹ��ϵ������ƶ�Ч��
        if(collision.gameObject!=null)
        {
            MoveObj(collision.gameObject);
        }
    }

    //�����ƶ�
    public void MoveObj(GameObject gameObject)
    {
        gameObject.transform.Translate(Vector3.forward*speed*Time.deltaTime/*Time.fixeddeltaTime*/,Space.World);
        //gameObject.transform.Translate(-1*Vector3.forward * speed * Time.deltaTime, Space.World);�������ƶ���
    }
   
}
