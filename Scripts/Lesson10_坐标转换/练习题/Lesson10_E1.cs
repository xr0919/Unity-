using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10_E1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Create();
    }

    /// <summary>
    /// һ������A ��������ʲôλ�� дһ������ 
    /// ֻҪִ����������Ϳ�����������ǰ����-1��0��1��������һ��������
    /// </summary>
    /// 
    [ContextMenu("��ǰ������������")]
    void Create()
    {
        Vector3 pos = this.transform.TransformPoint(new Vector3(-1, 0, 1));
        print(pos);
        GameObject gObj = new GameObject("��ǰ������");
        gObj.transform.position = pos;

    }
    [ContextMenu("ǰ������3������")]
    void CreateThreeBall()
    {
        Vector3 pos1 = this.transform.TransformPoint(new Vector3(0,0,1));
        Vector3 pos2 = this.transform.TransformPoint(new Vector3(0,0,2));
        Vector3 pos3 = this.transform.TransformPoint(new Vector3(0,0,3));

        GameObject obj1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject obj2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject obj3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        obj1.transform.position = pos1;
        obj2.transform.position = pos2;
        obj3.transform.position = pos3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
