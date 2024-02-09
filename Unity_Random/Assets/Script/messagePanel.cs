using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class messagePanel : MonoBehaviour
{
	//　MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private message messageScript;

	//　表示させるメッセージ
	private string message = "トウホクカイオーが一着で勝利。"
		+ "賞金５０万を獲得した。";

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Fire2"))
		{
			messageScript.SetMessagePanel(message);
		}
	}
}
