using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///世界坐标转本地坐标  /
        ///可以帮助我们判断一个相对位置
        print(Vector3.forward);
        //世界坐标系的点 转换 为相对本地坐标系的点
        //受缩放影响
        print(this.transform.InverseTransformPoint(transform.position));

        //世界坐标系的方向 转换 为相对本地坐标系的方向
        //不受缩放影响
        print(this.transform.InverseTransformDirection(transform.forward));
        //受缩放影响
        print(this.transform.InverseTransformVector(transform.forward));


        ///本地坐标转世界坐标  （可用于人物朝他的前方n个单位放技能，这时我不用关心世界坐标系哦
        ///然后通过 相对于本地坐标系的位置 转换成 世界坐标系的点 进行特效创建或者攻击范围判断）
        /////本地坐标系的点 转换 为相对世界坐标系的点（非常重要！！！！！！！！！！！）
        //受缩放影响
        print(this.transform.TransformPoint(Vector3.forward));
        
        /////本地坐标系的方向 转换 为相对世界坐标系的方向
        //不受缩放影响
        print(this.transform.TransformDirection(Vector3.forward));
        //受缩放影响
        print(this.transform.TransformVector(Vector3.forward));



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
