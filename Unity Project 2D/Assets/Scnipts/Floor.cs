using UnityEngine;

public class Floor : MonoBehaviour
{
    // 靜態 此類別共用
    // 隱藏
    // [Header("速度"), Range(0.1F, 100F)]
    // 靜態欄位 再重新載入場景時不會還原為預設值
    public static float speed = 5f;

    public Transform ground;

    private void Start()
    {
        speed = 3f;
    }

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// 地板的移動方法。
    /// </summary>
    private void Move()
    {
        // Time.deltaTime 一個影格的時間 (根據電腦效能不同)
        ground.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
