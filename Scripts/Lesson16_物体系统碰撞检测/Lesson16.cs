using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    /// <summary>
    /// 1.物理碰撞检测响应函数
    /// </summary>
    private void OnCollisionEnter(Collision collision)
    {
        //Collion类型的参数 包含了碰到自己的对象的相关信息

        //只要得到了碰撞到对象的任意信息 就可以得到他的所有信息

        //关键参数
        //1.碰撞到的对象碰撞器的信息
        //collision.collider
        //2.碰撞对象的依附对象GameObject
        //collision.gameObject
        /////3.碰撞对象的依附对象的位置信息
        //collision.transform
        //4.碰撞点数相关
        //collision.contactCount

        print("与 "+ collision.gameObject.name +" 碰撞了");
    }
    private void OnCollisionExit(Collision collision)
    {
        print("与 " + collision.gameObject.name + " 结束碰撞了");

    }
    private void OnCollisionStay(Collision collision)
    {
        //两个物体相互接触摩擦时 会不停调用该函数
        print("与 " + collision.gameObject.name + " 接触");

    }

    ///触发器检测响应函数
    protected virtual void OnTriggerEnter(Collider other)
    {
        //注意参数是Collider脚本
        print("与 "+ other.gameObject.name +" 触发了");

    }

    ///3.如果是一个异型物体 刚体在父对象上 若想通过子对象上挂脚本检测碰撞是不行的 必须挂载岛这个刚体父对象上才行
    ///4.碰撞和触发器函数都可以写成虚函数 保护类型 在子类中重写逻辑
}
