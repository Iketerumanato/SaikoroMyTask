using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomImage : MonoBehaviour
{
    [SerializeField] Image MasuImage = null;//�摜�̐ݒ�
    public bool a;//true��false�̔���
    int RandNo;//�o�ڂ̗���

    //int[] masu = { 1, 2, 3 };

    void Start()
    {
        //int a = 0;
        //while(a < 5)
        //{
        //    Debug.Log("a��" + a + "�ł��B");
        //    a++;
        //}

        a = true;
        RandNo = 0;
    }

    void Update()
    {
        if (a == true)
        {
            RandNo = Random.Range(1, 6);
            if (Input.GetKeyDown(KeyCode.Space)) { a = false; }
        }

        else if (Input.GetKeyDown(KeyCode.Space) && a == false) { a = true; }

        switch (RandNo)
        {
            case 1:
                MasuImage.sprite = Resources.Load<Sprite>("Dice1");
                break;
            case 2:
                MasuImage.sprite = Resources.Load<Sprite>("Dice2");
                break;
            case 3:
                MasuImage.sprite = Resources.Load<Sprite>("Dice3");
                break;
            case 4:
                MasuImage.sprite = Resources.Load<Sprite>("Dice4");
                break;
            case 5:
                MasuImage.sprite = Resources.Load<Sprite>("Dice5");
                break;
            case 6:
                MasuImage.sprite = Resources.Load<Sprite>("Dice6");
                break;

            default:
                Debug.Log("�G���[");
                break;
        }

    }
}