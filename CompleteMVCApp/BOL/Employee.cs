namespace BOL; 

 public class Employee{

        public int id{get;set;}
        public string name{get;set;}
        public string email{get;set;}
        public string username{get;set;}
        public string password{get;set;}

        public Employee(int id,string nm,string email,string user,string pass)
        {
            this.id=id;
            this.name=nm;
            this.email=email;
            this.username=user;
            this.password=pass;
        }

    public Employee()
    {
    }
}