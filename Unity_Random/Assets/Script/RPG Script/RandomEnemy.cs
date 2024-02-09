using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�G�̉摜�������_���ŕ\���i���v�O���j
public class RandomEnemy : MonoBehaviour
{
    [SerializeField] Image EnemyImage = null;//�摜�̐ݒ�
    [SerializeField] Battler enemy = default;//enemy�̏����g�p
    private float angle;//�Ђ�����Ԃ����߂̕ϐ�
    private int randomNo;//�摜�̔ԍ�

    // Start is called before the first frame update
    void Start()
    {
        randomNo = Random.Range(1, 4);//��������
        angle = 90.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // �摜��\��
        switch (randomNo)
        {
            case 1:
                EnemyImage.sprite = Resources.Load<Sprite>("EventEnemy1");//�G�̉摜�P
                break;
            case 2:
                EnemyImage.sprite = Resources.Load<Sprite>("EventEnemy2");//�G�̉摜�Q
                break;
            case 3:
                EnemyImage.sprite = Resources.Load<Sprite>("EventEnemy3");//�G�̉摜�R
                break;
        }

        //�G�����񂾂�Ђ�����Ԃ�
        if (enemy.hp <= 0)
        {
            transform.rotation = Quaternion.AngleAxis(angle * 2, Vector3.back);
        }
    }
}
