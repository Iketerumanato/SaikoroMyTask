using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Backsc1;
    public GameObject Backsc2;


    Vector3 cameraRange;
    float ScSpeed;
    GameObject BackSpeed;
    Rand Dice;

    public EventManager eventmanager;
    public static int  money;
    public Text textComponent;
    Plus plus;
    Minus minus;
    Event evnt;

    // Start is called before the first frame update
    void Start()
    {
        //カメラの範囲を取得
        cameraRange = Camera.main.ViewportToWorldPoint(new Vector3(0,0,Camera.main.transform.position.z));
        //オブジェクトの設定
        BackSpeed = GameObject.Find("GameManager");
        Dice = BackSpeed.GetComponent<Rand>();
        //
        plus = GetComponent<Plus>();
        minus = GetComponent<Minus>();
        evnt = GetComponent<Event>();
        GameObject manajerObject = GameObject.Find("EventManager");
        eventmanager = manajerObject.GetComponent<EventManager>();
        //スコアの初期設定
        money = -1000000;
        textComponent.text = "所持金:" + money;
    }

    // Update is called once per frame
    void Update()
    {
    
        //カメラの左端から完全に出たら、右端に瞬間移動
        if(Backsc1.transform.position.x < (cameraRange.x - Camera.main.transform.position.x) * 2)
        {
            Backsc1.transform.position = new Vector2((Backsc2.transform.position.x - cameraRange.x) * 2, Backsc1.transform.position.y);
        }
        
        if(Backsc2.transform.position.x < (cameraRange.x - Camera.main.transform.position.x) * 2)
        {
            Backsc2.transform.position = new Vector2((Backsc1.transform.position.x - cameraRange.x) * 2, Backsc2.transform.position.y);
        }

    }

    //背景のスクロール
    public void Move()
    {
        //ScSpeed = Dice.ScSpeed;

        Backsc1.transform.Translate(Vector3.right * ScSpeed * Time.deltaTime);   //X軸方向にスクロール
        Backsc2.transform.Translate(Vector3.right * ScSpeed * Time.deltaTime);   //X軸方向にスクロール
    }

    //スコアの変動
    public void PlusMoneyCount()
    {
        money=money+ Random.Range(10000,200001 );
        Debug.Log("所持金:" + money);
        textComponent.text = "所持金:" + money;
        //Dice.countflag = false;
    }
    public void MinusMoneyCount()
    {
        money = money - Random.Range(10000, 200001);
        Debug.Log("所持金:" + money);
        textComponent.text = "所持金:" + money;
        //Dice.countflag = false;
    }
    public void EventMoneyCount()
    {
        eventmanager.Event();
        //Dice.countflag = false;
    }
        public void Goal()
    {
        SceneManager.LoadScene("Result");
    }
    public void GetEventMoney()
    {
        money = eventmanager.money;
        Debug.Log("所持金:" + money);
        textComponent.text = "所持金:" + money;
    }
    public static int GetMoney()
    {
        return money;
    }
}
