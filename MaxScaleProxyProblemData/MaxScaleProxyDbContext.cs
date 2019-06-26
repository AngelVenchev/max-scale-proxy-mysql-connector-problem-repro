using Microsoft.EntityFrameworkCore;

namespace MaxScaleProxyProblem
{
    public class MaxScaleProxyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: Add database credentials
            var host = "";
            var username = "";
            var password = "";
            var databaseName = "";
            var connectionString = $"Server={host};User Id={username};Password={password};Database={databaseName}";
            optionsBuilder.UseMySql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var tableName = "click_report";
            builder.Entity<ClickPerformanceReportModel>().ToTable(tableName);
        }

        public DbSet<ClickPerformanceReportModel> ClickPerformanceReports { get; set; }
    }
}
