namespace ConsoleApp5.Code
{
    public interface ICategory
    {
        short CategoryId { get; set; }
        string CategoryName { get; set; }
        string? Description { get; set; }
        byte[]? Picture { get; set; }
        ICollection<Product> Products { get; set; }
    }
}