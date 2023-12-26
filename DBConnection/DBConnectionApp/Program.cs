// See https://aka.ms/new-console-template for more information

﻿// Entry Poin Main function Code

//dotnet add package MySql.Data

using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to Desktop App");


//Define connection string
//Create connection object
//set connection string to connection object
//defined sql query
//create command object
//Open connection
//Execute Command
//retrived result into DataReader
//iterate data from reader object
//Show data
//Close connection

MySqlConnection conn = new MySqlConnection();
conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac58;password=welcome;database=dac58";
//string query = "select * from cars";
//string query = "update cars set name='f1' where id=2";
Console.WriteLine("Enter id ");
int id = int.Parse(Console.ReadLine());

Console.WriteLine("Enter name");
string name = Console.ReadLine().ToString();

Console.WriteLine("Enter Model");
string model = Console.ReadLine().ToString();



//Parameterized Query


/*string query = "delete from cars where id=@id";
MySqlCommand command = new MySqlCommand(query,conn);
command.Parameters.AddWithValue("@id",id);*/

string query = "insert into cars values(@id,@name,@model)";
MySqlCommand command = new MySqlCommand(query,conn);
command.Parameters.AddWithValue("@id",id);
command.Parameters.AddWithValue("@name",name);
command.Parameters.AddWithValue("@model",model);

try
{
    conn.Open();
    command.ExecuteNonQuery();
    /*MySqlDataReader reader = command.ExecuteReader();
    while(reader.Read())
    {
        int id = int.Parse(reader["id"].ToString());
        string name = reader["name"].ToString();
        string model = reader["model"].ToString();
        Console.WriteLine(id+" "+name+" "+model);
    }*/

}
catch(Exception e)
{
    Console.WriteLine(e);
}
finally
{
    conn.Close();
}



