namespace EFApp.Data
{
    //1:Databasedeki tablonun kolonlarının 1'e bir maplanme işlemleri burda yapılır 
    //Database'de bulunan tablonun bir karşılığı 
    public class Student
    {
        public int StudentId { get; set; } //Dbde iligli tabloda bulunan kolonun adı,tipi,null olma durumu 
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int GroupId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
