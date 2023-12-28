namespace BOL;

public class Product
{
    public int id { get;set;}
    public string title{ get;set;}
    public string imageURL{ get;set;}
    public string category{ get;set;}
    public float Price{ get;set;}

    public Product()
    {
         System.Diagnostics.Debug.WriteLine("In Default constructor");
          id=1;
          title="yasir";
          imageURL="sad";
          category="asd";
          Price=23; 
    }

    public Product(int id,string title,string url,string cat,float price)
    {
           System.Diagnostics.Debug.WriteLine("In Para constructor");
        this.id = id;
        this.title = title;
        this.imageURL = url;
        this.category = cat;
        this.Price = price;
    }



}