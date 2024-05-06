using breath_app_core.Model.DbContext;
using Microsoft.EntityFrameworkCore;

namespace BreathApp.Models;

public class BreathContext : DbContext {
    public BreathContext(DbContextOptions<BreathContext> options) : base(GetOptions()) {
    }

    private static DbContextOptions GetOptions() {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var connectionString = config["ConnectionStrings:ReservationDbConnection"];
        var options = new DbContextOptionsBuilder();
        options.UseSqlServer(connectionString);
        return options.Options;
    }

    public DbSet<LoginInformation> LoginInformations { get; set; } = null!;
    public DbSet<Profile> Profiles { get; set; } = null!;
    public DbSet<Contact> Contacts { get; set; } = null!;
    public DbSet<AssessmentSet> AssessmentSets { get; set; } = null!;
    public DbSet<Assessment> Assessments { get; set; } = null!;
    public DbSet<AssessmentResult> AssessmentResults { get; set; } = null!;
    public DbSet<ReservationItem> ReservationItems { get; set; } = null!;
    public DbSet<ReservationType> ReservationTypes { get; set; } = null!;
    public DbSet<ReservationInfo> ReservationInfos { get; set; } = null!;
    public DbSet<PaymentInformation> PaymentInformations { get; set; } = null!;
}