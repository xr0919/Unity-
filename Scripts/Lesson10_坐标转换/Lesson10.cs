using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///��������ת��������  /
        ///���԰��������ж�һ�����λ��
        print(Vector3.forward);
        //��������ϵ�ĵ� ת�� Ϊ��Ա�������ϵ�ĵ�
        //������Ӱ��
        print(this.transform.InverseTransformPoint(transform.position));

        //��������ϵ�ķ��� ת�� Ϊ��Ա�������ϵ�ķ���
        //��������Ӱ��
        print(this.transform.InverseTransformDirection(transform.forward));
        //������Ӱ��
        print(this.transform.InverseTransformVector(transform.forward));


        ///��������ת��������  �����������ﳯ����ǰ��n����λ�ż��ܣ���ʱ�Ҳ��ù�����������ϵŶ
        ///Ȼ��ͨ�� ����ڱ�������ϵ��λ�� ת���� ��������ϵ�ĵ� ������Ч�������߹�����Χ�жϣ�
        /////��������ϵ�ĵ� ת�� Ϊ�����������ϵ�ĵ㣨�ǳ���Ҫ������������������������
        //������Ӱ��
        print(this.transform.TransformPoint(Vector3.forward));
        
        /////��������ϵ�ķ��� ת�� Ϊ�����������ϵ�ķ���
        //��������Ӱ��
        print(this.transform.TransformDirection(Vector3.forward));
        //������Ӱ��
        print(this.transform.TransformVector(Vector3.forward));



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
