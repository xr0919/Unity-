using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //��ȡ�����
        //���������ȡ
        //��Ҫͨ�����ַ�����ȡ �����ϱ�����һ��tagΪMainCamera������������ã�
        print(Camera.main.name);
        //��ȡ���������
        print(Camera.allCamerasCount);
        //�õ�����shexiangji
        Camera[] allCamera = Camera.allCameras;

        //2.��Ⱦ���ί��
        //������޳�ǰ�����ί�к���
        /*Camera.onPreCull += (c) +> {

        }*/


        ///��Ҫ��Ա
        //1.����ϵĲ��� ��������Camera�л�ȡ
        Camera.main.depth = -1; //�õ���������ϵ����
        //2.�����ã�����������������1����������ת��Ļ����
        //��������ͷ��Ѫ�� ����ԶС �ǳ�����
        //ת�������xy�����ʾ��Ļ���� ���½�ΪԲ�� z��Ӧ3d�������������ж�Զ
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position);
        print(v);
        

    }

    // Update is called once per frame
    void Update()
    {
        //3.��Ļ����ת��������
        //������Ʒ��������ƶ�
        //֮���Ըı�z��ʱ��Ϊ������� Ĭ��Ϊ0
        //ת������������ϵ�� ��Զ��һ���� �������Ϊ�ӿ� �ཻ�Ľ���
        //����ı���z�� ��ôת����ȥ����������ĵ� ���൱�� �����ǰ�����ٵ�λ�ĺ�����ϵ����������
        Vector3 v = Input.mousePosition;
        v.z = 5;
        print(Camera.main.ScreenToWorldPoint(v));
    }
}
