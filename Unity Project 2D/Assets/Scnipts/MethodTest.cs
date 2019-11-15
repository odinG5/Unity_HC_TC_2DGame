using UnityEngine;

public class MethodTest : MonoBehaviour
{
    // 宣告方法 - 定義方法 Method
    // 修飾詞 傳回類型 方法名稱 (參數) { 陳述式、演算法}
    // 參數語法；類型 名稱
    // privare 只有詞類別能使用此方法
    // public

    // 自定方法：不會執行，需要呼叫

    // void 無傳回
    private void Test()
    {
        print("測試方法！");
    }

    // 有回傳方法
    // 傳回類型可以式：int、float、string或bool
    private int Add()
    {
        return 10;  // 傳回方法一定要有關鍵字 return 並且傳回相同類型資料
    }

    private string Hi()
    {
        return "嗨～";
    }

    private void Drive()
    {
        print("引擎聲音");
        print("排氣管特效");
        print("開車，時速：" + 100);
    }

    private void DriveFast()
    {
        print("引擎聲音");
        print("排氣管特效");
        print("開車，時速：" + 1000);
    }

    private void DriveSuperFast()
    {
        print("引擎聲音");
        print("排氣管特效");
        print("開車，時速：" + 10000);
    }

    //                     (參數類型 參數名稱)
    private void DriveMcthod(int speed)
    {
        print("引擎聲音");
        print("排氣管特效");
        print("開車，時速：" + speed);
    }

    //              (參數1，餐素2，參數3 = 預設值)
    /// <summary>
    /// 發射弓箭的方法
    /// </summary>
    /// <param name="count">弓箭數量</param>
    /// <param name="property">弓箭屬性</param>
    /// <param name="direetion">弓箭方向，預設為前方</param>
    private void Shoot(int count, string property, string direetion ="前方")
    {
        print("射箭數量：" + count);
        print("弓箭屬性：" + property);
        print("弓箭方向：" + direetion);
    }

    private void Start()
    {
        // 呼叫方法
        Test();

        // 使用區域欄位存放有傳回整數的整數
        int a = Add();
        print("有傳回方法：" + a);

        // 也可以將有傳回整數的方法當作整數使用
        print("有傳回方法：" + Add());

        print("有傳回字串方法：" + Hi());

        //Drive();
        //DriveFast();
        DriveMcthod(99);
        DriveMcthod(199);

        Shoot(10, "冰凍", "前方");
        Shoot(100, "火焰", "四面八方");
        Shoot(7, "無");
    }
}
