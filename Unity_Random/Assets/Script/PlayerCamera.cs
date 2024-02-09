using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//カメラをプレイヤーに追従させる
public class PlayerCamera : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        //カメラとプレイヤーのカメラの位置を同じにする
        transform.position = new Vector3(playerPos.x, playerPos.y, -10);
    }
}
