using UnityEngine;

interface IPlayerService
{
    public float GetHP();
    public float GetJumpForce();
    public bool GetIsGrounded();
    public Vector3 GetPlayerPosi();

    public void SetHP(float hp);
    public void SetJumpForce(float jumpForce);
    public void SetIsGrounded(bool isGrounded);
    public void SetPlayerPosi(Vector3 playerPosi);
}
