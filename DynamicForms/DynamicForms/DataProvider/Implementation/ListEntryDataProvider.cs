using DynamicForms.DataProvider.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynamicForms.Models;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;

namespace DynamicForms.DataProvider.Implementation
{
    public class ListEntryDataProvider : IListEntryDataProvider
    {
        private readonly ConnectionStrings _connectionStrings;
        public ListEntryDataProvider(IOptions<ConnectionStrings> options)
        {
            _connectionStrings = options.Value;
        }

        private SqlConnection GetConnection()
        {
            string connectionString = _connectionStrings.DefaultConnection;
            return new SqlConnection(connectionString);
        }

        public Task AddListEntry(ListEntryModel listEntry)
        {
            throw new NotImplementedException();
        }

        public Task DeleteListEntry(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ListEntryModel>> GetListEntries()
        {
            throw new NotImplementedException();
        }

        public Task<ListEntryModel> GetListEntry(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateListEntry(ListEntryModel listEntry)
        {
            throw new NotImplementedException();
        }
    }
}
