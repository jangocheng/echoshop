﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EchoShop.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EchoShopModelContainer : DbContext
    {
        public EchoShopModelContainer()
            : base("name=EchoShopModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_UserBaseInfo> T_UserBaseInfoSet { get; set; }
        public virtual DbSet<T_UserDetailInfo> T_UserDetailInfoSet { get; set; }
        public virtual DbSet<DeliveryInfo> DeliveryInfoSet { get; set; }
        public virtual DbSet<T_OrderInfo> T_OrderInfoSet { get; set; }
        public virtual DbSet<T_OrderStatus> T_OrderStatusSet { get; set; }
        public virtual DbSet<T_Category> T_CategorySet { get; set; }
        public virtual DbSet<T_Products> T_ProductsSet { get; set; }
        public virtual DbSet<T_Admin> T_AdminSet { get; set; }
        public virtual DbSet<T_Brand> T_BrandSet { get; set; }
        public virtual DbSet<T_ProductAttr> T_ProductAttrSet { get; set; }
        public virtual DbSet<T_Attributes> T_AttributesSet { get; set; }
        public virtual DbSet<T_AttrValue> T_AttrValueSet { get; set; }
        public virtual DbSet<T_FriendLinks> T_FriendLinksSet { get; set; }
        public virtual DbSet<T_Favorites> T_FavoritesSet { get; set; }
        public virtual DbSet<T_Comment> T_CommentSet { get; set; }
        public virtual DbSet<T_CommentImage> T_CommentImageSet { get; set; }
        public virtual DbSet<T_CarouselFigure> T_CarouselFigureSet { get; set; }
        public virtual DbSet<T_ShoppingCart> T_ShoppingCartSet { get; set; }
    }
}
