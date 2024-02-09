using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AttackCommandSO : CommandSO
{
    [SerializeField] int AttackPoint;

    //CommandSO��Execute�͎��s�����ɏ㏑��
    public override void Execute(Battler user, Battler target)
    {
        AttackPoint = Random.Range(1, 5);
        target.hp -= AttackPoint;
        Debug.Log($"{target.name}��{AttackPoint}�̃_���[�W�I:�c��Hp{target.hp}");
    }
}