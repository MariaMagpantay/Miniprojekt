﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Reddit_API.Migrations
{
    [DbContext(typeof(TrådContext))]
    [Migration("20221023095525_up og downvote")]
    partial class upogdownvote
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Model.Bruger", b =>
                {
                    b.Property<long>("BrugerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrugerNavn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BrugerID");

                    b.ToTable("Brugerer");
                });

            modelBuilder.Entity("Model.Kommentar", b =>
                {
                    b.Property<long>("KommentarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("BrugerID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Dato")
                        .HasColumnType("TEXT");

                    b.Property<long>("DownVotes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("TrådID")
                        .HasColumnType("INTEGER");

                    b.Property<long>("UpVotes")
                        .HasColumnType("INTEGER");

                    b.HasKey("KommentarID");

                    b.HasIndex("BrugerID");

                    b.HasIndex("TrådID");

                    b.ToTable("Kommentarer");
                });

            modelBuilder.Entity("Model.Tråd", b =>
                {
                    b.Property<long>("TrådID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("BrugerID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Dato")
                        .HasColumnType("TEXT");

                    b.Property<long>("DownVotes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Indhold")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Overskrift")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("UpVotes")
                        .HasColumnType("INTEGER");

                    b.HasKey("TrådID");

                    b.HasIndex("BrugerID");

                    b.ToTable("Tråde");
                });

            modelBuilder.Entity("Model.Kommentar", b =>
                {
                    b.HasOne("Model.Bruger", "Bruger")
                        .WithMany()
                        .HasForeignKey("BrugerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Tråd", null)
                        .WithMany("KommentarListe")
                        .HasForeignKey("TrådID");

                    b.Navigation("Bruger");
                });

            modelBuilder.Entity("Model.Tråd", b =>
                {
                    b.HasOne("Model.Bruger", "Bruger")
                        .WithMany()
                        .HasForeignKey("BrugerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bruger");
                });

            modelBuilder.Entity("Model.Tråd", b =>
                {
                    b.Navigation("KommentarListe");
                });
#pragma warning restore 612, 618
        }
    }
}
