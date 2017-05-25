using System;
using System.Collections.Generic;

namespace _20170520_Homework
{
    /// <summary>
    /// 統計工具
    /// </summary>
    public interface IStatisticUtility<T>
    {
        /// <summary>
        /// 設定來源
        /// </summary>
        /// <param name="source"></param>
        void SetSource(IEnumerable<T> source);

        /// <summary>
        /// 取得指定欄位總和
        /// </summary>
        /// <param name="predicate">欄位條件</param>
        /// <param name="groupByNum">每幾筆資料統計為一組</param>
        /// <returns></returns>
        IEnumerable<decimal> GetSum(Func<T, object> predicate, int groupByNum);
    }
}