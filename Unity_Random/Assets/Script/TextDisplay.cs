using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public string[] texts;//Unity上で入力する文字列
    int textNumber;//何番目にtexts[]を表示するか
    string displayText;//画面表示のテキスト
    int textCharNumber;//一文字ずつの番号
    int displayTextSpeed;//テキストのスピード
    bool click;//クリックの判定
    bool textStop;//テキスト表示の開始

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        if (textStop == false) //テキストを表示させるif文
        {
            displayTextSpeed++;
            if (displayTextSpeed % 5 == 0)
            {

                if (textCharNumber != texts[textNumber].Length)
                {
                    displayText = displayText + texts[textNumber][textCharNumber];//displayTextに文字を追加していく
                    textCharNumber = textCharNumber + 1;//次の文字にする
                }

                else
                {
                    if (textNumber != texts.Length - 1)
                    {
                        if (click == true)
                        {
                            displayText = "";//表示させる文字列を消す
                            textCharNumber = 0;//文字の番号を最初にする
                            textNumber = textNumber + 1;//次のセリフにする
                        }
                    }
                    else //もしtexts[]が最後のセリフになったら
                    {
                        if (click == true)
                        {
                            displayText = "";
                            textCharNumber = 0;
                            textStop = true; //セリフ表示を止める
                        }
                    }
                }

                this.GetComponent<Text>().text = displayText;//画面上にテキストを表示
                click = false;
            }

            if (Input.GetMouseButtonDown(0))//クリックしたら次のテキストへ
            {
                click = true;
            }
        }
    }
}
