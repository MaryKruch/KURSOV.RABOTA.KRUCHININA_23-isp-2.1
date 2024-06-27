using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KURSOV.RABOTA.KRUCHININA_23_isp_2._1.Model;

public partial class DatabasekursovContext : DbContext
{
    public DatabasekursovContext()
    {
    }

    public DatabasekursovContext(DbContextOptions<DatabasekursovContext> options)
        : base(options)
    {
    }

    public  DbSet<Decision> Decisions { get; set; }

    public DbSet<Incident> Incidents { get; set; }

    public DbSet<IncidentPerson> IncidentPeople { get; set; }

    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=C:\\Курсовая Кручинина\\KURSOV.RABOTA.KRUCHININA_23-isp-2.1\\KURSOV.RABOTA.KRUCHININA_23-isp-2.1\\bin\\Debug\\net8.0-windows\\databasekursov.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Decision>(entity =>
        {
            entity.Property(e => e.DecisionId)
                .ValueGeneratedNever()
                .HasColumnName("decision_id");
            entity.Property(e => e.CaseNumber).HasColumnName("case_number");
            entity.Property(e => e.DicisionType).HasColumnName("dicision_type");
            entity.Property(e => e.IncidentId).HasColumnName("incident_id");

            entity.HasOne(d => d.Incident).WithMany(p => p.Decisions)
                .HasForeignKey(d => d.IncidentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Incident>(entity =>
        {
            entity.Property(e => e.IncidentId)
                .ValueGeneratedNever()
                .HasColumnName("incident_id");
            entity.Property(e => e.IncidentDescription).HasColumnName("incident_description");
            entity.Property(e => e.RegistrationDate).HasColumnName("registration_date");
        });

        modelBuilder.Entity<IncidentPerson>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IncidentId).HasColumnName("incident_id");
            entity.Property(e => e.PersonId).HasColumnName("person_id");

            entity.HasOne(d => d.Incident).WithMany()
                .HasForeignKey(d => d.IncidentId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Person).WithMany()
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.Property(e => e.PersonId)
                .ValueGeneratedNever()
                .HasColumnName("person_id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CriminalRecord).HasColumnName("criminal_record");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.Surname).HasColumnName("surname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
