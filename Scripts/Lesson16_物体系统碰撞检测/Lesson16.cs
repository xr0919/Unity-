using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    /// <summary>
    /// 1.������ײ�����Ӧ����
    /// </summary>
    private void OnCollisionEnter(Collision collision)
    {
        //Collion���͵Ĳ��� �����������Լ��Ķ���������Ϣ

        //ֻҪ�õ�����ײ�������������Ϣ �Ϳ��Եõ�����������Ϣ

        //�ؼ�����
        //1.��ײ���Ķ�����ײ������Ϣ
        //collision.collider
        //2.��ײ�������������GameObject
        //collision.gameObject
        /////3.��ײ��������������λ����Ϣ
        //collision.transform
        //4.��ײ�������
        //collision.contactCount

        print("�� "+ collision.gameObject.name +" ��ײ��");
    }
    private void OnCollisionExit(Collision collision)
    {
        print("�� " + collision.gameObject.name + " ������ײ��");

    }
    private void OnCollisionStay(Collision collision)
    {
        //���������໥�Ӵ�Ħ��ʱ �᲻ͣ���øú���
        print("�� " + collision.gameObject.name + " �Ӵ�");

    }

    ///�����������Ӧ����
    protected virtual void OnTriggerEnter(Collider other)
    {
        //ע�������Collider�ű�
        print("�� "+ other.gameObject.name +" ������");

    }

    ///3.�����һ���������� �����ڸ������� ����ͨ���Ӷ����Ϲҽű������ײ�ǲ��е� ������ص�������常�����ϲ���
    ///4.��ײ�ʹ���������������д���麯�� �������� ����������д�߼�
}
