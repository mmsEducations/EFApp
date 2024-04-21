using System.Data.Entity;

namespace EFApp.WithUIConsol2
{
    public partial class EntityDataModel : DbContext
    {
        public EntityDataModel()
            : base("name=EducationConnectionstr")
        {
        }

        public virtual DbSet<Attendancy> Attendancies { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<StudentPrice> StudentPrices { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentPrice>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Student>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Attendancies)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Lessons)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentPrices)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
