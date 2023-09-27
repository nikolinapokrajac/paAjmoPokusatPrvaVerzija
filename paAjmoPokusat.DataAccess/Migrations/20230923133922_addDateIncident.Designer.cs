﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using paAjmoPokusat.DataAccess.Data;

#nullable disable

namespace paAjmoPokusat.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230923133922_addDateIncident")]
    partial class addDateIncident
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("paAjmoPokusat.Models.Incident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeadPeopleCount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncidentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("InjuredPeopleCount")
                        .HasColumnType("int");

                    b.Property<int>("MunicipalitieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserNameOfPersonThatAddedIncident")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateIncident")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IncidentTypeId");

                    b.HasIndex("MunicipalitieId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeadPeopleCount = 0,
                            Description = "U 10,50 časova Policijskoj upravi Bijeljina prijavilo je lice D. O. iz Bijeljine, da joj se u Ulici Baje Pivljanina iz putničkog motornog vozila marke ''Golf'', bijele boje, obratilo nepoznato lice, predstavljajući se kao policijski službenik i da je isti tražio da pokaže ličnu kartu. Navedena je tom prilikom, kako je navela, zatražila da joj isti pokaže službenu legitimaciju i da se predstavi kako bi se uvjerila da se radi o policijskom službeniku, nakon čega joj je isti vratio ličnu kartu i udaljio se u nepoznatom pravcu. O događaju je obavješten dežurni tužilac Okružnog javnog tužilaštva Bijeljina koji se izjasnio da se radi  o krivičnom djelu ''Lažno predstavljanje''.",
                            IncidentTypeId = 1,
                            InjuredPeopleCount = 0,
                            MunicipalitieId = 2,
                            Name = "Lažno predstavljanje",
                            UserNameOfPersonThatAddedIncident = "pokrajacnikolina3@gmail.com",
                            dateIncident = new DateTime(2023, 1, 2, 12, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            DeadPeopleCount = 2,
                            Description = "Opis 2.incidenta",
                            IncidentTypeId = 4,
                            InjuredPeopleCount = 4,
                            MunicipalitieId = 2,
                            Name = "Incident br 2",
                            UserNameOfPersonThatAddedIncident = "pokrajacnikolina3@gmail.com",
                            dateIncident = new DateTime(2023, 1, 2, 12, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            DeadPeopleCount = 1,
                            Description = "Opis 3.incidenta",
                            IncidentTypeId = 2,
                            InjuredPeopleCount = 7,
                            MunicipalitieId = 1,
                            Name = "Incident br 3",
                            UserNameOfPersonThatAddedIncident = "pokrajacnikolina3@gmail.com",
                            dateIncident = new DateTime(2022, 5, 5, 12, 12, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("paAjmoPokusat.Models.IncidentImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncidentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IncidentId");

                    b.ToTable("IncidentImages");
                });

            modelBuilder.Entity("paAjmoPokusat.Models.IncidentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IncidentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Nesreće na putevima, sudari vozila, pešaci koji su udareni, oštećenja infrastrukture (npr. srušeni semafori, oštećenja na putu).",
                            ImageUrl = "",
                            Name = "Saobraćajni incidenti"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Poplave, zemljotresi, klizišta, požari, oluje, suše i druge prirodne katastrofe.",
                            ImageUrl = "",
                            Name = "Prirodne nepogode"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Krađe, pljačke, napadi, vandalizam, trgovina drogom, nasilje u porodici, prevara i druge kriminalne aktivnosti.",
                            ImageUrl = "",
                            Name = "Kriminal"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Epidemije, zarazne bolesti, nesreće na radu, trovanja hranom ili vodom, medicinske greške.",
                            ImageUrl = "",
                            Name = "Zdravstveni incidenti"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Teroristički napadi, oružani napadi, pretnje, incidenti vezani za nacionalnu bezbednost.",
                            ImageUrl = "",
                            Name = "Incidenti javne bezbednosti"
                        });
                });

            modelBuilder.Entity("paAjmoPokusat.Models.Municipalitie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipalities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Crepoljsko",
                            Latitude = "43.923302668378604",
                            Longitude = "18.479616005630987",
                            Name = "Istočni Stari Grad",
                            UrlImage = ""
                        },
                        new
                        {
                            Id = 2,
                            Address = "Petra Kočića 2",
                            Latitude = "43.837512769364075",
                            Longitude = "18.400499081072937",
                            Name = "Novi Grad",
                            UrlImage = ""
                        },
                        new
                        {
                            Id = 3,
                            Address = "Romanijska 15",
                            Latitude = "43.81936393519571",
                            Longitude = "18.56738589641413",
                            Name = "Pale",
                            UrlImage = ""
                        });
                });

            modelBuilder.Entity("paAjmoPokusat.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAdress")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("paAjmoPokusat.Models.Incident", b =>
                {
                    b.HasOne("paAjmoPokusat.Models.IncidentType", "IncidentType")
                        .WithMany()
                        .HasForeignKey("IncidentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("paAjmoPokusat.Models.Municipalitie", "Municipalitie")
                        .WithMany()
                        .HasForeignKey("MunicipalitieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IncidentType");

                    b.Navigation("Municipalitie");
                });

            modelBuilder.Entity("paAjmoPokusat.Models.IncidentImage", b =>
                {
                    b.HasOne("paAjmoPokusat.Models.Incident", "Incident")
                        .WithMany("IncidentImages")
                        .HasForeignKey("IncidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incident");
                });

            modelBuilder.Entity("paAjmoPokusat.Models.Incident", b =>
                {
                    b.Navigation("IncidentImages");
                });
#pragma warning restore 612, 618
        }
    }
}