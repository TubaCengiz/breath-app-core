using breath_app_core.Model.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace breath_app_core.Model.DbContext
{
    public class Assessment: ServiceEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int TestSetId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
