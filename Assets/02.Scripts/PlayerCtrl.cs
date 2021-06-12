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
        // Debug.Log("Called Update " + Time.time);
    }
}
