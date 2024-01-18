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
        //������Ʋ���ֹͣ
        if (Input.GetKeyDown(KeyCode.P))
        {
            audiosource.Play();
            //�ӳٲ���
            //audiosource.PlayDelayed(5);

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //ֹͣ����
            audiosource.Stop();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            //��ͣ����
            audiosource.Pause();
        }

        ///��μ����Ч�������
        //��ͣ���һ����Ч�Ƿ񲥷���
        if (audiosource.isPlaying)
        {
            print("playing");

        }
        else
        {
            print("end");

        }

        ///��̬������Ч����
        //1.ֱ����Ҫ������Ч�Ķ����Ϲ��ؽű� ���Ʋ��� ������
        //2.ʵ������������ЧԴ�ű��Ķ���
        //  ����һ��Ԥ���壬��Ҫ����ʱ ʵ���������ã�
        //3.��һ��audiosource�����Ʋ��Ų�ͬ��Ч
        AudioSource aus = this.gameObject.AddComponent<AudioSource>();  
        aus.clip = clip;
        aus.Play();
    }
}
