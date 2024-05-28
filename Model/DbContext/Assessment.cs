using breath_app_core.Model.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace breath_app_core.Model.DbContext {
    public class Assessment : ServiceEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        [ForeignKey("TestSetId")]
        public required long TestSetId { get; set; }
        public required string Question { get; set; }
        public required string Answer { get; set; }
        public virtual AssessmentSet AssessmentSet{get;set;}
    }
}
