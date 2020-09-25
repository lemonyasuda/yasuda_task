using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))//左矢印キーが押されたら
        {
            transform.position += transform.forward * 0.1f;//positionの値のz方向に0.1を足す
        }
        else if (Input.GetKey(KeyCode.RightArrow))//右矢印キーが押されたら
        {
            transform.position -= transform.forward * 0.1f;//positionの値のz方向に0.1を引く
        }
    }
}
