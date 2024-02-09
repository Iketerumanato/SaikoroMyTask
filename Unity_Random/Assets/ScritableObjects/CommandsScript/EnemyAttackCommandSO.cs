using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class EnemyAttackCommandSO : CommandSO
{
    [SerializeField] int EnemyattackPoint;

    //CommandSO��Execute�͎��s�����ɏ㏑��
    public override void Execute(Battler user, Battler target)
    {
        EnemyattackPoint = Random.Range(1, 5);
        target.hp -= EnemyattackPoint;
        Debug.Log($"{target.name}��{EnemyattackPoint}�̃_���[�W�I:�c��Hp{target.hp}");
    }
}