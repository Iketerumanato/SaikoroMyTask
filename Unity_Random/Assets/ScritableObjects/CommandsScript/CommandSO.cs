using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class CommandSO : ScriptableObject
{
    public new string name;
    //public Text textComponent;

    //�U���R�}���h
    public virtual void Execute(Battler user, Battler target)
    {
        //�_�u���R�[�e�[�V�����̑O�Ƀh���}�[�N��t����ƕϐ����o�p�ň�����I
        //Debug.Log($"{user.name}�̍U��:{target.name}��{3}�̃_���[�W:�c��Hp{target.hp}");
    }
}
