namespace EFApp.WithUIConsol2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StudentPrice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentPriceId { get; set; }

        public int StudentId { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal PaymentAmount { get; set; }

        public virtual Student Student { get; set; }
    }
}
