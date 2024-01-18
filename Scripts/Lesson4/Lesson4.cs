using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    public GameObject cloneObj;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject中的
        //成员变量
        //名字
        print(this.gameObject.name);
        //是否激活
        print(gameObject.activeSelf);
        //是否静态
        print(gameObject.isStatic);
        //层级 标签
        print(this.gameObject.layer);
        print(this.gameObject.tag);
        //transform
        //this.gameObject.transform;//等于this.transform


        //静态方法
        //查找单个对象
        //查不到失活对象
        //如果场景中存在多个满足条件的对象 无法确定找到的是谁，只能查唯一名字的
        //通过API去找
        //1.通过对象名查找 
        //这个查找效率比较低，因为会在场景所有对象中找
        //没找到返回null
        GameObject gobj = GameObject.Find("cube");
        //2.通过tag查找
        gobj = GameObject.FindWithTag("Player");
        //通过public从外部面板拖 进行关联

        //2.查找多个对象
        //只能通过API去找
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print(objs.Length);
        
        //找到场景中挂载的某一个脚本对象(少用)
        //这个效率更低 不仅要遍历对象 还有遍历对象上挂载的脚本
        Lesson4 o = GameObject.FindObjectOfType<Lesson4>();

        //开发中使用public从面板中拖比较常见



        //（重点！！！！！！）实例化（克隆）对象
        //根据一个GameObject对象 创造出一个和他一模一样的对象 包括身上的脚本
        //1.直接克隆场景上的某个对象
        //2.实例化一个预设体对象
        GameObject clobj = GameObject.Instantiate(cloneObj);
        Instantiate(cloneObj);//还可以这样写
        //删除对象的方法
        GameObject.Destroy(clobj);
        GameObject.Destroy(clobj,5);//延迟5s 单位秒
        //不仅可以删除对象也可以删脚本
        GameObject.Destroy(this);
        Destroy(cloneObj);//还可以这样写 如果继承Mono类

        //过场景不移除
        //默认情况在切换场景时 场景中对象都会被自动删除掉
        //不想谁过场景就被移除就传谁 一般传依附的GameObject对象
        GameObject.DontDestroyOnLoad(this.gameObject);



        //GameObject成员方法
        //创建空物体
        GameObject obj00 = new GameObject();
        GameObject obj01 = new GameObject("改名",typeof(Lesson4));
        //@！！！！重要！！！！！！！！！
         Lesson4 l4 =  obj00.AddComponent(typeof(Lesson4)) as Lesson4;//少用要转换类型
         Lesson4 le4 = obj00.AddComponent<Lesson4>();//一般用这个
        //通过返回值可以得到加入的脚本信息，来进行处理

        //得到脚本 和继承Mono类得到脚本的方法一模一样
        this.GetComponent<Lesson4>();

        //标签比较
        //两者一样
        if (this.gameObject.CompareTag("Player"))
        {

        }
        if(this.gameObject.tag == "tag")
        {

        }
        //
        //设置失活激活
        obj01.SetActive(false);

        //次要方法 不建议使用 效率较低
        //通过广播或者消息的形式 让自己或者别人 执行某些行为方法
        //通知自己 执行什么行为 找到自己身上所有脚本去找有这个名字的函数去执行
        this.gameObject.SendMessage("TestRun");


    }


}
