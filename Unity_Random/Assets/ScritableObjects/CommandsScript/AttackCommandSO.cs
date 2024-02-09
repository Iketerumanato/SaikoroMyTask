using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AttackCommandSO : CommandSO
{
    [SerializeField] int AttackPoint;

    //CommandSOのExecuteは実行せずに上書き
    public override void Execute(Battler user, Battler target)
    {
        AttackPoint = Random.Range(1, 5);
        target.hp -= AttackPoint;
        Debug.Log($"{target.name}に{AttackPoint}のダメージ！:残りHp{target.hp}");
    }
}