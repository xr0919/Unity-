using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///1.��̬����
        ///����
        //��ǰ��Ļ�ֱ���
        //�õ��Ĳ���Game������Ϣ �����豸��Ļ�ֱ���
        Resolution r = Screen.currentResolution;
        print("��" + r.width + "��:" + r.height);

        //��Ļ���ڵ�ǰ��� Game����
        //������ĸ�����
        print(Screen.width);
        print(Screen.height);

        //��Ļ����ģʽ
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        ///������
        //����ʱ�Ƿ�ȫ��ģʽ һ�㲻�ô������� �ڷ���ʱ����
        Screen.fullScreen = true;
        //�ƶ��豸��Ļת����� ����ʱ��ר�����õĵط� ���ô�������
        //�����Զ���תΪ����� Home������
        Screen.autorotateToLandscapeLeft = true;


        ///2.��̬����
        //���÷ֱ��� һ���ƶ��豸��ʹ��
        Screen.SetResolution(1920, 1080, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
