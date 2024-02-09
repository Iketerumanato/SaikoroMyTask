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
        //�J�����͈̔͂��擾
        cameraRange = Camera.main.ViewportToWorldPoint(new Vector3(0,0,Camera.main.transform.position.z));
        //�I�u�W�F�N�g�̐ݒ�
        BackSpeed = GameObject.Find("GameManager");
        Dice = BackSpeed.GetComponent<Rand>();
        //
        plus = GetComponent<Plus>();
        minus = GetComponent<Minus>();
        evnt = GetComponent<Event>();
        GameObject manajerObject = GameObject.Find("EventManager");
        eventmanager = manajerObject.GetComponent<EventManager>();
        //�X�R�A�̏����ݒ�
        money = -1000000;
        textComponent.text = "������:" + money;
    }

    // Update is called once per frame
    void Update()
    {
    
        //�J�����̍��[���犮�S�ɏo����A�E�[�ɏu�Ԉړ�
        if(Backsc1.transform.position.x < (cameraRange.x - Camera.main.transform.position.x) * 2)
        {
            Backsc1.transform.position = new Vector2((Backsc2.transform.position.x - cameraRange.x) * 2, Backsc1.transform.position.y);
        }
        
        if(Backsc2.transform.position.x < (cameraRange.x - Camera.main.transform.position.x) * 2)
        {
            Backsc2.transform.position = new Vector2((Backsc1.transform.position.x - cameraRange.x) * 2, Backsc2.transform.position.y);
        }

    }

    //�w�i�̃X�N���[��
    public void Move()
    {
        //ScSpeed = Dice.ScSpeed;

        Backsc1.transform.Translate(Vector3.right * ScSpeed * Time.deltaTime);   //X�������ɃX�N���[��
        Backsc2.transform.Translate(Vector3.right * ScSpeed * Time.deltaTime);   //X�������ɃX�N���[��
    }

    //�X�R�A�̕ϓ�
    public void PlusMoneyCount()
    {
        money=money+ Random.Range(10000,200001 );
        Debug.Log("������:" + money);
        textComponent.text = "������:" + money;
        //Dice.countflag = false;
    }
    public void MinusMoneyCount()
    {
        money = money - Random.Range(10000, 200001);
        Debug.Log("������:" + money);
        textComponent.text = "������:" + money;
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
        Debug.Log("������:" + money);
        textComponent.text = "������:" + money;
    }
    public static int GetMoney()
    {
        return money;
    }
}
