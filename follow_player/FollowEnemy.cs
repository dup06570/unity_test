using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform�� ������ ����
    public float followDistance = 10.0f; // ������ ������ �Ÿ�

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
            // ���� ����
            isFollowing = true;
        }

        if (isFollowing)
        {
            // �÷��̾ ����ٴϴ� ������ ����
            Vector3 direction = (player.position - transform.position).normalized;
            rb.velocity = direction * 3.0f; // ������ �ӵ��� �÷��̾ ���󰡵��� ����
        }
        else
        {
            rb.velocity = Vector3.zero; // ���� ���� �ƴ϶�� ����
        }
    }
}
