using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EventManager : MonoBehaviour
{
    // Start is called before the first frame update
    GameManager gamemanager;
    
    public Message message;
    public Message2 message2;
    public int money;
    public Text textComponent;
    public int RandomEvent;
    void Start()
    {
        money = GameManager.GetMoney();
        RandomEvent = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Event()
    {
        RandomEvent = Random.Range(1, 3);
        Debug.Log("�����_���l" + RandomEvent);
        if (RandomEvent == 1)
        {
            Debug.Log("�v���X�C�x���g");
            PlusEvent();
        }
        if (RandomEvent == 2)
        {
            Debug.Log("�}�C�i�X�C�x���g");
            MinusEvent();
        }
    }
    void PlusEvent()
    {
        message.SetActiveMessage();
        money = money + Random.Range(500000, 500001);
        Debug.Log("������:" + money);
        textComponent.text = "������:" + money;
        gamemanager.GetEventMoney();
    }
    void MinusEvent()
    {
        message2.SetActiveMessage();
        money = money - Random.Range(200000, 200001);
        Debug.Log("������:" + money);
        textComponent.text = "������:" + money;
        gamemanager.GetEventMoney();
    }
}
