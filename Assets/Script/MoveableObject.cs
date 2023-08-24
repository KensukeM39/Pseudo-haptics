using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    public float minY = 0.1f; // Y座標の最小値
    public float maxY = 7.5f; // Y座標の最大値
    public float jumpForce = 10.0f; // ジャンプ時の上方向の力
    public float fallSpeed = 2.0f; // 落下速度

    private Rigidbody rb;
    private bool isJumping = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // ジャンプ処理
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            isJumping = true;
        }

        // 落下速度を適用
        if (!isJumping)
        {
            rb.velocity += Vector3.down * fallSpeed * Time.deltaTime;

            // Y座標の制限を適用
            Vector3 newPosition = rb.position + rb.velocity * Time.deltaTime;
            newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

            // Y座標が最大値に達したら速度を反転させて下方向に落下
            if (newPosition.y >= maxY)
            {
                newPosition.y = maxY;
                rb.velocity = Vector3.zero;
            }

            rb.position = newPosition;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 地面に着地したらジャンプ可能状態にする
        isJumping = false;
    }
}
