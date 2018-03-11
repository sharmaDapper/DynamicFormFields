using DynamicForms.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicForms.DataProvider.Interface
{
    interface IListValueDataProvider
    {
        Task AddListValue(ListValueModel listValue);
        Task DeleteListValue(int id);
        Task<ListValueModel> GetListValue(int id);
        Task<IEnumerable<ListValueModel>> GetListValues();
        Task UpdateListValue(ListValueModel listValue);
    }
}
