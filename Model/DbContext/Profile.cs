using breath_app_core.Model.BaseEntities;
using breath_app_core.Model.DbContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
namespace BreathApp.Models;
public class Profile : ServiceEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public long Id { get; set; }
    [ForeignKey("LoginInformationId")]
    public required LoginInformation LoginInformation { get; set; }
    [ForeignKey("ContactInformationId")]
    public Contact? ContactInformation { get; set; }
    public long ContactInformationId { get; set; }
    public long LoginInformationId { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public ProfileType Type { get; set; }
}