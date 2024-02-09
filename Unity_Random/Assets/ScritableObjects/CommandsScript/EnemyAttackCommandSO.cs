using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class EnemyAttackCommandSO : CommandSO
{
    [SerializeField] int EnemyattackPoint;

    //CommandSOのExecuteは実行せずに上書き
    public override void Execute(Battler user, Battler target)
    {
        EnemyattackPoint = Random.Range(1, 5);
        target.hp -= EnemyattackPoint;
        Debug.Log($"{target.name}に{EnemyattackPoint}のダメージ！:残りHp{target.hp}");
    }
}