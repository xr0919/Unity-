using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16_E : MonoBehaviour
{
    public GameObject head;
    public GameObject PK;
    public Camera camera;
    public GameObject bullet;
    private GameObject objB;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ///1.WASD控制坦克前进后退 左右转向
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 pos = new Vector3(0, 0, vertical);
        //前进
        this.transform.Translate(pos * Time.deltaTime * 3);
        //也可以这样写
        //this.transform.Translate(Vector3.forward * vertical * Time.deltaTime);
        //转向
        this.transform.Rotate(new Vector3(0, horizontal, 0) * Time.deltaTime * 20);
        //this.transform.Rotate(Vector3.up * horizontal * Time.deltaTime);



        ///2.鼠标左右移动控制炮台转向
        //float mouseX = Input.GetAxis("Mouse X");
        //Vector3 mPos = new Vector3(0,mouseX,0);
        head.transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime * 200);


        ///3.鼠标滚轮控制炮管抬起放下
        PK.transform.Rotate(Vector3.right * Time.deltaTime * Input.mouseScrollDelta.y * 50);

        ///加入长按鼠标右键移动鼠标
        ///可以让摄像机围着坦克旋转，改变观察坦克的视角
        camera.transform.LookAt(this.transform.position);
        if (Input.GetMouseButton(1))
        {
            camera.transform.RotateAround(this.transform.position, Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * 200);

        }


        ///1.左键射子弹
        if (Input.GetMouseButtonDown(0))
        {
            objB = GameObject.Instantiate(bullet);
            objB.transform.position = PK.transform.position;
            objB.transform.eulerAngles = PK.transform.eulerAngles;
        }
        //用面向对象思想写 在子弹行为的脚本
        /*if (objB != null)
        {
            objB.transform.Translate(Vector3.forward * 10 * Time.deltaTime);
            GameObject.Destroy(objB, 5);
        }*/
    }
}
