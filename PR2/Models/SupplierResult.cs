namespace PR2.Models // Убедитесь, что пространство имен соответствует вашему проекту
{
    public class SupplierResult
    {
        public int Id { get; set; }
        public string TypeSupplier { get; set; }
        public string NameSupplier { get; set; }
        public string Inn { get; set; } // ИНН поставщика
        public bool IsActive { get; set; }
        public double AverageQualitySupply { get; set; }
    }
}