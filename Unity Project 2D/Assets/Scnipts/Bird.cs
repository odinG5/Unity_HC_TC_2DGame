using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50.1500)]
    public int jumpHeight = 100;
    [Header("是否死亡"), Tooltip("判斷角色是否死亡")]
    public bool isDead;
}
