namespace orbis.iim.core.Models
{
    public class AdvancedFilterDocumentOperatorModel
    {
        public string PropertyName { get; set; }

        public int Operator { get; set; }

        public int Type { get; set; }

        public object FirstValue { get; set; }

        public object SecondValue { get; set; }

        public string Content { get; set; }

        public string ContentLabel { get; set; }
    }
}
