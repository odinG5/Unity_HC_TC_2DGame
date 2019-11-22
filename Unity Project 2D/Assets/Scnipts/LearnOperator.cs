using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3;

    public int c = 20, d = 7;

    private void Start()
    {
        #region 數學運算子
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        // = 指定符號，右邊先運算
        a = a + 1;
        print(a);

        print(a++);  // 先輸出 a 在執行遞增
        print(++a);  // 先執行遞增在輸出 a

        a = a + 10;
        a += 10;         // += -= *= /= %=
        print(a);
        #endregion

        #region 比較運算子
        print(c > d);   // true
        print(c < d);   // false
        print(c >= d);  // true
        print(c <= d);  // false
        print(c == d);  // false  等於
        print(c != d);  // true  不等於
        #endregion

        #region 邏輯運算子
        // && 並且 shift + 7
        // 只要有一個 false 結果就是 false
        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);

        // || 或者 shift + 鎮
        // 只要有一個 true 結果就是 true
        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);
        #endregion
    }
}