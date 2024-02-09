using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    //�L�����N�^�[
    [SerializeField] Battler player = default;
    [SerializeField] Battler enemy = default;

    public Text textComponent;//�e�L�X�g�E�B���h�E�p
    public Text PlayerUI;//UI�p(�v���C���[)
    public Text EnemyUI;//UI�p(�G)

    //�^�[���̊Ǘ�
    enum Phase//�\���̂̎g�p
    {
        StartPhase,//�X�^�[�g
        ChooseCommandPhase,//�R�}���h�I��
        ExecutePhase,//���s
        Result,//����
        End,//�I���
    }

    Phase phase;

    // Start is called before the first frame update
    void Start()
    {
        phase = Phase.StartPhase;//�X�^�[�g�t�F�[�Y����n�߂�
        StartCoroutine(Battle());//�R���[�`���̎��s
    }

    //�R���[�`���̎g�p
    IEnumerator Battle()
    {
        while(phase != Phase.End)
        {
            //�R���[�`�����g���ꍇ�A�l��Ԃ��K�v������
            yield return null;

            Debug.Log(phase);

             //�v���C���[��Hp��\��
             PlayerUI.text = ($"HP:{player.hp}");

            //�G��Hp��\��
            EnemyUI.text = ($"HP:{enemy.hp}");

            switch (phase)
            {
                case Phase.StartPhase:

                    textComponent.text = "�퓬�J�n���I�I�I�I�I";


                    phase = Phase.ChooseCommandPhase;
                    break;

                case Phase.ChooseCommandPhase:
                    //�I���̌�Ɏ��̃t�F�[�Y�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�G���^�[�L�[�̏ꍇ
                    yield return new WaitUntil(() => Input.GetMouseButtonDown(0));//Input.GetKeyDown(KeyCode.Return));

                    textComponent.text = "���荇�����I";
                    
                    phase = Phase.ExecutePhase;
                    break;

                case Phase.ExecutePhase:

                    //�R�}���h�̎��s
                    //�v���C���[
                    player.selectCommand.Execute(player,player.target);
                    //�G
                    enemy.selectCommand.Execute(enemy,enemy.target);


                    //�ǂ��炩�����S������
                    if (player.hp <= 0 || enemy.hp <= 0)
                    {
                        phase = Phase.Result;//���ʃt�F�[�Y��
                    }
                    else
                    {
                        phase = Phase.ChooseCommandPhase;//�R�}���h���s�O��
                    }

                    break;

                    //�����ɂ�������������A�������肷�鏈���������΂����̂��ȁH
                case Phase.Result:

                    if(player.hp > enemy.hp)
                    {
                        Debug.Log("�v���C���[�̏����I");
                        textComponent.text = "�v���C���[�̏����b�I";

                    }

                    else
                    {
                        Debug.Log("�v���C���[�̔s�k!");
                        textComponent.text = "�v���C���[�̔s�k�E�E�E";

                    }

                    if(player.hp == enemy.hp)
                    {
                        textComponent.text = "���������b�I";

                    }

                    //�v���C���[��hp���[���ɂȂ������̃��A�e�L�X�g
                    //(���A�C�x���g�Ȃ̂ł������������炦����A����ʂ����Ȃ��Ȃ�Ƃ�����������)
                    if(player.hp <= 1 && enemy.hp <= 0 && player.hp > enemy.hp)
                    {
                        textComponent.text = "�Ȃ�Ƃ��v���C���[�̏����I";
                    }

                    if (player.hp <= 0 && enemy.hp <= 1 && player.hp < enemy.hp)
                    {
                        textComponent.text = "�ɂ������v���C���[�̔s�k�E�E�E";

                    }

                    phase = Phase.End;
                    break;

                case Phase.End:
                    break;
            }
        }
    }
}