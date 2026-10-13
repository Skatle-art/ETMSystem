using System;
using System.Collections.Generic;
using ETMSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ETMSystem.Data;

public partial class ETMSystemContext : DbContext
{
    public ETMSystemContext()
    {
    }

    public ETMSystemContext(DbContextOptions<ETMSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientTravel> ClientTravels { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<ProspectClient> ProspectClients { get; set; }

    public virtual DbSet<Travel> Travels { get; set; }

    public virtual DbSet<TravelPeriodLookup> TravelPeriodLookups { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ETMSystemDB; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__Client__E67E1A04198C22D7");

            entity.ToTable("Client");

            entity.HasIndex(e => e.Email, "UQ__Client__A9D10534B37BB879").IsUnique();

            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClientStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Active");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyContact)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.JobTitle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClientTravel>(entity =>
        {
            entity.HasKey(e => e.ClientTravelId).HasName("PK__ClientTr__DC89F278606F2642");

            entity.ToTable("ClientTravel");

            entity.HasIndex(e => new { e.ClientId, e.TravelId }, "UQ_ClientTravel").IsUnique();

            entity.Property(e => e.ClientTravelId).HasColumnName("ClientTravelID");
            entity.Property(e => e.AvailableStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChosenPeriod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("Early Morning");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.DropOffPoint)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PickupPoint)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDropOffPoint)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReturnPickupPoint)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TravelId).HasColumnName("TravelID");

            entity.HasOne(d => d.Client).WithMany(p => p.ClientTravels)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientTravel_Client");

            entity.HasOne(d => d.Travel).WithMany(p => p.ClientTravels)
                .HasForeignKey(d => d.TravelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientTravel_Travel");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.ContractId).HasName("PK__Contract__C90D3409720DC575");

            entity.ToTable("Contract");

            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.ContractStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DropOffLocation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MonthlyFee).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PickupLocation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TransportPeriod)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_Client");
        });

        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.DriverId).HasName("PK__Driver__F1B1CD24F6E184D2");

            entity.ToTable("Driver");

            entity.HasIndex(e => e.Email, "UQ__Driver__A9D105346C8CE52E").IsUnique();

            entity.Property(e => e.DriverId).HasColumnName("DriverID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyContact)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmploymentStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProspectClient>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__Prospect__E67E1A046CB7C0A3");

            entity.ToTable("ProspectClient");

            entity.Property(e => e.ClientId)
                .ValueGeneratedNever()
                .HasColumnName("ClientID");
            entity.Property(e => e.LeadSource)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReasonNotJoined)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithOne(p => p.ProspectClient)
                .HasForeignKey<ProspectClient>(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectClient_Client");
        });

        modelBuilder.Entity<Travel>(entity =>
        {
            entity.HasKey(e => e.TravelId).HasName("PK__Travel__E9315215F72907FA");

            entity.ToTable("Travel");

            entity.Property(e => e.TravelId).HasColumnName("TravelID");
            entity.Property(e => e.DriverId).HasColumnName("DriverID");
            entity.Property(e => e.NumberOfClients).HasDefaultValue(0);
            entity.Property(e => e.RouteStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TravelPeriodId).HasColumnName("TravelPeriodID");
            entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

            entity.HasOne(d => d.Driver).WithMany(p => p.Travels)
                .HasForeignKey(d => d.DriverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Travel_Driver");

            entity.HasOne(d => d.TravelPeriod).WithMany(p => p.Travels)
                .HasForeignKey(d => d.TravelPeriodId)
                .HasConstraintName("FK_Travel_TravelPeriodLookup");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.Travels)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Travel_Vehicle");
        });

        modelBuilder.Entity<TravelPeriodLookup>(entity =>
        {
            entity.HasKey(e => e.TravelPeriodId).HasName("PK__TravelPe__D417CE83EB6D0E57");

            entity.ToTable("TravelPeriodLookup");

            entity.HasIndex(e => e.PeriodName, "UQ__TravelPe__D748F8F23EFF65A1").IsUnique();

            entity.Property(e => e.TravelPeriodId).HasColumnName("TravelPeriodID");
            entity.Property(e => e.PeriodName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PeriodType)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C137EF832");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E41BF73D5D").IsUnique();

            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.Role).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.UserNavigation).WithOne(p => p.User)
                .HasForeignKey<User>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Client");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleId).HasName("PK__Vehicle__476B54B2625C50F3");

            entity.ToTable("Vehicle");

            entity.HasIndex(e => e.RegistrationNo, "UQ__Vehicle__6EF5E0425A1A9E81").IsUnique();

            entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            entity.Property(e => e.MakeModel)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VehicleStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
