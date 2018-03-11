namespace DynamicForms.Models
{
    public class ListValueModel
    {
        public int Id { get; set; }
        public int ListEntryId  { get; set; }
        public int ListFieldId { get; set; }
        public string Value { get; set; }
        public bool IsDeleted { get; set; }
    }
}
