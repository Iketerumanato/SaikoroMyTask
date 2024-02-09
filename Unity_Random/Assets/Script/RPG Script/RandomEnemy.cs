using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//“G‚Ì‰æ‘œ‚ğƒ‰ƒ“ƒ_ƒ€‚Å•\¦i‡ŒvO–‡j
public class RandomEnemy : MonoBehaviour
{
    [SerializeField] Image EnemyImage = null;//‰æ‘œ‚Ìİ’è
    [SerializeField] Battler enemy = default;//enemy‚Ìî•ñ‚ğg—p
    private float angle;//‚Ğ‚Á‚­‚è•Ô‚·‚½‚ß‚Ì•Ï”
    private int randomNo;//‰æ‘œ‚Ì”Ô†

    // Start is called before the first frame update
    void Start()
    {
        randomNo = Random.Range(1, 4);//—”¶¬
        angle = 90.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // ‰æ‘œ‚ğ•\¦
        switch (randomNo)
        {
            case 1:
                EnemyImage.sprite = Resources.Load<Sprite>("EventEnemy1");//“G‚Ì‰æ‘œ‚P
                break;
            case 2:
                EnemyImage.sprite = Resources.Load<Sprite>("EventEnemy2");//“G‚Ì‰æ‘œ‚Q
                break;
            case 3:
                EnemyImage.sprite = Resources.Load<Sprite>("EventEnemy3");//“G‚Ì‰æ‘œ‚R
                break;
        }

        //“G‚ª€‚ñ‚¾‚ç‚Ğ‚Á‚­‚è•Ô‚é
        if (enemy.hp <= 0)
        {
            transform.rotation = Quaternion.AngleAxis(angle * 2, Vector3.back);
        }
    }
}
