using ConsoleApp5;
using Microsoft.EntityFrameworkCore;

public class Db
{
    public static void Main()
    {
        while (true)
        {
            int desicion;
            Console.WriteLine("Чтобы редактировать Категории, нажмите 1\nЧтобы редактировать Продукты, нажмите 2\nЧтобы выйти нажмите 3");
            desicion = int.Parse(Console.ReadLine());
            if (desicion == 1)
            {
                var category = new Categories(new Category());
                category.AddCategoryToDB();
            }
            else if (desicion == 2)
            {
                Console.WriteLine("Для добавления нового продукта нажмите 1\nДля удаления Продукта, нажмите 2\nДля поиска продукта нажмите 3");

                var product = new Products(new Product());
                desicion = int.Parse(Console.ReadLine());

                if (desicion == 1)
                    product.AddProductToDb();

                else if (desicion == 2)
                    DeleteProductInfo(product);

                else if (desicion == 3)
                    SearchProductIndo(product);

                else
                    Console.WriteLine("Неверный ввод");
            }
            else if (desicion == 3)
                return;
            else Console.WriteLine("Неверный ввод");
    
        }

    }

    private static void DeleteProductInfo(Products product)
    {
        Console.WriteLine("Введите id продукта для удаления");
        int id = int.Parse(Console.ReadLine());

        product.DeleteProductFromDb(productId: id);
    }

    private static void SearchProductIndo(Products product)
    {
        Console.WriteLine("Введите id категории, имя продукта и количество продукта. Можно оставить строку пустой");
        Console.WriteLine("Айди продукта = ");
        int? idProduct = InitialInt();
        Console.WriteLine("Имя продукта = ");
        string? productName = Console.ReadLine();
        Console.WriteLine("Количество продуктов на складе = ");
        int? unitInStocks = InitialInt();
        product.SearchProductsFromDb(idProduct, productName, unitInStocks);
    }

    private static int? InitialInt()
    {
        string x = Console.ReadLine();
        return x == "" ? -1 : int.Parse(x);
    }
}
