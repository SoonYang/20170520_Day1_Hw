using System.Collections.Generic;

namespace _20170520_Homework
{
    /// <summary>
    /// 訂單工具
    /// </summary>
    public interface IOrderUtility
    {
        /// <summary>
        /// 取得指定欄位總和
        /// </summary>
        /// <param name="colName">欄位名稱</param>
        /// <param name="groupByNum">每幾筆資料統計為一組</param>
        /// <returns></returns>
        ICollection<int> GetSum(string colName, int groupByNum);
    }
}