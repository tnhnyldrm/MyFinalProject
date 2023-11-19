using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//Data Transformation Object
ProductTest();
//IoC
//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.CategoryName + "/" + product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}