using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace breath_app_core.Model.DbContext {
    public class PaymentInformation {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int ReservationInfoId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public decimal PaymentAmount { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public DateTime CardLastExpireDate { get; set; }
        public string CardCvv { get; set; }
    }
}
