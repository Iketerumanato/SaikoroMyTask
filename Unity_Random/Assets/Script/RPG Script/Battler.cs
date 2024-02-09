using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battler : MonoBehaviour
{
    //技は独立したクラスで管理
    //技を増やすときは継承で管理

    //HPと名前
    public new string name;
    public int hp;

    //実行するコマンド
    public CommandSO selectCommand;
    //行動する対象の設定
    public Battler target;

    //持っている技
    public CommandSO[] commands;
}