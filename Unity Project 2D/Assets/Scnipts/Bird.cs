using UnityEngine;

public class Bird : MonoBehaviour
{
   [Header("跳躍高度"),Range(50,1500)]
    public int jumpHeight = 100;
    [Header("是否死亡"), Tooltip("判斷角色是否死亡")]
    public bool isDead;

    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void jump()
    {

    }

    /// <summary>
    /// 小雞死亡功能
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 通過水管
    /// </summary>
    private void PassPipe()
    {

    }
}
