namespace DAL;

using System.Collections.Generic;
using BOL;

public class DBManager : IDBManager
{
    public List<Product> GetAll()
    {
        using (var context = new CollectionContext())
        {
            //LINQ
            var products=from Product1 in context.Products select Product1;
            return products.ToList<Product>();
        }
    }

     public Product GetById(int id)
    {
        using (var context = new CollectionContext())
        {
            var product = context.Products.Find(id);
            return product;
        }

    }

    public void Insert(Product prod)
    {
        using (var context = new CollectionContext())
        {
            context.Products.Add(prod);
            context.SaveChanges();
        }
    }

    public void Delete(int id)
    {
        using (var context = new CollectionContext())
        {
            context.Products.Remove(context.Products.Find(id));
            context.SaveChanges();
        }

    }

    public void Update(Product prod)
    {
        using (var context = new CollectionContext())
        {
            var product = context.Products.Find(prod.Id);
            product.Title = prod.Title;
            product.Description = prod.Description;
            product.Price = prod.Price;
            context.SaveChanges();
        }
    }
}