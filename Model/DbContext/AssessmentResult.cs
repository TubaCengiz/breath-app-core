using breath_app_core.Model.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace breath_app_core.Model.DbContext {
    public class AssessmentResult: ServiceEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int TestSetId { get; set; }
        public int TestId { get; set; }
        public int CustomerId { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }
    }
}
