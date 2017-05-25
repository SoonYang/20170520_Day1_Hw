using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _20170520_Homework
{
    public class StatisticUtility<T> : IStatisticUtility<T>
    {
        /// <summary>
        /// 來源
        /// </summary>
        private IEnumerable<T> _source;

        /// <summary>
        /// 設定來源
        /// </summary>
        /// <param name="source"></param>
        public void SetSource(IEnumerable<T> source)
        {
            _source = source;
        }

        /// <summary>
        /// 取得指定欄位總和
        /// </summary>
        /// <param name="predicate">欄位條件</param>
        /// <param name="groupByNum">每幾筆資料統計為一組</param>
        /// <returns></returns>
        public IEnumerable<decimal> GetSum(Func<T, object> predicate, int groupByNum)
        {
            var records = _source           // might throw argument null exception
                .Select(predicate)
                .Select(r =>
                    Convert.ToDecimal(r)    // might throw not decimal exception
                );

            Func<IEnumerable<decimal>, int, int, decimal> Calulate
                = (s, skip, take) =>
            {
                return s.Skip(skip).Take(take).Sum();
            };

            var pos = 0;

            while (pos < records.Count())
            {
                yield return Calulate(records, pos, groupByNum);
                pos += groupByNum;
            }
        }
    }
}
