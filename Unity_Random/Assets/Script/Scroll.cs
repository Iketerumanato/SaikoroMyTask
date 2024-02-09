using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField]
    public float ScrollSpeed;//スクロールの速さ
    public float ScrollStart;//スクロールのスタート位置
    public float ScrollEnd;//スクロールの終わりの位置

    //[SerializeField]
    ////スクロールする速さ
    //float scrollSpeed = -1;
    ////カメラの範囲
    //Vector3 cameraRectMin;

    // Update is called once per frame

    //private void Start()
    //{
    //    //カメラの範囲を取得
    //    cameraRectMin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
    //}
    void Update()
    {
        BG_Scroll();

        //Move();

        transform.Translate(-0.01f, 0, 0);
        if (transform.position.x < -14.5f)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

    //void Move()
    //{
    //    //X軸方向にスクロール
    //    transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);

    //    //カメラの左端から完全に出たら、右端に瞬間移動
    //    if (transform.position.x < (cameraRectMin.x - Camera.main.transform.position.x) * 2)
    //    {
    //        transform.position = new Vector2((Camera.main.transform.position.x - cameraRectMin.x) * 2, transform.position.y);
    //    }
    //}

    public void BG_Scroll()
    {
        transform.Translate(ScrollSpeed, 0, 0);//x軸上に動く

        if (transform.position.x < ScrollEnd)
        {
            transform.position = new Vector3(ScrollStart, 0, 0);//背景をスタートまで戻す
        }
    }
}
