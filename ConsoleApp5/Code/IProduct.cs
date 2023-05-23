namespace ConsoleApp5.Code
{
    public interface IProduct
    {
        Category? Category { get; set; }
        short? CategoryId { get; set; }
        int Discontinued { get; set; }
        ICollection<OrderDetail> OrderDetails { get; set; }
        short ProductId { get; set; }
        string ProductName { get; set; }
        string? QuantityPerUnit { get; set; }
        short? ReorderLevel { get; set; }
        Supplier? Supplier { get; set; }
        short? SupplierId { get; set; }
        float? UnitPrice { get; set; }
        short? UnitsInStock { get; set; }
        short? UnitsOnOrder { get; set; }
    }
}