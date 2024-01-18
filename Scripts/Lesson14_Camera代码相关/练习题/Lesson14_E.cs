using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_E : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///1.物体世界坐标转屏幕坐标
        print(Camera.main.WorldToScreenPoint(this.transform.position));

    }

    // Update is called once per frame
    void Update()
    {
        ///在屏幕上点击一下鼠标，则在对应的世界坐标系创建一个cube
        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 vpos = Input.mousePosition;
            vpos.z = 20;
            obj.transform.position = Camera.main.ScreenToWorldPoint(vpos);
        }
    }
}
