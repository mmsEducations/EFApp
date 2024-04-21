namespace EFApp.WithUIConsol2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Attendancy
    {
        [Key]
        public int AttendanceId { get; set; }

        public int StudentId { get; set; }

        public DateTime Creadate { get; set; }

        public virtual Student Student { get; set; }
    }
}
