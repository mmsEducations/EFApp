using EFApp.Data;
using System.Collections.Generic;
using System.Linq;
namespace EFApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 Adım 
            EducationDbContext dbContext = new EducationDbContext();
            List<Student> students = dbContext.Students.ToList();//select * from Students ,Öğrenci bilgilerini listeliyoruz
        }
    }
}
