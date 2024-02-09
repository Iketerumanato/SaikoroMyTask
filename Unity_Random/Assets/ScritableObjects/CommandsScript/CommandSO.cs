using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class CommandSO : ScriptableObject
{
    public new string name;
    //public Text textComponent;

    //攻撃コマンド
    public virtual void Execute(Battler user, Battler target)
    {
        //ダブルコーテーションの前にドルマークを付けると変数を｛｝で扱える！
        //Debug.Log($"{user.name}の攻撃:{target.name}に{3}のダメージ:残りHp{target.hp}");
    }
}
