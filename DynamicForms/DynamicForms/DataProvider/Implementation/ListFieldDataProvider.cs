using System.Collections.Generic;
using System.Threading.Tasks;
using DynamicForms.DataProvider.Interface;
using DynamicForms.Models;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;

namespace DynamicForms.DataProvider.Implementation
{
    public class ListFieldDataProvider : IListFieldDataProvider
    {
        private readonly ConnectionStrings _connectionStrings;
        public ListFieldDataProvider(IOptions<ConnectionStrings> options)
        {
            _connectionStrings = options.Value;
        }

        private SqlConnection GetConnection()
        {
            string connectionString = _connectionStrings.DefaultConnection;
            return new SqlConnection(connectionString);
        }

        public Task AddListField(ListFieldModel listField)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteListField(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ListFieldModel> GetListField(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ListFieldModel>> GetListFields()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateListField(ListFieldModel listField)
        {
            throw new System.NotImplementedException();
        }
    }
}
