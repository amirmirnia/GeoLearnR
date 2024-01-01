﻿// <auto-generated />
using System;
using Data.TMU.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.TMU.Migrations
{
    [DbContext(typeof(ContextTMU))]
    [Migration("20231218052335_initial22")]
    partial class initial22
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.TMU.Model.Course.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Lock")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("level")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("minet")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("secend")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Data.TMU.Model.Course.CourseComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAllow")
                        .HasColumnType("bit");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<int>("idC")
                        .HasColumnType("int");

                    b.Property<int>("idU")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idC");

                    b.HasIndex("idU");

                    b.ToTable("courseComments");
                });

            modelBuilder.Entity("Data.TMU.Model.Course.FileCourse", b =>
                {
                    b.Property<int>("IdFC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFC"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdC")
                        .HasColumnType("int");

                    b.Property<bool>("Lock")
                        .HasColumnType("bit");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("file")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hour")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("minet")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("secend")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdFC");

                    b.HasIndex("IdC");

                    b.ToTable("FileCourse");
                });

            modelBuilder.Entity("Data.TMU.Model.Course.UserCourse", b =>
                {
                    b.Property<int>("UCId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UCId"), 1L, 1);

                    b.Property<string>("CodeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("UCId");

                    b.HasIndex("CourseId");

                    b.HasIndex("userid");

                    b.ToTable("UserCourse");
                });

            modelBuilder.Entity("Data.TMU.Model.Gallery.FileGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DescriptionFileGallery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdG")
                        .HasColumnType("int");

                    b.Property<bool>("IsFirst")
                        .HasColumnType("bit");

                    b.Property<string>("PathFile")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TitelFileGallery")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdG");

                    b.ToTable("FileGalleries");
                });

            modelBuilder.Entity("Data.TMU.Model.Gallery.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateGallery")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("View")
                        .HasColumnType("int");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("Data.TMU.Model.Image.ImagePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountView")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DetaPage")
                        .HasColumnType("datetime2");

                    b.Property<string>("PathFile")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("imagePages");
                });

            modelBuilder.Entity("Data.TMU.Model.Menu.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("NameMenu")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Data.TMU.Model.Nav.Navbar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int?>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("TitelNav")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("linkAdres")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("selectnavbar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Navbars");
                });

            modelBuilder.Entity("Data.TMU.Model.News.FileNews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DescriptionFileNews")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdN")
                        .HasColumnType("int");

                    b.Property<bool>("IsFirst")
                        .HasColumnType("bit");

                    b.Property<string>("PathFile")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TitelFileNews")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdN");

                    b.ToTable("FileNews");
                });

            modelBuilder.Entity("Data.TMU.Model.News.News", b =>
                {
                    b.Property<int>("IdNews")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNews"), 1L, 1);

                    b.Property<int?>("CountView")
                        .HasColumnType("int");

                    b.Property<string>("Description1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionNews")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DetaNews")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsSearch")
                        .HasColumnType("bit");

                    b.Property<string>("Mark")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("SubjectNews")
                        .HasMaxLength(180)
                        .HasColumnType("nvarchar(180)");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TitelNews")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNews");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Data.TMU.Model.Page.FilePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DescriptionFilePage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdP")
                        .HasColumnType("int");

                    b.Property<bool>("IsFirst")
                        .HasColumnType("bit");

                    b.Property<string>("PathFile")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TitelFilePage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdP");

                    b.ToTable("FilePages");
                });

            modelBuilder.Entity("Data.TMU.Model.Page.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountView")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DetaNews")
                        .HasColumnType("datetime2");

                    b.Property<string>("TitelPage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Data.TMU.Model.Slider.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DetaSlider")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSlider")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("ShowTitel")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Data.TMU.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ActiveCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CodePerseneli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("IdCode")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNormalUser")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAvatar")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("level")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("post")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Data.TMU.Model.Wallet.Wallet", b =>
                {
                    b.Property<int>("walletid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("walletid"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DetaTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPay")
                        .HasColumnType("bit");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("walletid");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Wallet");
                });

            modelBuilder.Entity("Data.TMU.Model.Wallet.walletType", b =>
                {
                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("Typetitel")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TypeId");

                    b.ToTable("walletType");
                });

            modelBuilder.Entity("Data.TMU.Permissions.permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermissionId"), 1L, 1);

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("PermissionTitel")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PermissionId");

                    b.HasIndex("ParentId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Data.TMU.Permissions.RolePermission", b =>
                {
                    b.Property<int>("RP_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RP_Id"), 1L, 1);

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("RP_Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("Data.TMU.User.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<bool>("Checkout")
                        .HasColumnType("bit");

                    b.Property<bool>("EndProcess")
                        .HasColumnType("bit");

                    b.Property<bool>("Finalapproval")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<bool>("PermissionPrint")
                        .HasColumnType("bit");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Signuchure")
                        .HasColumnType("bit");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Data.TMU.User.UserRole", b =>
                {
                    b.Property<int>("UR_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UR_Id"), 1L, 1);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UR_Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Data.TMU.Model.Course.CourseComment", b =>
                {
                    b.HasOne("Data.TMU.Model.Course.Course", "Course")
                        .WithMany("CourseComment")
                        .HasForeignKey("idC")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.TMU.Model.User", "User")
                        .WithMany("CourseComment")
                        .HasForeignKey("idU")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.TMU.Model.Course.FileCourse", b =>
                {
                    b.HasOne("Data.TMU.Model.Course.Course", "Course")
                        .WithMany("FileCourse")
                        .HasForeignKey("IdC")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Data.TMU.Model.Course.UserCourse", b =>
                {
                    b.HasOne("Data.TMU.Model.Course.Course", "Course")
                        .WithMany("UserCourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.TMU.Model.User", "User")
                        .WithMany("UserCourse")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.TMU.Model.Gallery.FileGallery", b =>
                {
                    b.HasOne("Data.TMU.Model.Gallery.Gallery", "Gallery")
                        .WithMany("FileGalleries")
                        .HasForeignKey("IdG")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Gallery");
                });

            modelBuilder.Entity("Data.TMU.Model.Menu.Menu", b =>
                {
                    b.HasOne("Data.TMU.Model.Menu.Menu", null)
                        .WithMany("Menus")
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("Data.TMU.Model.News.FileNews", b =>
                {
                    b.HasOne("Data.TMU.Model.News.News", "News")
                        .WithMany("FileNews")
                        .HasForeignKey("IdN")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("News");
                });

            modelBuilder.Entity("Data.TMU.Model.Page.FilePage", b =>
                {
                    b.HasOne("Data.TMU.Model.Page.Page", "Page")
                        .WithMany("FilePages")
                        .HasForeignKey("IdP")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Page");
                });

            modelBuilder.Entity("Data.TMU.Model.Wallet.Wallet", b =>
                {
                    b.HasOne("Data.TMU.Model.Wallet.walletType", "walletType")
                        .WithMany("Wallets")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.TMU.Model.User", "User")
                        .WithMany("Wallets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("walletType");
                });

            modelBuilder.Entity("Data.TMU.Permissions.permission", b =>
                {
                    b.HasOne("Data.TMU.Permissions.permission", null)
                        .WithMany("Permissions")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Data.TMU.Permissions.RolePermission", b =>
                {
                    b.HasOne("Data.TMU.Permissions.permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.TMU.User.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Data.TMU.User.UserRole", b =>
                {
                    b.HasOne("Data.TMU.User.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.TMU.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.TMU.Model.Course.Course", b =>
                {
                    b.Navigation("CourseComment");

                    b.Navigation("FileCourse");

                    b.Navigation("UserCourse");
                });

            modelBuilder.Entity("Data.TMU.Model.Gallery.Gallery", b =>
                {
                    b.Navigation("FileGalleries");
                });

            modelBuilder.Entity("Data.TMU.Model.Menu.Menu", b =>
                {
                    b.Navigation("Menus");
                });

            modelBuilder.Entity("Data.TMU.Model.News.News", b =>
                {
                    b.Navigation("FileNews");
                });

            modelBuilder.Entity("Data.TMU.Model.Page.Page", b =>
                {
                    b.Navigation("FilePages");
                });

            modelBuilder.Entity("Data.TMU.Model.User", b =>
                {
                    b.Navigation("CourseComment");

                    b.Navigation("UserCourse");

                    b.Navigation("Wallets");
                });

            modelBuilder.Entity("Data.TMU.Model.Wallet.walletType", b =>
                {
                    b.Navigation("Wallets");
                });

            modelBuilder.Entity("Data.TMU.Permissions.permission", b =>
                {
                    b.Navigation("Permissions");

                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("Data.TMU.User.Role", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}