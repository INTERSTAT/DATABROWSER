﻿// <auto-generated />
using System;
using DataBrowser.Entities.SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataBrowser.DB.EFCore.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200608041256_UpdateDev5")]
    partial class UpdateDev5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("DataBrowser.Domain.Entities.Hubs.Hub", b =>
                {
                    b.Property<int>("HubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BackgroundMediaURL")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DecimalNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DecimalSeparator")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefaultLanguage")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefaultView")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DescriptionFk")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmptyCellDefaultValue")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LogoURL")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxCells")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxObservationsAfterCriteria")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SloganFk")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SupportedLanguages")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TitleFk")
                        .HasColumnType("INTEGER");

                    b.HasKey("HubId");

                    b.HasIndex("DescriptionFk")
                        .IsUnique();

                    b.HasIndex("SloganFk")
                        .IsUnique();

                    b.HasIndex("TitleFk")
                        .IsUnique();

                    b.ToTable("Hubs");
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.Nodes.Extra", b =>
                {
                    b.Property<int>("ExtraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NodeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TransatableItemFk")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.Property<string>("ValueType")
                        .HasColumnType("TEXT");

                    b.HasKey("ExtraId");

                    b.HasIndex("NodeId");

                    b.HasIndex("TransatableItemFk")
                        .IsUnique();

                    b.ToTable("Extra");
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.Nodes.Node", b =>
                {
                    b.Property<int>("NodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Agency")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthHttpDomain")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthHttpPassword")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthHttpUsername")
                        .HasColumnType("TEXT");

                    b.Property<string>("BackgroundMediaURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("CatalogNavigationMode")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategorySchemaExcludes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CriteriaSelectionMode")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DecimalNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DecimalSeparatorFk")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Default")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DefaultView")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DescriptionFk")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmptyCellDefaultValue")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EnableHttpAuth")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableProxy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EndPoint")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndPointFormatSupported")
                        .HasColumnType("TEXT");

                    b.Property<string>("LabelDimensionTemporal")
                        .HasColumnType("TEXT");

                    b.Property<string>("LabelDimensionTerritorial")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Logo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProxyAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProxyPassword")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProxyPort")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProxyUsername")
                        .HasColumnType("TEXT");

                    b.Property<int>("ShowCategoryLevels")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowDataflowUncategorized")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SloganFk")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TitleFk")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Ttl")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<bool>("UseProxySystem")
                        .HasColumnType("INTEGER");

                    b.HasKey("NodeId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("DecimalSeparatorFk")
                        .IsUnique();

                    b.HasIndex("DescriptionFk")
                        .IsUnique();

                    b.HasIndex("SloganFk")
                        .IsUnique();

                    b.HasIndex("TitleFk")
                        .IsUnique();

                    b.ToTable("Nodes");
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", b =>
                {
                    b.Property<int>("TransatableItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TransatableItemId");

                    b.ToTable("TransatableItem");
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.TransatableItems.TransatableItemValue", b =>
                {
                    b.Property<int>("TransatableItemFk")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("TransatableItemFk", "Language");

                    b.ToTable("TransatableItemValue");
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.Users.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsSuperAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Settings")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

           
            modelBuilder.Entity("DataBrowser.Domain.Entities.Hubs.Hub", b =>
                {
                    b.HasOne("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", "Description")
                        .WithOne()
                        .HasForeignKey("DataBrowser.Domain.Entities.Hubs.Hub", "DescriptionFk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", "Slogan")
                        .WithOne()
                        .HasForeignKey("DataBrowser.Domain.Entities.Hubs.Hub", "SloganFk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", "Title")
                        .WithOne()
                        .HasForeignKey("DataBrowser.Domain.Entities.Hubs.Hub", "TitleFk")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.Nodes.Extra", b =>
                {
                    b.HasOne("DataBrowser.Domain.Entities.Nodes.Node", null)
                        .WithMany("Extras")
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", "TransatableItem")
                        .WithOne()
                        .HasForeignKey("DataBrowser.Domain.Entities.Nodes.Extra", "TransatableItemFk")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.Nodes.Node", b =>
                {
                    b.HasOne("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", "DecimalSeparator")
                        .WithOne()
                        .HasForeignKey("DataBrowser.Domain.Entities.Nodes.Node", "DecimalSeparatorFk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", "Description")
                        .WithOne()
                        .HasForeignKey("DataBrowser.Domain.Entities.Nodes.Node", "DescriptionFk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", "Slogan")
                        .WithOne()
                        .HasForeignKey("DataBrowser.Domain.Entities.Nodes.Node", "SloganFk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", "Title")
                        .WithOne()
                        .HasForeignKey("DataBrowser.Domain.Entities.Nodes.Node", "TitleFk")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.TransatableItems.TransatableItemValue", b =>
                {
                    b.HasOne("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", "TransatableItem")
                        .WithMany("TransatableItemValues")
                        .HasForeignKey("TransatableItemFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

           
#pragma warning restore 612, 618
        }
    }
}