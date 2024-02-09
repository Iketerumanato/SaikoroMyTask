using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    //キャラクター
    [SerializeField] Battler player = default;
    [SerializeField] Battler enemy = default;

    public Text textComponent;//テキストウィンドウ用
    public Text PlayerUI;//UI用(プレイヤー)
    public Text EnemyUI;//UI用(敵)

    //ターンの管理
    enum Phase//構造体の使用
    {
        StartPhase,//スタート
        ChooseCommandPhase,//コマンド選択
        ExecutePhase,//実行
        Result,//結果
        End,//終わり
    }

    Phase phase;

    // Start is called before the first frame update
    void Start()
    {
        phase = Phase.StartPhase;//スタートフェーズから始める
        StartCoroutine(Battle());//コルーチンの実行
    }

    //コルーチンの使用
    IEnumerator Battle()
    {
        while(phase != Phase.End)
        {
            //コルーチンを使う場合、値を返す必要がある
            yield return null;

            Debug.Log(phase);

             //プレイヤーのHpを表示
             PlayerUI.text = ($"HP:{player.hp}");

            //敵のHpを表示
            EnemyUI.text = ($"HP:{enemy.hp}");

            switch (phase)
            {
                case Phase.StartPhase:

                    textComponent.text = "戦闘開始ぃ！！！！！";


                    phase = Phase.ChooseCommandPhase;
                    break;

                case Phase.ChooseCommandPhase:
                    //選択の後に次のフェーズ　　　　　　　　　　　　　　　　　　　　エンターキーの場合
                    yield return new WaitUntil(() => Input.GetMouseButtonDown(0));//Input.GetKeyDown(KeyCode.Return));

                    textComponent.text = "殴り合いだ！";
                    
                    phase = Phase.ExecutePhase;
                    break;

                case Phase.ExecutePhase:

                    //コマンドの実行
                    //プレイヤー
                    player.selectCommand.Execute(player,player.target);
                    //敵
                    enemy.selectCommand.Execute(enemy,enemy.target);


                    //どちらかが死亡したら
                    if (player.hp <= 0 || enemy.hp <= 0)
                    {
                        phase = Phase.Result;//結果フェーズへ
                    }
                    else
                    {
                        phase = Phase.ChooseCommandPhase;//コマンド実行前へ
                    }

                    break;

                    //ここにお金が増えたり、減ったりする処理を書けばいいのかな？
                case Phase.Result:

                    if(player.hp > enemy.hp)
                    {
                        Debug.Log("プレイヤーの勝利！");
                        textComponent.text = "プレイヤーの勝利ッ！";

                    }

                    else
                    {
                        Debug.Log("プレイヤーの敗北!");
                        textComponent.text = "プレイヤーの敗北・・・";

                    }

                    if(player.hp == enemy.hp)
                    {
                        textComponent.text = "引き分けッ！";

                    }

                    //プレイヤーのhpがゼロになった時のレアテキスト
                    //(レアイベントなのでお金が多くもらえたり、減る量が少なくなるとかがいいかも)
                    if(player.hp <= 1 && enemy.hp <= 0 && player.hp > enemy.hp)
                    {
                        textComponent.text = "なんとかプレイヤーの勝利！";
                    }

                    if (player.hp <= 0 && enemy.hp <= 1 && player.hp < enemy.hp)
                    {
                        textComponent.text = "惜しくもプレイヤーの敗北・・・";

                    }

                    phase = Phase.End;
                    break;

                case Phase.End:
                    break;
            }
        }
    }
}