using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class messagePanel : MonoBehaviour
{
	//�@MessageUI�ɐݒ肳��Ă���Message�X�N���v�g��ݒ�
	[SerializeField]
	private message messageScript;

	//�@�\�������郁�b�Z�[�W
	private string message = "�g�E�z�N�J�C�I�[���ꒅ�ŏ����B"
		+ "�܋��T�O�����l�������B";

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Fire2"))
		{
			messageScript.SetMessagePanel(message);
		}
	}
}
