using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int rand;


    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 7);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0.02f, 0.0f);
        }

        if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -0.02f, 0.0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.02f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.02f, 0f, 0f);
        }
    }
}
