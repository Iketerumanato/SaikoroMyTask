using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileImage : MonoBehaviour
{
    [SerializeField] Image MasuImage = null;
    public void ClickPlusButton()
    {
       
        MasuImage.sprite = Resources.Load<Sprite>("PlusMasu");
    }
    
    public void ClickMinusButton()
    {
       
        MasuImage.sprite = Resources.Load<Sprite>("MinusMasu");
    }
  
    public void ClickEventButton()
    {
        
        MasuImage.sprite = Resources.Load<Sprite>("EventMasu");
    }
}