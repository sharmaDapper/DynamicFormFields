using DynamicForms.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicForms.DataProvider.Interface
{
    public interface IListFieldDataProvider
    {
        Task AddListField(ListFieldModel listField);
        Task DeleteListField(int id);
        Task<ListFieldModel> GetListField(int id);
        Task<IEnumerable<ListFieldModel>> GetListFields();
        Task UpdateListField(ListFieldModel listField);
    }
}
