using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObj : MonoBehaviour
{
    public int hp = 3;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))//可以不写这一句 场景只有子弹一个触发器
        {
            hp-=1;
            if (hp <= 0)
            {
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
