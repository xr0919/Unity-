using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///1.静态属性
        ///常用
        //当前屏幕分辨率
        //得到的不是Game窗口信息 是你设备屏幕分辨率
        Resolution r = Screen.currentResolution;
        print("宽：" + r.width + "高:" + r.height);

        //屏幕窗口当前宽高 Game窗口
        //比上面的更常用
        print(Screen.width);
        print(Screen.height);

        //屏幕休眠模式
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        ///不常用
        //运行时是否全屏模式 一般不用代码设置 在发布时设置
        Screen.fullScreen = true;
        //移动设备屏幕转向相关 发布时有专门设置的地方 不用代码设置
        //允许自动旋转为左横向 Home键在左
        Screen.autorotateToLandscapeLeft = true;


        ///2.静态方法
        //设置分辨率 一般移动设备不使用
        Screen.SetResolution(1920, 1080, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
