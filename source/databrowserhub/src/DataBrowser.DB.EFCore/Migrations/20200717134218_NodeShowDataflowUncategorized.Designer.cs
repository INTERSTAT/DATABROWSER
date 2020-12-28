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
    [Migration("20200717134218_NodeShowDataflowUncategorized")]
    partial class NodeShowDataflowUncategorized
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

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

                    b.Property<string>("Extras")
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

                    b.Property<bool>("ShowDataflowNotInProduction")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowDataflowUncategorized")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SloganFk")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TitleFk")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TtlCatalog")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TtlDataflow")
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

            modelBuilder.Entity("DataBrowser.Domain.Entities.Users.RefreshToken", b =>
                {
                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Token");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUsersRefreshToken");
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDisable")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSuperAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Settings")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.Users.UserAudit", b =>
                {
                    b.Property<int>("UserAuditId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuditEvent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IpAddress")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserAuditId");

                    b.ToTable("AspNetUsersAudit");
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.View.ViewTemplate", b =>
                {
                    b.Property<int>("ViewTemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BlockAxes")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Criteria")
                        .HasColumnType("TEXT");

                    b.Property<string>("DatasetId")
                        .HasColumnType("TEXT");

                    b.Property<int>("DecimalNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DecimalSeparator")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefaultView")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EnableCriteria")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableVariation")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HiddenDimensions")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Layouts")
                        .HasColumnType("TEXT");

                    b.Property<int>("NodeFK")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TitleFK")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserFK")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ViewTemplateCreationDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ViewTemplateId");

                    b.HasIndex("NodeFK");

                    b.HasIndex("TitleFK")
                        .IsUnique();

                    b.ToTable("ViewTemplates");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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

            modelBuilder.Entity("DataBrowser.Domain.Entities.Users.RefreshToken", b =>
                {
                    b.HasOne("DataBrowser.Domain.Entities.Users.User", null)
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataBrowser.Domain.Entities.View.ViewTemplate", b =>
                {
                    b.HasOne("DataBrowser.Domain.Entities.Nodes.Node", "Node")
                        .WithMany("ViewTemplates")
                        .HasForeignKey("NodeFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBrowser.Domain.Entities.TransatableItems.TransatableItem", "Title")
                        .WithOne()
                        .HasForeignKey("DataBrowser.Domain.Entities.View.ViewTemplate", "TitleFK")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("DataBrowser.Domain.Entities.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("DataBrowser.Domain.Entities.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBrowser.Domain.Entities.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("DataBrowser.Domain.Entities.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
