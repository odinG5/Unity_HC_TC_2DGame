using UnityEngine;

public class Floor : MonoBehaviour
{
    [Header("速度"), Range(0.1F, 100F)]
    public float speed = 1.5f;

    public Transform ground;

    private void Update()
    {
        ground.Translate(-speed, 0, 0);
    }

    /// <summary>
    /// 地板的移動方法。
    /// </summary>
    private void Move()
    {
        
    }
}
