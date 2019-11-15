using UnityEngine;

public class LearnAPITwo : MonoBehaviour
{
    // 存放類別欄位
    public Bird bird;

    private void Start()
    {
        // 設定其他別的欄位
        bird.jumpHeight = 999;

        // 取得其他別的欄位
        print("小雞的跳躍欄位：" + bird.jumpHeight);
    }
}
