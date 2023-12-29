namespace DAL.Connected;

using BOL;
using MySql.Data.MySqlClient;


public class EmpManager
{

    public static void DeleteEmployee(int id)
    {
        Console.WriteLine("inside DAL id"+id);
 
         MySqlConnection conn = new MySqlConnection();
         conn.ConnectionString="server=192.168.10.150;port=3306;user=dac58;password=welcome;database=dac58";
         string query = "delete from employeedata where id=@id";
         try
        {
            MySqlCommand command = new MySqlCommand(query,conn);
            command.Parameters.AddWithValue("@id",id);
         
            conn.Open();
            command.ExecuteNonQuery();
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            conn.Close();
        }
    }
   

    public static string LoginEmployee(string username,string password)
    {
         Console.WriteLine(username+"  in DAL  "+password);
         MySqlConnection conn = new MySqlConnection();
         conn.ConnectionString="server=192.168.10.150;port=3306;user=dac58;password=welcome;database=dac58";
         string query = "select * from employeedata where username=@username and password=@password";
        int flag = 0;
        string name1="";
         try
        {
            MySqlCommand command = new MySqlCommand(query,conn);
            command.Parameters.AddWithValue("@username",username);
            command.Parameters.AddWithValue("@password",password);

            conn.Open();
            
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string username1=reader["username"].ToString();
                string password1=reader["password"].ToString();
                if(username==username1 && password==password1)
                {
                    name1=reader["name"].ToString();
                    flag=1;
                   
                }
            }
            if(flag==1)
            {
                Console.WriteLine("Login Successfull");
                   Console.WriteLine("inside DAL"+name1);
                return name1;
            }
            else
            {
                 Console.WriteLine("Login Failed");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            conn.Close();
        }
        return null;
    }

   public static void RegisterEmployee(int id,string name,string email,string username,string password)
   {
         Console.WriteLine("inside DAL");
         Console.WriteLine(id+" "+name+" "+" "+email+" "+username+" "+password);
         MySqlConnection conn = new MySqlConnection();
         conn.ConnectionString="server=192.168.10.150;port=3306;user=dac58;password=welcome;database=dac58";
         string query = "insert into employeedata values(@id,@name,@email,@username,@password)";
         try
        {
            MySqlCommand command = new MySqlCommand(query,conn);
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@name",name);
            command.Parameters.AddWithValue("@email",email);
            command.Parameters.AddWithValue("@username",username);
            command.Parameters.AddWithValue("@password",password);

            conn.Open();
            command.ExecuteNonQuery();
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            conn.Close();
        }


    }

 
    public static List<Employee> getAllEmployee()
    {

         
         List<Employee> plist = new List<Employee>();
         MySqlConnection conn = new MySqlConnection();
         conn.ConnectionString="server=192.168.10.150;port=3306;user=dac58;password=welcome;database=dac58";
         string query = "select * from employeedata";

         try
         {
            MySqlCommand command = new MySqlCommand(query,conn);
        
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int id1=int.Parse(reader["id"].ToString());
                string name1=reader["name"].ToString();
                string email1=reader["email"].ToString();
                string username1=reader["username"].ToString();
                string password1=reader["password"].ToString();
                Employee emp=new Employee{
                        id=id1,
                        name=name1,
                        email=email1,
                        username=username1,
                        password=password1
                };
              
                plist.Add(emp);
              

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



     public static List<Employee> getEmployeeById(int id)
    {

         Console.WriteLine("DAL"+id);
         List<Employee> plist = new List<Employee>();
         MySqlConnection conn = new MySqlConnection();
         conn.ConnectionString="server=192.168.10.150;port=3306;user=dac58;password=welcome;database=dac58";
         string query = "select * from employeedata where id=@id";

         try
         {
            MySqlCommand command = new MySqlCommand(query,conn);
            command.Parameters.AddWithValue("@id",id);
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int id1=int.Parse(reader["id"].ToString());
                string name1=reader["name"].ToString();
                string email1=reader["email"].ToString();
                string username1=reader["username"].ToString();
                string password1=reader["password"].ToString();
                Employee emp=new Employee{
                        id=id1,
                        name=name1,
                        email=email1,
                        username=username1,
                        password=password1
                };
              
                plist.Add(emp);
              

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


      public static void EditEmployee(int id,string name,string email,string username,string password)
   {
 
         MySqlConnection conn = new MySqlConnection();
         conn.ConnectionString="server=192.168.10.150;port=3306;user=dac58;password=welcome;database=dac58";
         string query = "update employeedata set id=@id,name=@name,email=@email,username=@username,password=@password where id=@id";
         try
        {
            MySqlCommand command = new MySqlCommand(query,conn);
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@name",name);
            command.Parameters.AddWithValue("@email",email);
            command.Parameters.AddWithValue("@username",username);
            command.Parameters.AddWithValue("@password",password);

            conn.Open();
            command.ExecuteNonQuery();
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            conn.Close();
        }


    }




}