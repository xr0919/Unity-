using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson20 : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //代码控制播放停止
        if (Input.GetKeyDown(KeyCode.P))
        {
            audiosource.Play();
            //延迟播放
            //audiosource.PlayDelayed(5);

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //停止播放
            audiosource.Stop();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            //暂停播放
            audiosource.Pause();
        }

        ///如何检测音效播放完毕
        //不停检测一个音效是否播放完
        if (audiosource.isPlaying)
        {
            print("playing");

        }
        else
        {
            print("end");

        }

        ///动态控制音效播放
        //1.直接在要播放音效的对象上挂载脚本 控制播放 如上文
        //2.实例化挂载了音效源脚本的对象
        //  做成一个预设体，需要播放时 实例化（少用）
        //3.用一个audiosource来控制播放不同音效
        AudioSource aus = this.gameObject.AddComponent<AudioSource>();  
        aus.clip = clip;
        aus.Play();
    }
}
