using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObj : MonoBehaviour
{
    private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            this.transform.Translate(Vector3.forward * 10 * Time.deltaTime);
            //GameObject.Destroy(this, 5);
        
    }
    protected void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            GameObject.Destroy(this.gameObject);//一定是移除自己依附的gameObject而不是this，this指的是脚本
        }
    }
}
