using UnityEngine;

public class Floor : MonoBehaviour
{
    [Header("速度"), Range(0.1F, 100F)]
    public float speed = 1.5f;

    public Transform ground;

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
