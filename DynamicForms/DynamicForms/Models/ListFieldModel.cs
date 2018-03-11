namespace DynamicForms.Models
{
    public class ListFieldModel
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public string Name { get; set; }
        public int DataType { get; set; }
        public int ColumnOrder { get; set; }
        public bool IsDeleted { get; set; }
    }
}
