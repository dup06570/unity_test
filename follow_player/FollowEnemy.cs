using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform을 참조할 변수
    public float followDistance = 10.0f; // 추적을 시작할 거리

    private Rigidbody rb;
    private bool isFollowing = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= followDistance)
        {
            // 추적 시작
            isFollowing = true;
        }

        if (isFollowing)
        {
            // 플레이어를 따라다니는 로직을 구현
            Vector3 direction = (player.position - transform.position).normalized;
            rb.velocity = direction * 3.0f; // 적절한 속도로 플레이어를 따라가도록 설정
        }
        else
        {
            rb.velocity = Vector3.zero; // 추적 중이 아니라면 정지
        }
    }
}
