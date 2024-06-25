using System;
using UnityEngine;

public class Data
{
    //점프 방향 값
    public static float JumpDirection = .5f;


}

[Serializable]
public struct Player
{
    public float hp;
    public float jumpForce;

    public bool isGrounded;

    public Vector3 playerPosi;

    public float HP { get { return hp; } set { hp = value; } }
    public float JumpForce { get { return jumpForce; } set { jumpForce = value; } }
    public bool IsGrounded { get { return isGrounded; } set { isGrounded = value; } }
    public Vector3 PlayerPosi { get { return playerPosi; } set { playerPosi = value; } }
}
