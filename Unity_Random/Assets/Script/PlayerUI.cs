using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//�v���C���[�̂g�o��\��������
public class PlayerUI : MonoBehaviour
{
    [SerializeField] Battler player = default;
    public Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = ($"HP:{player.hp}");
    }
}
