using breath_app_core.Model.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace breath_app_core.Model.DbContext {
    public class ReservationInfo: ServiceEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ReservationTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public string RecordStatus { get; set; }
    }
}
