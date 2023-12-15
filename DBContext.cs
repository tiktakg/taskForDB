using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace taskForDB
{
    internal class DBContext : DbContext
    {
        public DbSet<Models> models { get; set; } = null;
        public DbSet<Orders> orders { get; set; } = null;
        public DbSet<User> user { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=TikTak;Initial Catalog=Bonten;Integrated Security=True;Trust Server Certificate=True");
        }
    }

    public class Models
    {
        [Key]
        public int id_models { get; set; }
        public string name { get; set; }
        public string max_time { get; set; }
        public int speed { get; set; }
        public int number_passengers { get; set; }
        public float max_baggage { get; set; }
        public float price { get; set; }
        public string foto { get; set; }

    }

    public class Orders
    {
        [Key]
        public int id_orders { get; set; }
        public int id_users { get; set; }
        public int id_models { get; set; }
        public string payment {  get; set; }
        public string status {  get; set; }
        public string comment {  get; set; }
        public float total_coast {  get; set; }
    }

    public class User
    {
        [Key]
        public int id_users { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
