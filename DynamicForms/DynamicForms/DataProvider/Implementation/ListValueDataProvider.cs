using DynamicForms.DataProvider.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynamicForms.Models;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;

namespace DynamicForms.DataProvider.Implementation
{
    public class ListValueDataProvider : IListValueDataProvider
    {
        private readonly ConnectionStrings _connectionStrings;
        public ListValueDataProvider(IOptions<ConnectionStrings> options)
        {
            _connectionStrings = options.Value;
        }

        private SqlConnection GetConnection()
        {
            string connectionString = _connectionStrings.DefaultConnection;
            return new SqlConnection(connectionString);
        }

        public Task AddListValue(ListValueModel listValue)
        {
            throw new NotImplementedException();
        }

        public Task DeleteListValue(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ListValueModel> GetListValue(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ListValueModel>> GetListValues()
        {
            throw new NotImplementedException();
        }

        public Task UpdateListValue(ListValueModel listValue)
        {
            throw new NotImplementedException();
        }
    }
}
