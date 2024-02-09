using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public string[] texts;//Unity��œ��͂��镶����
    int textNumber;//���Ԗڂ�texts[]��\�����邩
    string displayText;//��ʕ\���̃e�L�X�g
    int textCharNumber;//�ꕶ�����̔ԍ�
    int displayTextSpeed;//�e�L�X�g�̃X�s�[�h
    bool click;//�N���b�N�̔���
    bool textStop;//�e�L�X�g�\���̊J�n

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        if (textStop == false) //�e�L�X�g��\��������if��
        {
            displayTextSpeed++;
            if (displayTextSpeed % 5 == 0)
            {

                if (textCharNumber != texts[textNumber].Length)
                {
                    displayText = displayText + texts[textNumber][textCharNumber];//displayText�ɕ�����ǉ����Ă���
                    textCharNumber = textCharNumber + 1;//���̕����ɂ���
                }

                else
                {
                    if (textNumber != texts.Length - 1)
                    {
                        if (click == true)
                        {
                            displayText = "";//�\�������镶���������
                            textCharNumber = 0;//�����̔ԍ����ŏ��ɂ���
                            textNumber = textNumber + 1;//���̃Z���t�ɂ���
                        }
                    }
                    else //����texts[]���Ō�̃Z���t�ɂȂ�����
                    {
                        if (click == true)
                        {
                            displayText = "";
                            textCharNumber = 0;
                            textStop = true; //�Z���t�\�����~�߂�
                        }
                    }
                }

                this.GetComponent<Text>().text = displayText;//��ʏ�Ƀe�L�X�g��\��
                click = false;
            }

            if (Input.GetMouseButtonDown(0))//�N���b�N�����玟�̃e�L�X�g��
            {
                click = true;
            }
        }
    }
}
