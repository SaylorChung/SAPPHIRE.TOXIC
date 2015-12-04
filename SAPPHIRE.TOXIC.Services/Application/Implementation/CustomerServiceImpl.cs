using SAPPHIRE.TOXIC.Services.Models;
using System.Collections.Generic;

namespace SAPPHIRE.TOXIC.Services.Application
{
    /// <summary>
    ///     标识对“客户信息”操作相关的应用服务
    /// </summary>
    public class CustomerServiceImpl : ICustomerService
    {
        private readonly SAPPHIREDbContext _context;

        public CustomerServiceImpl(SAPPHIREDbContext context)
        {
            _context = context;
        }
        /// <summary>
        ///     获取所有的客户列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers;
        }
    }
}
