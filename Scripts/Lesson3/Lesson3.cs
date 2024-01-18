using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //得到依附对象是上挂载的其他脚本
        //1.根据脚本名获取（少用）
        Lesson3_Test t = this.GetComponent("Lesson3_Test") as Lesson3_Test; //返回值是Component类型 要用里氏替换原则转换类型
        print(t);
        //2.根据type获得
        t=this.GetComponent(typeof(Lesson3_Test)) as Lesson3_Test;
        //3.根据泛型获取 （最常用）因为不用二次转换
        t = this.GetComponent<Lesson3_Test>();
        //只要你可以获得场景中别的对象或对象依附的脚本，你就可以获取他的所有信息

        //得到自己挂载的多个脚本 很少挂两个同类型脚本
        this.GetComponents<Lesson3_Test>();

        //得到子对象挂载的脚本(它默认也会找自己身上是否挂载该脚本)
        this.GetComponentInChildren<Lesson3_Test>();

        //得到父对象挂载的脚本
        this.GetComponentInParent<Lesson3_Test>();
        this.GetComponentsInParent<Lesson3_Test>();

        //尝试获取脚本//更安全 相当于if判断是为为null
        if(this.TryGetComponent<Lesson3_Test>(out t)){

        }
        if(t != null)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
