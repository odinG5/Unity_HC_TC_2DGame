using UnityEngine;

public class Learnlt : MonoBehaviour
{
    public bool open;

    public int score;

    public int combo;

    private void Start()
    {
        // 判斷式 if
        // if (布林值) { 當不林值為 true 才執行 }

        if (true)
        {
            print("嗨~");
        }

        // 當布林值為 true 才執行 if {}
        if (open)
        {
            print("開門~");
        }
        // 當布林值為 false 才執行 else{}
        else
        {
            print("關門~");
        }

        if (score >= 60)
        {
            print("及格~");
        }
        else if (score >= 40)
        {
            print("補考");
        }
        else
        {
            print("你被當了！");
        }
    }   

    private void Update()
    {
        if (combo >= 150)
        {
            print("攻擊 * 2");
        }
        else if (combo >= 100)
        {
            print("攻擊 * 5");
        }
        else if (combo >= 50)
        {
            print("攻擊 * 10");
        }
    }
}
