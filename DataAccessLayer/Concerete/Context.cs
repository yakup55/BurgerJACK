using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using EntityLayerr.Concerete;
using System.Threading.Tasks;

namespace DataAccessLayer.Concerete
{
    public class Context : DbContext
    {
        public Context(): base("Data Source=MSI;Initial Catalog=BurgerJACK;Integrated Security=True")
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<ChecfsSocialMedia> SocialMedias { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<OurChefs> Chefs { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }

}
