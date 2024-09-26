using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestNotify.Databases.db;

public partial class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Account { get; set; }

    public virtual DbSet<Notify> Notify { get; set; }

    public virtual DbSet<NotifyAcc> NotifyAcc { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_unicode_520_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("account");

            entity.HasIndex(e => e.Uuid, "uuid_unq").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(8)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasComment("1:Đang hoạt động/0:bị khóa")
                .HasColumnType("int(4)")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedTime)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("updated_time");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .HasDefaultValueSql("uuid()")
                .IsFixedLength()
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<Notify>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("notify");

            entity.HasIndex(e => e.Uuid, "uuid_unq").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(8)")
                .HasColumnName("id");
            entity.Property(e => e.Content)
                .HasMaxLength(255)
                .HasColumnName("content");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasColumnType("tinyint(4)")
                .HasColumnName("type");
            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .HasDefaultValueSql("uuid()")
                .IsFixedLength()
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<NotifyAcc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("notify_acc");

            entity.HasIndex(e => e.AccUuid, "fk_acc_uuid");

            entity.HasIndex(e => e.NotifyUuid, "fk_notify_uuid");

            entity.HasIndex(e => e.Uuid, "uuid_unq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AccUuid)
                .HasMaxLength(36)
                .IsFixedLength()
                .HasColumnName("acc_uuid");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.Data)
                .HasColumnType("json")
                .HasColumnName("data");
            entity.Property(e => e.NotifyUuid)
                .HasMaxLength(36)
                .IsFixedLength()
                .HasColumnName("notify_uuid");
            entity.Property(e => e.State)
                .HasComment("0 - chưa xem /  1- đã xem")
                .HasColumnType("int(4)")
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasComment("1:Đang hoạt động/0:bị khóa")
                .HasColumnType("int(4)")
                .HasColumnName("status");
            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .HasDefaultValueSql("uuid()")
                .IsFixedLength()
                .HasColumnName("uuid");

            entity.HasOne(d => d.AccUu).WithMany(p => p.NotifyAcc)
                .HasPrincipalKey(p => p.Uuid)
                .HasForeignKey(d => d.AccUuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acc_uuid");

            entity.HasOne(d => d.NotifyUu).WithMany(p => p.NotifyAcc)
                .HasPrincipalKey(p => p.Uuid)
                .HasForeignKey(d => d.NotifyUuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_notify_uuid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
