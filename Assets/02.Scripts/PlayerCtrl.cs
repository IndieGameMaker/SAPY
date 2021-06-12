using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Animation anim;

    // 1번 호출 , 제일 먼저 호출
    void Start()
    {
        // 컴포넌트를 추출해서 anim 변수에 할당
        anim = GetComponent<Animation>();
        //anim = this.gameObject.GetComponent<Animation>();
        anim.Play("Idle");
    }

    // 랜더링 주기
    void Update()
    {
        float v = Input.GetAxisRaw("Vertical"); // Up, Down Arrow   -1.0f ~ 0.0f ~ +1.0f
        float h = Input.GetAxisRaw("Horizontal"); // Left, Right Arrow -1.0f ~ 0.0f ~ +1.0f
        float r = Input.GetAxis("Mouse X");

        // 크기가 1인 벡터로 변환 = 정규화 , Normalized
        // 이동로직
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        transform.Translate(moveDir.normalized * Time.deltaTime * 8.0f);
        // 회전로직
        transform.Rotate(Vector3.up * Time.deltaTime * r * 100.0f);

        // 주인공 캐릭터의 애니메이션 처리
        if (v >= 0.1f) // 전진 RunF
        {
            // Animation Blending 처리
            anim.CrossFade("RunF", 0.25f);
        }
        else if (v <= -0.1f) // 후진 RunB
        {
            anim.CrossFade("RunB", 0.25f);
        }
        else if (h >= 0.1f)  // 오른쪽 RunR
        {
            anim.CrossFade("RunR", 0.25f);
        }
        else if (h <= -0.1f) // 왼쪽 RunL
        {
            anim.CrossFade("RunL", 0.25f);
        }
        else
        {
            anim.CrossFade("Idle", 0.25f);
        }
    }

    /*
        Vector3 (구조체) new Vector3(x, y, z)
        정규화 벡터, 유닛벡터, 단위벡터
        
        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.one     = Vector3(1, 1, 1)
        Vector3.zero    = Vector3(0, 0, 0)
    */
}
