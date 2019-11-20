﻿using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("分數")]
    public int score;
    [Header("最佳分數")]
    public int scoreHeight;
    [Header("水管群組")]
    public GameObject pipe; //GameOject 可以存場景上的物件也可以存專案內的預製物

    /// <summary>
    /// 加分
    /// </summary>
    /// <param name="add">要田家分數，預設為</param>
    private void AddScore(int add = 1)
    {

    }

    /// <summary>
    /// 設定最佳分數
    /// </summary>
    private void SetHeightScore()
    {

    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    private void GaneOver()
    {

    }

    /// <summary>
    /// 生成水管的方式
    /// </summary>
    private void SpawnPipe()
    {
        // 三維向量 = new 三維向量(x, y, z);
        //Vector3 p = new Vector3(6, Random.Range(-0.7f, 1.3f), 0);

        float r = Random.Range(-0.7f, 1.3f);
        Vector3 p = new Vector3(6, r, 0);

        
        // Quaternion.identity 零角度

        // 實例化 - 生成(物件)
        Instantiate(pipe, p, Quaternion.identity);
    }

    private void Start()
    {
        //SpawnPipe();
        // 延遲調用("方法名稱"，延遲時間)
        // Invoke("SpawnPipe", 1.5f);
        // 延遲重複調用("方法名稱" 延遲時間，重複頻率);
        InvokeRepeating("SpawnPipe", 0, 1.8f);
    }
}
