//：繼承 規則，可以拿有繼承規則的成員
public class Pipe : Floor
{
    private void Start()
    {
        // 刪除(五遊戲物件，延遲2.5 秒);
        
    }

    // 在所有攝影機看不到時執行一次
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 5f);
    }

    // 在所有攝影機看到時執行一次
    private void OnBecameVisible()
    {

    }
}
