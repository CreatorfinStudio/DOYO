using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoBehaviour, IPlayerService
{
    [SerializeField]
    private Player player;

    private void Start()
    {
        player = new Player();
        Init();
    }
    private void Update()
    {
        player.PlayerPosi = this.gameObject.transform.position;
    }

    private void Init()
    {
        player.JumpForce = 6;
    }


    #region Interface
    public float GetHP() => player.HP;
    public float GetJumpForce() => player.JumpForce;
    public bool GetIsGrounded() => player.IsGrounded;
    public Vector3 GetPlayerPosi() => player.PlayerPosi;

    public void SetHP(float hp) => player.HP = hp;
    public void SetJumpForce(float jumpForce) => player.JumpForce = jumpForce;
    public void SetIsGrounded(bool isGrounded) => player.IsGrounded = isGrounded;
    public void SetPlayerPosi(Vector3 playerPosi) => player.PlayerPosi = playerPosi;
    #endregion
}
