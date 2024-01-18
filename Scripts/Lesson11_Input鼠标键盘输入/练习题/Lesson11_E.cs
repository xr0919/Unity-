using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11_E : MonoBehaviour
{
    public GameObject head;
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
        Vector3 pos = new Vector3(0,0, vertical);
        //前进
        this.transform.Translate(pos*Time.deltaTime*3);
        //也可以这样写
        //this.transform.Translate(Vector3.forward * vertical * Time.deltaTime);
        //转向
        this.transform.Rotate(new Vector3(0, horizontal, 0) * Time.deltaTime * 20);
        //this.transform.Rotate(Vector3.up * horizontal * Time.deltaTime);



        ///2.鼠标左右移动控制炮台转向
        //float mouseX = Input.GetAxis("Mouse X");
        //Vector3 mPos = new Vector3(0,mouseX,0);
        head.transform.Rotate(Vector3.up* Input.GetAxis("Mouse X") * Time.deltaTime*200);


    }
}
