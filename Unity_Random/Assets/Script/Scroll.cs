using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField]
    public float ScrollSpeed;//�X�N���[���̑���
    public float ScrollStart;//�X�N���[���̃X�^�[�g�ʒu
    public float ScrollEnd;//�X�N���[���̏I���̈ʒu

    //[SerializeField]
    ////�X�N���[�����鑬��
    //float scrollSpeed = -1;
    ////�J�����͈̔�
    //Vector3 cameraRectMin;

    // Update is called once per frame

    //private void Start()
    //{
    //    //�J�����͈̔͂��擾
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
    //    //X�������ɃX�N���[��
    //    transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);

    //    //�J�����̍��[���犮�S�ɏo����A�E�[�ɏu�Ԉړ�
    //    if (transform.position.x < (cameraRectMin.x - Camera.main.transform.position.x) * 2)
    //    {
    //        transform.position = new Vector2((Camera.main.transform.position.x - cameraRectMin.x) * 2, transform.position.y);
    //    }
    //}

    public void BG_Scroll()
    {
        transform.Translate(ScrollSpeed, 0, 0);//x����ɓ���

        if (transform.position.x < ScrollEnd)
        {
            transform.position = new Vector3(ScrollStart, 0, 0);//�w�i���X�^�[�g�܂Ŗ߂�
        }
    }
}
