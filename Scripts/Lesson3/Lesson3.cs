using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�õ������������Ϲ��ص������ű�
        //1.���ݽű�����ȡ�����ã�
        Lesson3_Test t = this.GetComponent("Lesson3_Test") as Lesson3_Test; //����ֵ��Component���� Ҫ�������滻ԭ��ת������
        print(t);
        //2.����type���
        t=this.GetComponent(typeof(Lesson3_Test)) as Lesson3_Test;
        //3.���ݷ��ͻ�ȡ ����ã���Ϊ���ö���ת��
        t = this.GetComponent<Lesson3_Test>();
        //ֻҪ����Ի�ó����б�Ķ������������Ľű�����Ϳ��Ի�ȡ����������Ϣ

        //�õ��Լ����صĶ���ű� ���ٹ�����ͬ���ͽű�
        this.GetComponents<Lesson3_Test>();

        //�õ��Ӷ�����صĽű�(��Ĭ��Ҳ�����Լ������Ƿ���ظýű�)
        this.GetComponentInChildren<Lesson3_Test>();

        //�õ���������صĽű�
        this.GetComponentInParent<Lesson3_Test>();
        this.GetComponentsInParent<Lesson3_Test>();

        //���Ի�ȡ�ű�//����ȫ �൱��if�ж���ΪΪnull
        if(this.TryGetComponent<Lesson3_Test>(out t)){

        }
        if(t != null)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
