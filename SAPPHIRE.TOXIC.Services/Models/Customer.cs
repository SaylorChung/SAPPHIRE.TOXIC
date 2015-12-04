using System;

namespace SAPPHIRE.TOXIC.Services.Models
{
    /// <summary>
    ///     客户信息
    /// </summary>
    public class Customer
    {
        /// <summary>
        ///     唯一标识
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        ///     客户姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///     联系电话
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        ///     客户地址
        /// </summary>
        public string Address { get; set; }
    }
}
