using DynamicForms.DataProvider.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynamicForms.Models;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;

namespace DynamicForms.DataProvider.Implementation
{
    public class ListDataProvider : IListDataProvider
    {
        private readonly ConnectionStrings _connectionStrings;
        public ListDataProvider(IOptions<ConnectionStrings> options)
        {
            _connectionStrings = options.Value;
        }

        private SqlConnection GetConnection()
        {
            string connectionString = _connectionStrings.DefaultConnection;
            return new SqlConnection(connectionString);
        }

        public Task AddList(ListModel list)
        {
            throw new NotImplementedException();
        }

        public Task DeleteList(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ListModel> GetList(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ListModel>> GetList()
        {
            throw new NotImplementedException();
        }

        public Task UpdateList(ListModel list)
        {
            throw new NotImplementedException();
        }
    }
}
