namespace ThuongMaiDienTuWebAPI.Dto
{
    public class ProductDto
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string IndoorDimension { get; set; }
        public double IndoorWeight { get; set; }
        public string OutdoorDimension { get; set; }
        public double OutdoorWeight { get; set; }
        public string HeatCapacity { get; set; }
        public string CoolingCapacity { get; set; }
        public int NumbersOfCooling { get; set; }
        public double PowerComsumption { get; set; }
        public string IndoorWarranty { get; set; }
        public string OutdoorWarranty { get; set; }
        public string RealeaseDate { get; set; }
        public int InventoryQuantity { get; set; }
        public double Price { get; set; }
        public string RadiatorMaterial { get; set; }

        public int BrandId { get; set; }
        public string ProductStatus { get; set; }
    }
}
