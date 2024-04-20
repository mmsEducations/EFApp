namespace EFApp.Data
{
    //1:Databasedeki tablonun kolonlarının 1'e bir maplanme işlemleri burda yapılır 
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int GroupId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
