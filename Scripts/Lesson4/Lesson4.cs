using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    public GameObject cloneObj;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject�е�
        //��Ա����
        //����
        print(this.gameObject.name);
        //�Ƿ񼤻�
        print(gameObject.activeSelf);
        //�Ƿ�̬
        print(gameObject.isStatic);
        //�㼶 ��ǩ
        print(this.gameObject.layer);
        print(this.gameObject.tag);
        //transform
        //this.gameObject.transform;//����this.transform


        //��̬����
        //���ҵ�������
        //�鲻��ʧ�����
        //��������д��ڶ�����������Ķ��� �޷�ȷ���ҵ�����˭��ֻ�ܲ�Ψһ���ֵ�
        //ͨ��APIȥ��
        //1.ͨ������������ 
        //�������Ч�ʱȽϵͣ���Ϊ���ڳ������ж�������
        //û�ҵ�����null
        GameObject gobj = GameObject.Find("cube");
        //2.ͨ��tag����
        gobj = GameObject.FindWithTag("Player");
        //ͨ��public���ⲿ����� ���й���

        //2.���Ҷ������
        //ֻ��ͨ��APIȥ��
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print(objs.Length);
        
        //�ҵ������й��ص�ĳһ���ű�����(����)
        //���Ч�ʸ��� ����Ҫ�������� ���б��������Ϲ��صĽű�
        Lesson4 o = GameObject.FindObjectOfType<Lesson4>();

        //������ʹ��public��������ϱȽϳ���



        //���ص㣡������������ʵ��������¡������
        //����һ��GameObject���� �����һ������һģһ���Ķ��� �������ϵĽű�
        //1.ֱ�ӿ�¡�����ϵ�ĳ������
        //2.ʵ����һ��Ԥ�������
        GameObject clobj = GameObject.Instantiate(cloneObj);
        Instantiate(cloneObj);//����������д
        //ɾ������ķ���
        GameObject.Destroy(clobj);
        GameObject.Destroy(clobj,5);//�ӳ�5s ��λ��
        //��������ɾ������Ҳ����ɾ�ű�
        GameObject.Destroy(this);
        Destroy(cloneObj);//����������д ����̳�Mono��

        //���������Ƴ�
        //Ĭ��������л�����ʱ �����ж��󶼻ᱻ�Զ�ɾ����
        //����˭�������ͱ��Ƴ��ʹ�˭ һ�㴫������GameObject����
        GameObject.DontDestroyOnLoad(this.gameObject);



        //GameObject��Ա����
        //����������
        GameObject obj00 = new GameObject();
        GameObject obj01 = new GameObject("����",typeof(Lesson4));
        //@����������Ҫ������������������
         Lesson4 l4 =  obj00.AddComponent(typeof(Lesson4)) as Lesson4;//����Ҫת������
         Lesson4 le4 = obj00.AddComponent<Lesson4>();//һ�������
        //ͨ������ֵ���Եõ�����Ľű���Ϣ�������д���

        //�õ��ű� �ͼ̳�Mono��õ��ű��ķ���һģһ��
        this.GetComponent<Lesson4>();

        //��ǩ�Ƚ�
        //����һ��
        if (this.gameObject.CompareTag("Player"))
        {

        }
        if(this.gameObject.tag == "tag")
        {

        }
        //
        //����ʧ���
        obj01.SetActive(false);

        //��Ҫ���� ������ʹ�� Ч�ʽϵ�
        //ͨ���㲥������Ϣ����ʽ ���Լ����߱��� ִ��ĳЩ��Ϊ����
        //֪ͨ�Լ� ִ��ʲô��Ϊ �ҵ��Լ��������нű�ȥ����������ֵĺ���ȥִ��
        this.gameObject.SendMessage("TestRun");


    }


}
