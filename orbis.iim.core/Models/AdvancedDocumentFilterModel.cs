namespace orbis.iim.core.Models
{
    public class AdvancedDocumentFilterModel
    {
        public int From { get; set; }

        public int Size { get; set; }

        public string IndexName { get; set; }

        public List<AdvancedFilterDocumentOperatorModel> Operators { get; set; }

        public AdvancedDocumentFilterModel()
        {
            Operators = new List<AdvancedFilterDocumentOperatorModel>();
        }
    }
}
