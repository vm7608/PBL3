using System;
using System.Data.Entity;
using System.Linq;
using PBL3.DTO;
namespace PBL3.DAL
{
    public class MyData : DbContext
    {
        // Your context has been configured to use a 'MyData' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DB_PBL3.MyData' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyData' 
        // connection string in the application configuration file.
        public MyData()
            : base("name=MyDBData")
        {
            Database.SetInitializer<MyData>(new CreateDB());

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
    }

}