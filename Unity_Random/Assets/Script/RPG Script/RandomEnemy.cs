using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//敵の画像をランダムで表示（合計三枚）
public class RandomEnemy : MonoBehaviour
{
    [SerializeField] Image EnemyImage = null;//画像の設定
    [SerializeField] Battler enemy = default;//enemyの情報を使用
    private float angle;//ひっくり返すための変数
    private int randomNo;//画像の番号

    // Start is called before the first frame update
    void Start()
    {
        randomNo = Random.Range(1, 4);//乱数生成
        angle = 90.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // 画像を表示
        switch (randomNo)
        {
            case 1:
                EnemyImage.sprite = Resources.Load<Sprite>("EventEnemy1");//敵の画像１
                break;
            case 2:
                EnemyImage.sprite = Resources.Load<Sprite>("EventEnemy2");//敵の画像２
                break;
            case 3:
                EnemyImage.sprite = Resources.Load<Sprite>("EventEnemy3");//敵の画像３
                break;
        }

        //敵が死んだらひっくり返る
        if (enemy.hp <= 0)
        {
            transform.rotation = Quaternion.AngleAxis(angle * 2, Vector3.back);
        }
    }
}
