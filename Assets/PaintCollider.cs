using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCollider : MonoBehaviour
{
    private Vector3 mousePos;
    private Vector3 worldPos;
    public GameObject col;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = 10f;
            worldPos = cam.ScreenToWorldPoint(mousePos);
            Instantiate(col,worldPos,Quaternion.identity);
        }
    }
}
