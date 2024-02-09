using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus : MonoBehaviour
{
    public GameManajer gameManajer;
    void Start()
    {
        GameObject manajerObject = GameObject.Find("GameManajer");
        gameManajer = manajerObject.GetComponent<GameManajer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.tag=="Player")
        {
            gameManajer.PlusMoneyCount();
           
        }
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
