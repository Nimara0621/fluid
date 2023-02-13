using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // �J�������͈͂�����Transform�z��
    private Vector3 upperLeft, lowerRight;

    // �J���p�[�e�B�N���I�u�W�F�N�g
    public GameObject rainDrop;

    // �p�[�e�B�N�����q�v�f�Ƃ��Ċi�[����I�u�W�F�N�g
    public GameObject batch;

    // 1�b�Ԃɍ~�点��J���̐�
    public int rate;

    private int timer = 60;
    // Start is called before the first frame update
    void Start()
    {
        // points�Ɏq�v�f��Transform���i�[����i0 = ���� 1 = �E���j
        Transform[] points = GetComponentsInChildren<Transform>();
        // ����̓_�A�E���̓_�����ꂼ�ꃏ�[���h���W�ɕϊ�����

        upperLeft = points[2].position;
        lowerRight = points[4].position;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= rate;
        if (timer <= 0)
        {
            // 1F���Ƃ̏���(�b��60���j�@1/60 = 
            // 
            float randX = Random.Range(upperLeft.x, lowerRight.x);
            float randY = Random.Range(lowerRight.y, upperLeft.y);
            Vector3 pos = new Vector3(randX, randY, 0);
            Instantiate(rainDrop, pos, Quaternion.identity);
            timer = 60;
        }
    }
}
