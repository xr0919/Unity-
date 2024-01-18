using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15_E1 : MonoBehaviour
{
    public Light l;
    public Light Dl;
    public float i = 0.05f;
    public float s = 0.5f;
    public float f = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        ///1.通过代码结合点光源
        ///模拟一个蜡烛的光源效果
        l = this.GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        //来回横跳
        print(this.transform.position);
        this.transform.Translate(Vector3.right * s * Time.deltaTime);
        if (this.transform.position.x >= 0.8)
        {
            s = -s;

        }
        else if (this.transform.position.x <= 0.2)
        {
            s = -s;
        }

        l.intensity += f*Time.deltaTime;
        if (l.intensity >= 1)
        {
            f=-f;
        }
        else if (l.intensity <= 0.5f)
        {
            f=-f;
        }


        ///通过代码结合方向光
        ///模拟白天黑夜的变化
        Dl.transform.Rotate(Vector3.right, 10* Time.deltaTime);

    }
}
