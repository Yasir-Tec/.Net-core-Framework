namespace DAL.Connected;

using BOL;
using MySql.Data.MySqlClient;


public class DBManager
{
    public static List<Product> getAllProducts()
    {

         System.Diagnostics.Debug.WriteLine("This will be displayed in output window");
         List<Product> plist = new List<Product>();
         MySqlConnection conn = new MySqlConnection();
         conn.ConnectionString="server=192.168.10.150;port=3306;user=dac58;password=welcome;database=dac58";
         string query = "select * from productsdata";

         try
         {
            MySqlCommand command = new MySqlCommand(query,conn);
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int id1=int.Parse(reader["id"].ToString());
                Console.WriteLine(id1);
                string title1=reader["title"].ToString();
                string iurl1=reader["imageurl"].ToString();
                string cat1=reader["category"].ToString();
                int price1=int.Parse(reader["price"].ToString());
                Product p=new Product{
                        id=id1,
                        title=title1,
                        imageURL=iurl1,
                        category=cat1,
                        Price=price1
                };
               System.Diagnostics.Debug.WriteLine("This will be displayed in output window");
                plist.Add(p);
              

            }
         }
         catch(Exception e)
         {
            Console.WriteLine(e.Message);
         }
         finally
         {
            conn.Close();
         }

        return plist;

    }
}