using UnityEngine;
// 註解：用來說明紀錄等等.. 只會在此腳本內看到
// 摘要summary：描述此內容，會在其他腳本內看到-提高維護性與擴充性、可讀性
// 新增的C#放在專案內為藍圖
// 放在場景物件上為實體物件
/// <summary>
///  定義汽車物件
/// </summary>

public class Car : MonoBehaviour
{
    // 認識第一個成員:欄位field，儲存物件資料

    // 了解資料類型
    // cc數:2000-可以用整數儲存 int
    // 重量:100.9-可能會有小數點，要用浮點數儲存 float
    // 品牌:BMW-可能有中文或英文，用字串儲存　string
    // 煞車:是否開啟-使用布林值 bool

    // 定義欄位語法:
    // 修飾詞 資料類型 欄位名稱 (指定 值 可省略);
    // 公開 public : 允許其他類別存取，顯示在屬性面板(Inspector)上
    // 私人 private (預設) : 不允許、不顯示
    // 預設值 int float為0
    // string為""
    // bool 為 false
    // 欄位屬性Attribute：Unity 提供用於輔助欄位的功能
    // 語法：[屬性名稱(值)]
    // 標題[Header("字串")]
    // 提示[Tooltip("字串")]
    // 範圍[Range(最小值,最大值)] -只能使用在數值類型的資料 ex: int、float

    /// <summary>
    /// 汽車的cc數
    /// </summary>
    [Header("汽車的cc數"), Tooltip("這個欄位是用來存放汽車的cc數"), Range(500,5000)]
    public int ccCount = 2000; // 對應第13行
    /// <summary>
    /// 汽車的重量
    /// </summary>
    [Header("汽車的重量"),Tooltip("這個欄位是用來存放汽車的噸位"),Range(50.3f,500)]
    public float weight = 100.9f; // 對應第14行
    /// <summary>
    /// 汽車的品牌
    /// </summary>
    [Header("汽車的品牌"),Tooltip("代表這台車子的品牌")]
    public string brand = "BMW"; // 對應第15行
    /// <summary>
    /// 汽車的煞車是否開啟
    /// </summary>
    [Header("汽車的煞車是否開啟"),Tooltip("用來儲存這台車子目前是否為煞車狀態")]
    public bool brake = false; // 對應第16行
}
