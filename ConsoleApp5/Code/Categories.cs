using ConsoleApp5;
using ConsoleApp5.Code;

public class Categories
{
    private ICategory _category;

    public Categories(ICategory category)
    {
        _category = category;
    }


    public void AddCategoryToDB()
    {
        using (var db = new NorthwindContext())
        {
            db.Categories.Add(CreateNewCategory());
            db.SaveChanges();
        }
    }

    private Category CreateNewCategory()
    {
        InitialCategory();
        return new Category()
        {
            CategoryName = _category.CategoryName,
            CategoryId = _category.CategoryId,
            Description = _category.Description,
            //     Picture = _category.Picture,
        };
    }

    private void InitialCategory()
    {
        Console.WriteLine("Имя категории = ");

        _category.CategoryName = Console.ReadLine(); ;
        Console.WriteLine("Айди категории = ");

        _category.CategoryId = short.Parse(Console.ReadLine());
        Console.WriteLine("Описание");
        _category.Description = Console.ReadLine();
    }
}
