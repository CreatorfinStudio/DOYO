using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (GameManager.Instance.player.GetIsGrounded() && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }
    void Jump()
    {
        Debug.LogError(Data.JumpDirection);

        // 제자리 뛰기
        if (Data.JumpDirection == 0)
        {
            rb.AddForce(Vector3.up * GameManager.Instance.player.GetJumpForce(), ForceMode.Impulse);
        }
        else
        {
            // 방향 계산: -1 (왼쪽, 뒤로), 1 (오른쪽, 앞으로)
            float direction = Mathf.Sign(Data.JumpDirection);
            float angle = Mathf.Abs(Data.JumpDirection) * 75; // 점프 각도 최대 75도

            bool isFlipped = this.gameObject.transform.eulerAngles.y > 90 && this.gameObject.transform.eulerAngles.y < 270;

            // 뒤집힌 상태라면 방향 반전
            if (isFlipped)
            {
                direction *= -1;
            }
            if (direction < 0)
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            Vector3 jumpVector = new Vector3(direction * Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad), 0);
            rb.AddForce(jumpVector * GameManager.Instance.player.GetJumpForce(), ForceMode.Impulse);
        }
    }
}
