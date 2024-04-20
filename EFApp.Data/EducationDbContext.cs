using System.Data.Entity;
namespace EFApp.Data
{
    //2
    public class EducationDbContext : DbContext
    {
        //a: configrasyon dosyasında bulunan connectionstring'i Context constructor'ına göndermek
        public EducationDbContext() : base("EducationDbContextLocalConStr")
        {

        }

        //b
        public virtual DbSet<Student> Students { get; set; } //database tablosu ile c# ta bulunan object'in clasın eşleştirilmesi//obje ile tablo eşleştirilmesi
    }
}
