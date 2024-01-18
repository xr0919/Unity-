using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //获取摄像机
        //主摄像机获取
        //若要通过这种方法获取 场景上必须有一个tag为MainCamera的摄像机（常用）
        print(Camera.main.name);
        //获取摄像机数量
        print(Camera.allCamerasCount);
        //得到所有shexiangji
        Camera[] allCamera = Camera.allCameras;

        //2.渲染相关委托
        //摄像机剔除前处理的委托函数
        /*Camera.onPreCull += (c) +> {

        }*/


        ///重要成员
        //1.面板上的参数 都可以在Camera中获取
        Camera.main.depth = -1; //得到主摄像机上的深度
        //2.（常用！！！！！！！！！1）世界坐标转屏幕坐标
        //可以用作头顶血条 近大远小 非常常用
        //转换过后的xy坐标表示屏幕坐标 左下角为圆点 z对应3d物体距离摄像机有多远
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position);
        print(v);
        

    }

    // Update is called once per frame
    void Update()
    {
        //3.屏幕坐标转世界坐标
        //用于物品跟随鼠标移动
        //之所以改变z轴时因为如果不改 默认为0
        //转换到世界坐标系中 永远是一个点 可以理解为视口 相交的焦点
        //如果改变了z轴 那么转换过去的世界坐标的点 就相当于 摄像机前方多少单位的横截面上的世界坐标点
        Vector3 v = Input.mousePosition;
        v.z = 5;
        print(Camera.main.ScreenToWorldPoint(v));
    }
}
