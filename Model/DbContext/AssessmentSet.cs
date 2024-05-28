using breath_app_core.Model.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace breath_app_core.Model.DbContext {
    public class AssessmentSet : ServiceEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Assessment> Assessments { get; set; }
    }
}
