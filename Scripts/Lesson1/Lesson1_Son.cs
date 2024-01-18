using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1_Son : Lesson1
{
    [SerializeField]
    [Range(0,100 )]
    private int a = 0;

    private void Awake()
    {
        base.Awake();
        print("son awake");
        print(this.gameObject.transform.position);

    }

}
