using breath_app_core.Model.BaseEntities;
using BreathApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace breath_app_core.Model.DbContext {
    public class ReservationInfo : ServiceEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        [ForeignKey("CustomerId")]
        public long? CustomerId { get; set; }
        [ForeignKey("TherapystId")]
        public long? TherapystId { get; set; }
        public required int ReservationTypeId { get; set; }
        public virtual Profile? Therapyst { get; set; }
        public virtual Profile? Customer { get; set; }
        public DateTime CreateDate { get; set; }
        public required string RecordStatus { get; set; }
    }
}
