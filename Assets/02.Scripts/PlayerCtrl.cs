using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    // 1번 호출 , 제일 먼저 호출
    void Start()
    {
        // 데이터를 조회하기 위한 로그 메시지 출력
        Debug.Log("Called Start Function !!");
    }

    // 랜더링 주기
    void Update()
    {
        float v = Input.GetAxis("Vertical"); // Up, Down Arrow   -1.0f ~ 0.0f ~ +1.0f
        Debug.Log("v=" + v);

        // Transform 컴포넌트
        //transform.position += new Vector3(0, 0, 0.1f);
        transform.Translate(Vector3.forward * 0.1f * v);  //new Vector3(0, 0, 1) * 0.1f
    }

    /*
        Vector3 (구조체) new Vector3(x, y, z)

        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.one     = Vector3(1, 1, 1)
        Vector3.zero    = Vector3(0, 0, 0)
    */
}
