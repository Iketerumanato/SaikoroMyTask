using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManajer : MonoBehaviour
{
    private int money;
    private int i;
    public Text textComponent;
    public Text textMoney;
    // Start is called before the first frame update
    void Start()
    {
        money = -1000000;
        textComponent.text = "������:" + money.ToString("N0");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlusMoneyCount()
    {
        i = Random.Range(10000, 200001);
        money = money + i;
        Debug.Log("������:" + money);
        textComponent.text = "������:" + money.ToString("N0");
        textMoney.text = i.ToString("N0") + "�~��ɓ��ꂽ";
    }
    public void MinusMoneyCount()
    {
        i = Random.Range(10000, 200001);
        money = money - i;
        Debug.Log("������:" + money);
        textComponent.text = "������:" + money.ToString("N0");
        textMoney.text = i.ToString("N0") + "�~������";
    }
    public void EventMoneyCount()
    {
        i = Random.Range(-1000000, 1000001);
        money = money + i;
        Debug.Log("������:" + money);
        textComponent.text = "������:" + money.ToString("N0");
        if (i <= 0)
        {
            textMoney.text = i.ToString("N0") + "�~������";
        }
        if (i >= 1)
        {
            textMoney.text = i.ToString("N0") + "�~��ɓ��ꂽ";
        }
    }
}
