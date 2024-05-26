using breath_app_core.Model.BaseEntities;
using BreathApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace breath_app_core.Model.DbContext;
public class LoginInformation : ServiceEntity {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public long Id { get; set; }
    public required string LoginName { get; set; }
    public required string Password { get; set; }
}