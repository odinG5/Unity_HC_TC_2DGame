//：繼承 規則，可以拿有繼承規則的成員
public class Pipe : Floor
{
    private void Start()
    {
        // 刪除(五遊戲物件，延遲2.5 秒);
        Destroy(gameObject, 5f);
    }
}
