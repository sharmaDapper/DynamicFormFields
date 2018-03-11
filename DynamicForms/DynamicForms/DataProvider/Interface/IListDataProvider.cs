using DynamicForms.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicForms.DataProvider.Interface
{
    public interface IListDataProvider
    {
        Task AddList(ListModel list);
        Task DeleteList(int id);
        Task<ListModel> GetList(int id);
        Task<IEnumerable<ListModel>> GetList();
        Task UpdateList(ListModel list);
    }
}
