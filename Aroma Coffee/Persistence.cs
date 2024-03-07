using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aroma_Coffee
{
    public class Persistence :  DbContext
    {
        public DbSet<user> user { get; set; }
        public DbSet<kave> kavek { get; set; }
        public Persistence(DbContextOptions<Persistence> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    public class user
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Pass { get; set; }
    }
    public class kave
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        [Required]
        public string user { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public Int32 water { get; set; }
        [Required]
        public Int32 cofe {  get; set; }
        [Required]
        public Int32 choco { get; set; }
        [Required]
        public Int32 sugar { get; set;}
        [Required]
        public Int32 milk { get; set; }
    }
}
