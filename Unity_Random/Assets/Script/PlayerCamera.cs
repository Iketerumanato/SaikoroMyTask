using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�J�������v���C���[�ɒǏ]������
public class PlayerCamera : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        //�J�����ƃv���C���[�̃J�����̈ʒu�𓯂��ɂ���
        transform.position = new Vector3(playerPos.x, playerPos.y, -10);
    }
}
