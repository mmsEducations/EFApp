using System.Linq;

namespace EFApp.WithUIConsol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EntityDataModel dataModel = new EntityDataModel();
            var students = dataModel.Students.ToList();
            var yusaHocam = students.Where(s => s.Name == "Yuşa ").FirstOrDefault();
            var ozaAkademiGroups = students.Where(s => s.Group.Name == "Ozz Akademi Elit").ToList();
            var yusaGrupName = yusaHocam.Group.Name;
        }
    }
}
