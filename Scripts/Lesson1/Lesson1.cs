using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    protected virtual void Awake()
    {
        //出生时调用 类似构造函数，一个对象只会调用一次
    }

    // Start is called before the first frame update
    void Start()//生命周期函数
    {
        Debug.Log("123");//没有继承Mono类时可以用整个
        //Debug.LogError("error");

        print("print");//继承了Mono类
    }

    // Update is called once per frame
    void Update()
    {
        //不用的声明函数别写 有点性能开销
    }
}
