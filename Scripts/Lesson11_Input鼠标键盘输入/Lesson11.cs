using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        ///�������Ļλ��
        //��Ļ�����ԭ�� ������Ļ�����½�  ������X�������� ������Y��������
        //����ֵʱVector3 ����ֻ�� x��y��ֵ zΪ0
        //print(Input.mousePosition);

        ///����������  ����ֵ���ǲ���ֵ
        //Ӧ�ã�1.�����ӵ� ���������ת��
        //��갴��һ˲�� ����
        //0��� 1�Ҽ� 2�н�
        if (Input.GetMouseButtonDown(0))
        {

        }
        //���̧��һ˲��
        if (Input.GetMouseButtonUp(1))
        {

        }
        //��곤������̧�𶼻����
        if (Input.GetMouseButton(1))
        {

        }

        //�н�����
        //����ֵ��y -1�¹� 0û�й� 1�Ϲ�
        //����ֵ��Vector��ֵ 
        print(Input.mouseScrollDelta);


        ///����������
        /////���̰���
        //ö����
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("W������");
        }
        //�����ַ��������� //����������KeyCode
        //ֻ�ܴ���Сд �����Ǵ�д��Ȼ����
        if (Input.GetKeyDown("q"))
        {
            print("Q������");
        }
        //����̧��
        if (Input.GetKeyUp(KeyCode.U))
        {

        }
        //���̳���
        if (Input.GetKey(KeyCode.V))
        {

        }


        ///���Ĭ��������  //����floatֵ
        ///Unity�ṩ�˸����㷽���������ǿ���֮�����λ�ƺ���ת
        //����AD����ʱ ���� -1��1֮��ı任 
        print(Input.GetAxis("Horizontal"));
        //����SW����ʱ ���� -1��1֮��ı任
        print(Input.GetAxis("Vertical"));
        //�������ƶ�ʱ -1��1����
        print(Input.GetAxis("Mouse X"));
        //��������ƶ�ʱ -1��1����
        print(Input.GetAxis("Mouse Y"));


        ///����
        //�Ƿ������������곤��
        //�������������Ϸ
        if (Input.anyKey)
        {
            print(Input.inputString);

        }
        //�Ƿ������������갴��
        if (Input.anyKeyDown)
        {
            print(Input.inputString);

        }
        //��һ֡�ļ�������
        print(Input.inputString);
        //�ֱ��������
        //�õ����ӵ��ֱ������а�ť����
        string[] strs = Input.GetJoystickNames();

        //�ƶ��豸��Ʒ��أ������� ���ڶ���UI�ٿأ�
        if(Input.touchCount > 0)
        {
            Touch t1 = Input.touches[0];
            //λ��
            print(t1.position);
            //����ϴ�λ�ñ仯
            print(t1.deltaPosition);

        }
        //�Ƿ����ö�㴥��
        Input.multiTouchEnabled = false;
        //
        //������
    }
}
