﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_rpg.Data;

namespace dotnet_rpg.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200912131308_FinalSeeding")]
    partial class FinalSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Class")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defeats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fights")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Victories")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = 1,
                            Defeats = 0,
                            Defense = 10,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 10,
                            Name = "Frodo",
                            Strength = 15,
                            UserId = 1,
                            Victories = 0
                        },
                        new
                        {
                            Id = 2,
                            Class = 2,
                            Defeats = 0,
                            Defense = 5,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 20,
                            Name = "Raistlin",
                            Strength = 5,
                            UserId = 2,
                            Victories = 0
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.CharacterSkill", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CharacterSkills");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            SkillId = 2
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 1
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 3
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 30,
                            Name = "Fireball"
                        },
                        new
                        {
                            Id = 2,
                            Damage = 20,
                            Name = "Frenzy"
                        },
                        new
                        {
                            Id = 3,
                            Damage = 50,
                            Name = "Blizzard"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("Player");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 76, 113, 67, 63, 173, 141, 47, 228, 23, 179, 116, 32, 48, 135, 183, 214, 102, 188, 82, 78, 163, 180, 235, 104, 189, 199, 123, 71, 213, 183, 38, 181, 114, 166, 95, 186, 249, 88, 36, 30, 254, 253, 162, 83, 138, 77, 89, 26, 212, 236, 138, 138, 10, 151, 48, 21, 112, 93, 37, 184, 38, 5, 206, 97 },
                            PasswordSalt = new byte[] { 19, 224, 172, 96, 132, 205, 211, 46, 214, 76, 25, 51, 112, 164, 61, 244, 97, 107, 229, 30, 125, 10, 190, 220, 179, 64, 58, 146, 21, 156, 132, 246, 87, 243, 243, 245, 93, 209, 159, 150, 251, 178, 51, 121, 141, 159, 184, 153, 38, 242, 13, 144, 219, 182, 232, 102, 197, 169, 137, 164, 185, 15, 219, 107, 234, 117, 206, 162, 43, 82, 37, 86, 153, 180, 38, 120, 107, 197, 3, 69, 199, 203, 181, 227, 167, 55, 43, 125, 147, 203, 78, 113, 217, 144, 61, 210, 190, 125, 196, 37, 51, 63, 95, 22, 15, 245, 101, 203, 225, 98, 190, 50, 47, 43, 151, 19, 216, 31, 24, 216, 26, 234, 11, 21, 160, 35, 198, 167 },
                            Username = "User1"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = new byte[] { 76, 113, 67, 63, 173, 141, 47, 228, 23, 179, 116, 32, 48, 135, 183, 214, 102, 188, 82, 78, 163, 180, 235, 104, 189, 199, 123, 71, 213, 183, 38, 181, 114, 166, 95, 186, 249, 88, 36, 30, 254, 253, 162, 83, 138, 77, 89, 26, 212, 236, 138, 138, 10, 151, 48, 21, 112, 93, 37, 184, 38, 5, 206, 97 },
                            PasswordSalt = new byte[] { 19, 224, 172, 96, 132, 205, 211, 46, 214, 76, 25, 51, 112, 164, 61, 244, 97, 107, 229, 30, 125, 10, 190, 220, 179, 64, 58, 146, 21, 156, 132, 246, 87, 243, 243, 245, 93, 209, 159, 150, 251, 178, 51, 121, 141, 159, 184, 153, 38, 242, 13, 144, 219, 182, 232, 102, 197, 169, 137, 164, 185, 15, 219, 107, 234, 117, 206, 162, 43, 82, 37, 86, 153, 180, 38, 120, 107, 197, 3, 69, 199, 203, 181, 227, 167, 55, 43, 125, 147, 203, 78, 113, 217, 144, 61, 210, 190, 125, 196, 37, 51, 63, 95, 22, 15, 245, 101, 203, 225, 98, 190, 50, 47, 43, 151, 19, 216, 31, 24, 216, 26, 234, 11, 21, 160, 35, 198, 167 },
                            Username = "User2"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Damage = 20,
                            Name = "The Master Sword"
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Damage = 5,
                            Name = "Crystal Wand"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.HasOne("dotnet_rpg.Models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet_rpg.Models.CharacterSkill", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Character", "Character")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet_rpg.Models.Skill", "Skill")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet_rpg.Models.Weapon", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Character", "Character")
                        .WithOne("Weapon")
                        .HasForeignKey("dotnet_rpg.Models.Weapon", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
