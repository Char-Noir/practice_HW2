﻿// <auto-generated />
using System;
using HW78.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HW78.Migrations
{
    [DbContext(typeof(ExpensesDbContext))]
    [Migration("20230516125608_MigrationName")]
    partial class MigrationName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HW78.Models.Category", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_category");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategory"));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("is_active")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("IsVisible")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("is_visible")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nchar(64)")
                        .HasColumnName("name_category")
                        .IsFixedLength();

                    b.HasKey("IdCategory");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("HW78.Models.Expense", b =>
                {
                    b.Property<int>("IdExpense")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_expense");

                    b.Property<string>("Commentary")
                        .HasColumnType("text")
                        .HasColumnName("commentary");

                    b.Property<double>("CostExpense")
                        .HasColumnType("float")
                        .HasColumnName("cost_expense");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FkCategory")
                        .HasColumnType("int")
                        .HasColumnName("fk_category");

                    b.Property<bool?>("IsVisible")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("is_visible")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("IdExpense");

                    b.ToTable("Expense", (string)null);
                });

            modelBuilder.Entity("HW78.Models.Expense", b =>
                {
                    b.HasOne("HW78.Models.Category", "IdExpenseNavigation")
                        .WithMany("Expenses")
                        .HasForeignKey("IdExpense")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Expence_Category");

                    b.Navigation("IdExpenseNavigation");
                });

            modelBuilder.Entity("HW78.Models.Category", b =>
                {
                    b.Navigation("Expenses");
                });
#pragma warning restore 612, 618
        }
    }
}
