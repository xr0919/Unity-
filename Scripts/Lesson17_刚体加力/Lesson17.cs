using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //1.获取刚体组件
        rb = this.GetComponent<Rigidbody>();

        //2.添加力
        //相对世界坐标
        //是否停止取决于阻力
        //rb.AddForce(Vector3.forward * 20);
        //rb.AddForce(this.transform.forward * 20);

        //相对本地坐标
        rb.AddRelativeForce(Vector3.forward * 20);


        //3.添加扭矩力让其旋转
        //相对世界坐标
        //rb.AddTorque(Vector3.up * 10);
        //相对本地坐标
        rb.AddRelativeTorque(Vector3.up * 20);


        //4.直接改变速度
        //rb.velocity = Vector3.forward * 5;//直接利用速度往前进，实际很少这样应用

        //5.模拟爆炸效果
        rb.AddExplosionForce(10, Vector3.zero, 10);//只影响自己
        //若要模拟爆炸多个物体 都需要得到他们的刚体执行这个方法


        ///力的模式
        rb.AddForce(Vector3.forward * 20,ForceMode.Acceleration);
        //4中计算方式不同 最终的移动速度就会不同


        ///力场脚本Constant Force
        //场景中一些收持续力影响的物体就不用写代码控制了


        ///刚体休眠
        //Unity为节约性能会给刚体休眠
        if (rb.IsSleeping())
        {
            //若休眠就唤醒它
            rb.WakeUp();
        }

    }

    // Update is called once per frame
    void Update()
    {
        //如果希望有助力但是也一直动 就在这里推
    }
}
