using DynamicForms.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicForms.DataProvider.Interface
{
    public interface IListEntryDataProvider
    {
        Task AddListEntry(ListEntryModel listEntry);
        Task DeleteListEntry(int id);
        Task<ListEntryModel> GetListEntry(int id);
        Task<IEnumerable<ListEntryModel>> GetListEntries();
        Task UpdateListEntry(ListEntryModel listEntry);
    }
}
