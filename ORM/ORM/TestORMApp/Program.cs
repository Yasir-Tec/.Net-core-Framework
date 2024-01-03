using System;
using System.Collections.Generic;
using BOL;
using DAL;


Console.WriteLine("Welcome to Swara's Store ");

IDBManager dbm = new DBManager();

bool status = true;
// Console based Menu driven User Interface
while (status)
{
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  All Products");
    Console.WriteLine("2. Insert  new Product");
    Console.WriteLine("3. Update existing Product");
    Console.WriteLine("4. Delete existing Product");
    Console.WriteLine("5. Exit");

    switch (int.Parse(Console.ReadLine()))
    {
        //Display Departments
        case 1:
           
                List<Product> allProducts = dbm.GetAll();

                foreach (var prod in allProducts)
                {
                    Console.WriteLine(" Id: {0}, Title: {1}, Description: {2}, UnitPrice: {3}",
                                        prod.Id, prod.Title, prod.Description, prod.Price);
                }
         
        break;

        case 2:
        
            var newProd = new Product()
            {
                    Id = 2,
                    Title = "Chicken",
                    Description = "i love chicken",
                    Price = 250,
            };
             dbm.Insert(newProd);        
        break;

        case 3:
            
                var updateProd = new Product()
                {
                    Id = 3,
                    Title = "Cold Coffee",
                    Description = "Bevarage",
                    Price = 50
                };
                dbm.Update(updateProd);
            
            break;




        case 4:
            Console.WriteLine("Enter Id:");
            int id = int.Parse(Console.ReadLine());
            dbm.Delete(id);
            break;



        case 5:
            status = false;
            break;

    }

}
