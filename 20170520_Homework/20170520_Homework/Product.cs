using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170520_Homework
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 商品 ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 成本
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// 利潤
        /// </summary>
        public decimal Revenue { get; set; }

        /// <summary>
        /// 售價
        /// </summary>
        public decimal SellPrice { get; set; }
    }
}
