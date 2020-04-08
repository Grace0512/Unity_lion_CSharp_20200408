using UnityEngine;
// 註解：用來說明紀錄等等.. 只會在此腳本內看到
// 摘要summary：描述此內容，會在其他腳本內看到-提高維護性與擴充性
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
    // 資料類型 欄位名稱 (指定 值 可省略);
    // 預設值 int float為0
    // string為""
    // bool 為 false

    int ccCount = 2000; // 對應第13行
    float weight = 100.9f; // 對應第14行
    string brand = "BMW"; // 對應第15行
    bool brake = false; // 對應第16行
}
