using UnityEngine;

public class Lod : MonoBehaviour
{
    public int speed = 0;

    // 非靜態需要定義欄位，並且在屬性面板上套用動應物件
    public Transform bird;
    public Transform groumd;

    private void Start()
    {
        Debug.Log("一般");
        Debug.LogWarning("警告！");
        Debug.LogError("錯誤！");

        Debug.Log(Mathf.PI);

        // 靜態屬性 static properties
        Debug.Log(Random.value);
        // 靜態方式 static method
        Debug.Log(Random.Range(1, 10));

        // 非靜態屬性用法 properties
        Debug.Log(bird.position);
        Debug.Log(groumd.position);
    }

    // 更新事件：偵測按鍵
    private void Update()
    {
        print(Input.GetKeyDown("mouse 0"));               // 字串取得按鍵
        print(Input.GetKeyDown(KeyCode.Mouse1));          // 列舉取得按鍵
    }

}
