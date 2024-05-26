using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using breath_app_core.Model.BaseEntities;

namespace breath_app_core.Model.DbContext {
    public class Contact : ServiceEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
