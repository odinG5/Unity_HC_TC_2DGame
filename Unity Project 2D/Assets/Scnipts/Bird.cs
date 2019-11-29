using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"),Range(50,1500)]
    public int jumpHeight = 100;
    [Header("旋轉角度")]
    public float angle = 5;
    [Header("是否死亡"), Tooltip("判斷角色是否死亡")]
    public bool isDead;

    public GameObject goScore, goGM;
    public Rigidbody2D r2d;      // 2D 剛體

    public GameManager gm;

    [Header("音效區域")]
    public AudioSource and;
    public AudioClip soundJump, soundHit, soundPass;

    private void Update()
    {
        jump();
    }
   
    // 碰種開始事件：物件碰撞開始執行一次 (紀錄碰撞物件資訊) - 針對有勾選 isTrigger
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 碰撞.遊戲物件.名稱
        // print(collision.gameObject.name);

        Dead();
    }
    // 觸發開始物件：物件觸發開始時執行一次 (紀錄碰撞物件資訊)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "水管 ，上" || collision.gameObject.name == "水管 ，下")
        {
            Dead();
        }
    }
    // 觸發開始物件：物件觸發離開時執行一次
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "通過")
        {
            gm.AddScore();
        }
    }

    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void jump()
    {
        if (isDead) return;

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            goScore.SetActive(true);
            goGM.SetActive(true);

            r2d.Sleep();                                    // 2D 剛體.睡著() 重設所有物理資料
            r2d.gravityScale = 1;                           // 2D 剛體.地心引力 = 1
            r2d.AddForce(new Vector2(0, jumpHeight));       // 2D 剛體.推力(二為向量)

            and.PlayOneShot(soundJump, 1.5f);               // 音源.播放一次(音效片段，音量)
        }

       r2d.SetRotation(angle * r2d.velocity.y);                                // 2D 剛體.旋轉(角度)
       //print(r2d.velocity);
    }

    /// <summary>
   /// 小雞死亡功能
   /// </summary>
    private void Dead()
    {
        isDead = true;
        gm.GameOver();
        // 靜態成員：類別.靜態成員
        Floor.speed = 0;
    }

    /// <summary>
   /// 通過水管
   /// </summary>
    private void PassPipe()
    {
        
    }
}
