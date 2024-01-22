﻿// <auto-generated />
using System;
using Hospital.Shared.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.Shared.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Turkish_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital.Shared.Entities.Doctor", b =>
                {
                    b.Property<int>("WorkerId")
                        .HasColumnType("int")
                        .HasColumnName("WorkerId");

                    b.Property<string>("Dspecialization")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DSpecialization");

                    b.HasKey("WorkerId")
                        .HasName("PK__DOCTOR__077C88265CD93F2F");

                    b.ToTable("DOCTOR", (string)null);
                });

            modelBuilder.Entity("Hospital.Shared.Entities.Nurse", b =>
                {
                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.Property<string>("RoomId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4)")
                        .HasColumnName("RoomID");

                    b.HasKey("WorkerId")
                        .HasName("PK__NURSE__077C8826D2B144E1");

                    b.HasIndex("RoomId");

                    b.ToTable("NURSE", (string)null);
                });

            modelBuilder.Entity("Hospital.Shared.Entities.Patient", b =>
                {
                    b.Property<long>("PnationalIdentificationNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("PNationalIdentificationNumber");

                    b.Property<DateTime>("PbirthDate")
                        .HasColumnType("date")
                        .HasColumnName("PBirthDate");

                    b.Property<string>("Pcity")
                        .HasMaxLength(85)
                        .IsUnicode(false)
                        .HasColumnType("varchar(85)")
                        .HasColumnName("PCity");

                    b.Property<DateTime>("PentryDate")
                        .HasColumnType("date")
                        .HasColumnName("PEntryDate");

                    b.Property<string>("PfirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PFirstName");

                    b.Property<string>("PlastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PLastName");

                    b.Property<int?>("Pnumber")
                        .HasColumnType("int")
                        .HasColumnName("PNumber");

                    b.Property<long?>("PphoneNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("PPhoneNumber");

                    b.Property<string>("PpostCode")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("PPostCode");

                    b.Property<string>("Pstreet")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("PStreet");

                    b.Property<string>("RoomId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4)")
                        .HasColumnName("RoomID");

                    b.Property<int?>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("PnationalIdentificationNumber")
                        .HasName("PK__PATIENT__280816E112055FCA");

                    b.HasIndex("RoomId");

                    b.HasIndex("WorkerId");

                    b.ToTable("PATIENT", (string)null);
                });

            modelBuilder.Entity("Hospital.Shared.Entities.Room", b =>
                {
                    b.Property<string>("RoomId")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4)")
                        .HasColumnName("RoomID");

                    b.Property<int>("Rcapacity")
                        .HasColumnType("int")
                        .HasColumnName("RCapacity");

                    b.Property<string>("Rtype")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("RType");

                    b.HasKey("RoomId");

                    b.ToTable("ROOM", (string)null);
                });

            modelBuilder.Entity("Hospital.Shared.Entities.Worker", b =>
                {
                    b.Property<int>("WorkerId")
                        .HasColumnType("int")
                        .HasColumnName("WorkerId");

                    b.Property<string>("Wcity")
                        .HasMaxLength(85)
                        .IsUnicode(false)
                        .HasColumnType("varchar(85)")
                        .HasColumnName("WCity");

                    b.Property<string>("WfirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("WFirstName");

                    b.Property<string>("WlastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("WLastName");

                    b.Property<int?>("Wnumber")
                        .HasColumnType("int")
                        .HasColumnName("WNumber");

                    b.Property<long>("WphoneNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("WPhoneNumber");

                    b.Property<string>("WpostCode")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("WPostCode");

                    b.Property<string>("Wsex")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("WSex")
                        .IsFixedLength();

                    b.Property<string>("Wstreet")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("WStreet");

                    b.HasKey("WorkerId");

                    b.ToTable("WORKER", (string)null);
                });

            modelBuilder.Entity("Hospital.Shared.Entities.Doctor", b =>
                {
                    b.HasOne("Hospital.Shared.Entities.Worker", "Worker")
                        .WithOne("Doctor")
                        .HasForeignKey("Hospital.Shared.Entities.Doctor", "WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__DOCTOR__WorkerId__286302EC");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("Hospital.Shared.Entities.Nurse", b =>
                {
                    b.HasOne("Hospital.Shared.Entities.Room", "Room")
                        .WithMany("Nurses")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("FK__NURSE__RoomID__33D4B598");

                    b.HasOne("Hospital.Shared.Entities.Worker", "Worker")
                        .WithOne("Nurse")
                        .HasForeignKey("Hospital.Shared.Entities.Nurse", "WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__NURSE__WorkerId__32E0915F");

                    b.Navigation("Room");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("Hospital.Shared.Entities.Patient", b =>
                {
                    b.HasOne("Hospital.Shared.Entities.Room", "Room")
                        .WithMany("Patients")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("FK__PATIENT__RoomID__2E1BDC42");

                    b.HasOne("Hospital.Shared.Entities.Doctor", "Worker")
                        .WithMany("Patients")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("FK__PATIENT__WorkerI__2F10007B");

                    b.Navigation("Room");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("Hospital.Shared.Entities.Doctor", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("Hospital.Shared.Entities.Room", b =>
                {
                    b.Navigation("Nurses");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("Hospital.Shared.Entities.Worker", b =>
                {
                    b.Navigation("Doctor");

                    b.Navigation("Nurse");
                });
#pragma warning restore 612, 618
        }
    }
}
