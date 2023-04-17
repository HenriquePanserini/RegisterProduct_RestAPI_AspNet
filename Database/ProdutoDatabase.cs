using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Tools;

using RestAPI.Models;

namespace RestAPI.Database{

    public partial class Database : DbContext
    {

        public Database(DbContextOptions<Database> options) : base(options){

        }

        public DbSet<Produto> produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
        }


    }

}
