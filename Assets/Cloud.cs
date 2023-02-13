using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // 雨粒生成範囲を示すTransform配列
    private Vector3 upperLeft, lowerRight;

    // 雨粒パーティクルオブジェクト
    public GameObject rainDrop;

    // パーティクルを子要素として格納するオブジェクト
    public GameObject batch;

    // 1秒間に降らせる雨粒の数
    public int rate;

    private int timer = 60;
    // Start is called before the first frame update
    void Start()
    {
        // pointsに子要素のTransformを格納する（0 = 左上 1 = 右下）
        Transform[] points = GetComponentsInChildren<Transform>();
        // 左上の点、右下の点をそれぞれワールド座標に変換する

        upperLeft = points[2].position;
        lowerRight = points[4].position;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= rate;
        if (timer <= 0)
        {
            // 1Fごとの処理(秒間60粒）　1/60 = 
            // 
            float randX = Random.Range(upperLeft.x, lowerRight.x);
            float randY = Random.Range(lowerRight.y, upperLeft.y);
            Vector3 pos = new Vector3(randX, randY, 0);
            Instantiate(rainDrop, pos, Quaternion.identity);
            timer = 60;
        }
    }
}
