using breath_app_core.Model.BaseEntities;
using breath_app_core.Model.DbContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BreathApp.Models;
public class Profile : ServiceEntity {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public long Id { get; set; }
    public required LoginInformation LoginInformation { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public ProfileType Type { get; set; }
}