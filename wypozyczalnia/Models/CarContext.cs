namespace wypozyczalnia.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarContext : DbContext
    {
        // Your context has been configured to use a 'Car' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'wypozyczalnia.Models.Car' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Car' 
        // connection string in the application configuration file.
        public CarContext()
            : base("DefaultConnection")
        {
        }

        public static CarContext Create()
        {
            return new CarContext();
        }

        public System.Data.Entity.DbSet<wypozyczalnia.Models.Car> Cars { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

}