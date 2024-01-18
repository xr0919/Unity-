using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        ///鼠标在屏幕位置
        //屏幕坐标的原点 是在屏幕的左下角  往右是X轴正方向 往上是Y轴正方向
        //返回值时Vector3 但是只有 x和y有值 z为0
        //print(Input.mousePosition);

        ///检测鼠标输入  返回值都是布尔值
        //应用：1.发射子弹 控制摄像机转动
        //鼠标按下一瞬间 进入
        //0左键 1右键 2中建
        if (Input.GetMouseButtonDown(0))
        {

        }
        //鼠标抬起一瞬间
        if (Input.GetMouseButtonUp(1))
        {

        }
        //鼠标长按按下抬起都会进入
        if (Input.GetMouseButton(1))
        {

        }

        //中建滚动
        //返回值的y -1下滚 0没有滚 1上滚
        //返回值是Vector的值 
        print(Input.mouseScrollDelta);


        ///检测键盘输入
        /////键盘按下
        //枚举形
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("W键按下");
        }
        //传入字符串的重载 //建议用上面KeyCode
        //只能传入小写 不能是大写不然报错
        if (Input.GetKeyDown("q"))
        {
            print("Q键按下");
        }
        //键盘抬起
        if (Input.GetKeyUp(KeyCode.U))
        {

        }
        //键盘长按
        if (Input.GetKey(KeyCode.V))
        {

        }


        ///检测默认轴输入  //返回float值
        ///Unity提供了更方便方法帮助我们恐吓之对象的位移和旋转
        //键盘AD按下时 返回 -1到1之间的变换 
        print(Input.GetAxis("Horizontal"));
        //键盘SW按下时 返回 -1到1之间的变换
        print(Input.GetAxis("Vertical"));
        //鼠标横向移动时 -1到1左右
        print(Input.GetAxis("Mouse X"));
        //鼠标竖向移动时 -1到1上下
        print(Input.GetAxis("Mouse Y"));


        ///其他
        //是否有任意键或鼠标长按
        //按任意键进入游戏
        if (Input.anyKey)
        {
            print(Input.inputString);

        }
        //是否有任意键或鼠标按下
        if (Input.anyKeyDown)
        {
            print(Input.inputString);

        }
        //这一帧的键盘输入
        print(Input.inputString);
        //手柄输入相关
        //得到链接的手柄的所有按钮名字
        string[] strs = Input.GetJoystickNames();

        //移动设备出品相关（较少用 现在都用UI操控）
        if(Input.touchCount > 0)
        {
            Touch t1 = Input.touches[0];
            //位置
            print(t1.position);
            //相对上次位置变化
            print(t1.deltaPosition);

        }
        //是否启用多点触控
        Input.multiTouchEnabled = false;
        //
        //陀螺仪
    }
}
