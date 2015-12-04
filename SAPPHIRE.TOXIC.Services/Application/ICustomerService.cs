using SAPPHIRE.TOXIC.Services.Models;
using System.Collections.Generic;

namespace SAPPHIRE.TOXIC.Services.Application
{
    /// <summary>
    ///     标识对“客户信息”操作相关的服务接口
    /// </summary>
    public interface ICustomerService
    {
        /// <summary>
        ///     获取所有的客户列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customer> GetAllCustomers();
    }
}
