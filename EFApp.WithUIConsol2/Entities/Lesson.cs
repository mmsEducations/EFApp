namespace EFApp.WithUIConsol2
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Lesson
    {
        public int LessonId { get; set; }

        public int StudentId { get; set; }

        [Required]
        [StringLength(50)]
        public string LessonName { get; set; }

        [NotMapped]
        public DateTime Creadate { get; set; }

        public virtual Student Student { get; set; }
    }
}
