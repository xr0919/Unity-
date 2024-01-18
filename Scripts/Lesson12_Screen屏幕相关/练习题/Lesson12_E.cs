using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson12_E : MonoBehaviour
{
    public GameObject head;
    public GameObject PK;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ///1.WASD����̹��ǰ������ ����ת��
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 pos = new Vector3(0, 0, vertical);
        //ǰ��
        this.transform.Translate(pos * Time.deltaTime * 3);
        //Ҳ��������д
        //this.transform.Translate(Vector3.forward * vertical * Time.deltaTime);
        //ת��
        this.transform.Rotate(new Vector3(0, horizontal, 0) * Time.deltaTime * 20);
        //this.transform.Rotate(Vector3.up * horizontal * Time.deltaTime);



        ///2.��������ƶ�������̨ת��
        //float mouseX = Input.GetAxis("Mouse X");
        //Vector3 mPos = new Vector3(0,mouseX,0);
        head.transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime * 200);


        ///3.�����ֿ����ڹ�̧�����
        PK.transform.Rotate(Vector3.right * Time.deltaTime * Input.mouseScrollDelta.y * 50);

        ///���볤������Ҽ��ƶ����
        ///�����������Χ��̹����ת���ı�۲�̹�˵��ӽ�
        camera.transform.LookAt(this.transform.position);
        if (Input.GetMouseButton(1))
        {
            camera.transform.RotateAround(this.transform.position, Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * 200);

        }

    }
}
