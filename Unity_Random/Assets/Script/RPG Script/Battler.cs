using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battler : MonoBehaviour
{
    //�Z�͓Ɨ������N���X�ŊǗ�
    //�Z�𑝂₷�Ƃ��͌p���ŊǗ�

    //HP�Ɩ��O
    public new string name;
    public int hp;

    //���s����R�}���h
    public CommandSO selectCommand;
    //�s������Ώۂ̐ݒ�
    public Battler target;

    //�����Ă���Z
    public CommandSO[] commands;
}