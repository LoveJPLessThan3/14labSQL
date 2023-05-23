using ConsoleApp5;
using ConsoleApp5.Code;
//Scaffold-DbContext "Host=localhost;Port=5432;Database=northwind;Username=postgres;Password=1"
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Npgsql.EntityFrameworkCore.PostgreSQL
public class Products
{
    private IProduct _product;

    public Products(IProduct product)
    {
        _product = product;
    }

    public void AddProductToDb()
    {
        using (var db = new NorthwindContext())
        {
            db.Products.Add(CreateNewCategory());
            db.SaveChanges();
        }
    }

    private Product CreateNewCategory()
    {
        InitialCategory();
        return new Product()
        {
            ProductId = _product.ProductId,
            ProductName = _product.ProductName,
            SupplierId = _product.SupplierId,
            CategoryId = _product.CategoryId,
            QuantityPerUnit = _product.QuantityPerUnit,
            UnitPrice = _product.UnitPrice,
            UnitsInStock = _product.UnitsInStock,
            UnitsOnOrder = _product.UnitsOnOrder,
            ReorderLevel = _product.ReorderLevel,
            Discontinued = _product.Discontinued
        };
    }

    private void InitialCategory()
    {
        Console.WriteLine("ProductId =");
        _product.ProductId = short.Parse(Console.ReadLine());
        Console.WriteLine("ProductName =");
        _product.ProductName = Console.ReadLine();
        Console.WriteLine("SupplierId =");
        _product.SupplierId = short.Parse(Console.ReadLine());
        Console.WriteLine("CategoryId =");
        _product.CategoryId = short.Parse(Console.ReadLine());
        Console.WriteLine("QuantityPerUnit =");
        _product.QuantityPerUnit = Console.ReadLine();
        Console.WriteLine("UnitPrice =");
        _product.UnitPrice = float.Parse(Console.ReadLine());
        Console.WriteLine("UnitsInStock =");
        _product.UnitsInStock = short.Parse(Console.ReadLine());
        Console.WriteLine("UnitsOnOrder =");
        _product.UnitsOnOrder = short.Parse(Console.ReadLine());
        Console.WriteLine("ReorderLevel =");
        _product.ReorderLevel = short.Parse(Console.ReadLine());
        Console.WriteLine("Discontinued =");
        _product.Discontinued = int.Parse(Console.ReadLine());

    }
    public void DeleteProductFromDb(int productId)
    {
        using (var db = new NorthwindContext())
        {
            try
            {
                db.Products.Remove(DeleteProduct(db, productId));
                db.SaveChanges();
            }
            catch
            {
                Console.WriteLine("такого id несуществует");
            }
        }
    }
    private Product? DeleteProduct(NorthwindContext db, int productId)
    {
        var product = db.Products.FirstOrDefault(x => x.ProductId == productId);
        if (product == null)
            return null;
        else return product;
    }


    public void SearchProductsFromDb(int? categoryId = null, string? productName = null, int? unitsInStocks = null)
    {
        using (var db = new NorthwindContext())
        {
            var productsSearch =
                db.Products.Where
                (product =>
                product.CategoryId == categoryId ||
                product.ProductName == productName ||
                product.UnitsInStock == unitsInStocks);

            foreach (var product in productsSearch)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }

}
