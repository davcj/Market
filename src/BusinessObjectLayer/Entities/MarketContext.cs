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
        }

        public virtual DbSet<AssetBalance> AssetBalance { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderStatusHistory> OrderStatusHistory { get; set; }
        public virtual DbSet<SocialMedia> SocialMedia { get; set; }
        public virtual DbSet<SocialMediaType> SocialMediaType { get; set; }
        public virtual DbSet<Tick> Tick { get; set; }
        public virtual DbSet<Trader> Trader { get; set; }
        public virtual DbSet<TradingObject> TradingObject { get; set; }
    }
}