using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //1.��ȡ�������
        rb = this.GetComponent<Rigidbody>();

        //2.�����
        //�����������
        //�Ƿ�ֹͣȡ��������
        //rb.AddForce(Vector3.forward * 20);
        //rb.AddForce(this.transform.forward * 20);

        //��Ա�������
        rb.AddRelativeForce(Vector3.forward * 20);


        //3.���Ť����������ת
        //�����������
        //rb.AddTorque(Vector3.up * 10);
        //��Ա�������
        rb.AddRelativeTorque(Vector3.up * 20);


        //4.ֱ�Ӹı��ٶ�
        //rb.velocity = Vector3.forward * 5;//ֱ�������ٶ���ǰ����ʵ�ʺ�������Ӧ��

        //5.ģ�ⱬըЧ��
        rb.AddExplosionForce(10, Vector3.zero, 10);//ֻӰ���Լ�
        //��Ҫģ�ⱬը������� ����Ҫ�õ����ǵĸ���ִ���������


        ///����ģʽ
        rb.AddForce(Vector3.forward * 20,ForceMode.Acceleration);
        //4�м��㷽ʽ��ͬ ���յ��ƶ��ٶȾͻ᲻ͬ


        ///�����ű�Constant Force
        //������һЩ�ճ�����Ӱ�������Ͳ���д���������


        ///��������
        //UnityΪ��Լ���ܻ����������
        if (rb.IsSleeping())
        {
            //�����߾ͻ�����
            rb.WakeUp();
        }

    }

    // Update is called once per frame
    void Update()
    {
        //���ϣ������������Ҳһֱ�� ����������
    }
}
