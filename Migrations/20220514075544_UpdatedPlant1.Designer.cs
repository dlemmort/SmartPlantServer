﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartPlantServer.Contexts;

#nullable disable

namespace SmartPlantServer.Migrations
{
    [DbContext(typeof(PlantContext))]
    [Migration("20220514075544_UpdatedPlant1")]
    partial class UpdatedPlant1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SmartPlantServer.Models.Moisture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("MoistureLevels");
                });

            modelBuilder.Entity("SmartPlantServer.Models.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CurrentMoisture")
                        .HasColumnType("int");

                    b.Property<int>("CurrentWaterLevel")
                        .HasColumnType("int");

                    b.Property<int>("MqttId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("SmartPlantServer.Models.WaterLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("WaterLevels");
                });

            modelBuilder.Entity("SmartPlantServer.Models.Moisture", b =>
                {
                    b.HasOne("SmartPlantServer.Models.Plant", "Plant")
                        .WithMany("moistureLevels")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("SmartPlantServer.Models.WaterLevel", b =>
                {
                    b.HasOne("SmartPlantServer.Models.Plant", "Plant")
                        .WithMany("waterLevels")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("SmartPlantServer.Models.Plant", b =>
                {
                    b.Navigation("moistureLevels");

                    b.Navigation("waterLevels");
                });
#pragma warning restore 612, 618
        }
    }
}
