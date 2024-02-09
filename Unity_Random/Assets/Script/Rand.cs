using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rand : MonoBehaviour
{
    public int rand;
    public Text textComponent;
    // Start is called before the first frame update
    public void OnClick()
    {
        rand=Random.Range(1, 7);
        Debug.Log("" + rand);
        textComponent.text = "" + rand;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
