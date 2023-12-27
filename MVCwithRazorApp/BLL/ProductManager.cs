namespace BLL;

using BOL;
using DAL;
using DAL.Connected;

public class ProductManager
{
    public List<Product> getAllProducts()
    {
        List<Product> plist = new List<Product>();
        plist=DBManager.getAllProducts();
       System.Diagnostics.Debug.WriteLine("SomeText");
        return plist;
    }
}