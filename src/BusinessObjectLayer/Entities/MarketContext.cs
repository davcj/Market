using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusinessObjectLayer.Entities
{
    public partial class MarketContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=93.103.42.32;Initial Catalog=Market;Persist Security Info=True;User ID=market;Password=market1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex");

                entity.Property(e => e.Id).HasMaxLength(450);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PK_AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(450);

                entity.Property(e => e.ProviderKey).HasMaxLength(450);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserRoles_UserId");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.RoleId).HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PK_AspNetUserTokens");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.LoginProvider).HasMaxLength(450);

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(450);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AssetBalance>(entity =>
            {
                entity.HasKey(e => e.IdAssetBalance)
                    .HasName("PK_ASSETBALANCE");

                entity.HasIndex(e => e.IdTrader)
                    .HasName("Relationship_11_FK");

                entity.Property(e => e.IdAssetBalance).HasColumnName("Id_AssetBalance");

                entity.Property(e => e.Balance).HasColumnType("decimal");

                entity.Property(e => e.FrozenBalance).HasColumnType("decimal");

                entity.Property(e => e.IdTrader).HasColumnName("Id_Trader");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.SaveDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdTraderNavigation)
                    .WithMany(p => p.AssetBalance)
                    .HasForeignKey(d => d.IdTrader)
                    .HasConstraintName("FK_ASSETBAL_RELATIONS_TRADER");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("PK_CATEGORY");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("Id_Category")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder)
                    .HasName("PK_ORDER");

                entity.HasIndex(e => e.IdTraderA)
                    .HasName("Relationship_6_FK");

                entity.HasIndex(e => e.IdTraderB)
                    .HasName("Relationship_7_FK");

                entity.HasIndex(e => e.IdTradingObject)
                    .HasName("Relationship_5_FK");

                entity.Property(e => e.IdOrder).HasColumnName("Id_Order");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.IdOfferAssetType).HasColumnName("Id_OfferAssetType");

                entity.Property(e => e.IdOrderStatus).HasColumnName("Id_OrderStatus");

                entity.Property(e => e.IdOrderType).HasColumnName("Id_OrderType");

                entity.Property(e => e.IdOriginalOrder).HasColumnName("Id_OriginalOrder");

                entity.Property(e => e.IdStopLossOrder).HasColumnName("Id_StopLossOrder");

                entity.Property(e => e.IdTakeProfitOrder).HasColumnName("Id_TakeProfitOrder");

                entity.Property(e => e.IdTraderA).HasColumnName("Id_TraderA");

                entity.Property(e => e.IdTraderB).HasColumnName("Id_TraderB");

                entity.Property(e => e.IdTradingObject).HasColumnName("Id_TradingObject");

                entity.Property(e => e.IdWantAssetType).HasColumnName("Id_WantAssetType");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SaveDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdTraderANavigation)
                    .WithMany(p => p.OrderIdTraderANavigation)
                    .HasForeignKey(d => d.IdTraderA)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ORDER_RELATIONS_TRADER2");

                entity.HasOne(d => d.IdTraderBNavigation)
                    .WithMany(p => p.OrderIdTraderBNavigation)
                    .HasForeignKey(d => d.IdTraderB)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ORDER_RELATIONS_TRADER");

                entity.HasOne(d => d.IdTradingObjectNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.IdTradingObject)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ORDER_RELATIONS_TRADINGO");
            });

            modelBuilder.Entity<OrderStatusHistory>(entity =>
            {
                entity.HasKey(e => e.IdOrderStatusHistory)
                    .HasName("PK_ORDERSTATUSHISTORY");

                entity.Property(e => e.IdOrderStatusHistory).HasColumnName("Id_OrderStatusHistory");

                entity.Property(e => e.IdOrder1).HasColumnName("Id_Order_1");

                entity.Property(e => e.IdOrderStatus1).HasColumnName("Id_OrderStatus_1");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.SaveDate).HasColumnType("datetime");

                entity.Property(e => e.StatusUpdatedBy).HasColumnType("text");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SocialMedia>(entity =>
            {
                entity.HasKey(e => e.IdSocialMedia)
                    .HasName("PK_SOCIALMEDIA");

                entity.HasIndex(e => e.IdSocialMediaType)
                    .HasName("Relationship_1_FK");

                entity.HasIndex(e => e.IdTradingObject)
                    .HasName("Relationship_8_FK");

                entity.Property(e => e.IdSocialMedia).HasColumnName("Id_SocialMedia");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdSocialMediaType).HasColumnName("Id_SocialMediaType");

                entity.Property(e => e.IdTradingObject).HasColumnName("Id_TradingObject");

                entity.Property(e => e.UserName).HasColumnType("text");

                entity.HasOne(d => d.IdSocialMediaTypeNavigation)
                    .WithMany(p => p.SocialMedia)
                    .HasForeignKey(d => d.IdSocialMediaType)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SOCIALME_RELATIONS_SOCIALME");

                entity.HasOne(d => d.IdTradingObjectNavigation)
                    .WithMany(p => p.SocialMedia)
                    .HasForeignKey(d => d.IdTradingObject)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SOCIALME_RELATIONS_TRADINGO");
            });

            modelBuilder.Entity<SocialMediaType>(entity =>
            {
                entity.HasKey(e => e.IdSocialMediaType)
                    .HasName("PK_SOCIALMEDIATYPE");

                entity.Property(e => e.IdSocialMediaType).HasColumnName("Id_SocialMediaType");

                entity.Property(e => e.Attr1)
                    .HasColumnName("Attr_1")
                    .HasColumnType("text");

                entity.Property(e => e.Attr2)
                    .HasColumnName("Attr_2")
                    .HasColumnType("text");

                entity.Property(e => e.Attr3)
                    .HasColumnName("Attr_3")
                    .HasColumnType("text");

                entity.Property(e => e.Attr4)
                    .HasColumnName("Attr_4")
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Tick>(entity =>
            {
                entity.HasKey(e => e.IdTick)
                    .HasName("PK_TICK");

                entity.HasIndex(e => e.IdTradingObject)
                    .HasName("Relationship_4_FK");

                entity.Property(e => e.IdTick).HasColumnName("Id_Tick");

                entity.Property(e => e.Buy).HasColumnType("money");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.IdTradingObject).HasColumnName("Id_TradingObject");

                entity.Property(e => e.Sell).HasColumnType("money");

                entity.HasOne(d => d.IdTradingObjectNavigation)
                    .WithMany(p => p.Tick)
                    .HasForeignKey(d => d.IdTradingObject)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TICK_RELATIONS_TRADINGO");
            });

            modelBuilder.Entity<Trader>(entity =>
            {
                entity.HasKey(e => e.IdTrader)
                    .HasName("PK_TRADER");

                entity.HasIndex(e => e.IdAssetType)
                    .HasName("Relationship_9_FK");

                entity.HasIndex(e => e.IdTradingObject)
                    .HasName("Relationship_3_FK");

                entity.Property(e => e.IdTrader).HasColumnName("Id_Trader");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdAssetType).HasColumnName("Id_AssetType");

                entity.Property(e => e.IdLogin)
                    .IsRequired()
                    .HasColumnName("Id_Login")
                    .HasColumnType("text");

                entity.Property(e => e.IdTradingObject).HasColumnName("Id_TradingObject");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SaveDate).HasColumnType("datetime");

                entity.Property(e => e.SecondName)
                    .HasColumnName("Second Name")
                    .HasColumnType("text");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdAssetTypeNavigation)
                    .WithMany(p => p.Trader)
                    .HasForeignKey(d => d.IdAssetType)
                    .HasConstraintName("FK_TRADER_RELATIONS_ASSETBAL");

                entity.HasOne(d => d.IdTradingObjectNavigation)
                    .WithMany(p => p.Trader)
                    .HasForeignKey(d => d.IdTradingObject)
                    .HasConstraintName("FK_TRADER_RELATIONS_TRADINGO");
            });

            modelBuilder.Entity<TradingObject>(entity =>
            {
                entity.HasKey(e => e.IdTradingObject)
                    .HasName("PK_TRADINGOBJECT");

                entity.HasIndex(e => e.IdTrader)
                    .HasName("Relationship_10_FK");

                entity.Property(e => e.IdTradingObject).HasColumnName("Id_TradingObject");

                entity.Property(e => e.IdTrader).HasColumnName("Id_Trader");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdTraderNavigation)
                    .WithMany(p => p.TradingObject)
                    .HasForeignKey(d => d.IdTrader)
                    .HasConstraintName("FK_TRADINGO_RELATIONS_TRADER");
            });

            modelBuilder.Entity<TradingObjectCategory>(entity =>
            {
                entity.HasKey(e => new { e.IdCategory, e.IdTradingObject })
                    .HasName("PK_RELATIONSHIP_10");

                entity.HasIndex(e => e.IdCategory)
                    .HasName("Relationship_10_FK");

                entity.HasIndex(e => e.IdTradingObject)
                    .HasName("Relationship_13_FK");

                entity.Property(e => e.IdCategory).HasColumnName("Id_Category");

                entity.Property(e => e.IdTradingObject).HasColumnName("Id_TradingObject");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.TradingObjectCategory)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RELATION_RELATIONS_CATEGORY");

                entity.HasOne(d => d.IdTradingObjectNavigation)
                    .WithMany(p => p.TradingObjectCategory)
                    .HasForeignKey(d => d.IdTradingObject)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RELATION_RELATIONS_TRADINGO");
            });
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AssetBalance> AssetBalance { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderStatusHistory> OrderStatusHistory { get; set; }
        public virtual DbSet<SocialMedia> SocialMedia { get; set; }
        public virtual DbSet<SocialMediaType> SocialMediaType { get; set; }
        public virtual DbSet<Tick> Tick { get; set; }
        public virtual DbSet<Trader> Trader { get; set; }
        public virtual DbSet<TradingObject> TradingObject { get; set; }
        public virtual DbSet<TradingObjectCategory> TradingObjectCategory { get; set; }
    }
}