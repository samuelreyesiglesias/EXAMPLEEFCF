// <auto-generated />
using System;
using EXAMPLEEFCF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EXAMPLEEFCF.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20210806190645_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EXAMPLEEFCF.Models.CarGranTrofeo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ModelCar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VersionOfMeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("VersionOfMeid");

                    b.ToTable("CarGranTrofeo");
                });

            modelBuilder.Entity("EXAMPLEEFCF.Models.VersionOfMe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("VersionOfMe");
                });

            modelBuilder.Entity("EXAMPLEEFCF.Models.CarGranTrofeo", b =>
                {
                    b.HasOne("EXAMPLEEFCF.Models.VersionOfMe", null)
                        .WithMany("CarGranTrofeos")
                        .HasForeignKey("VersionOfMeid");
                });

            modelBuilder.Entity("EXAMPLEEFCF.Models.VersionOfMe", b =>
                {
                    b.Navigation("CarGranTrofeos");
                });
#pragma warning restore 612, 618
        }
    }
}
