using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_E : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///1.������������ת��Ļ����
        print(Camera.main.WorldToScreenPoint(this.transform.position));

    }

    // Update is called once per frame
    void Update()
    {
        ///����Ļ�ϵ��һ����꣬���ڶ�Ӧ����������ϵ����һ��cube
        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 vpos = Input.mousePosition;
            vpos.z = 20;
            obj.transform.position = Camera.main.ScreenToWorldPoint(vpos);
        }
    }
}
