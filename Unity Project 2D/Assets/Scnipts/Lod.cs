using UnityEngine;

public class Lod : MonoBehaviour
{
    public int speed = 0;

    
    

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

        
    }

    
}
