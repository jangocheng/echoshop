//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class T_UserBaseInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_UserBaseInfo()
        {
            this.F_UId = 10000;
            this.F_UState = true;
            this.DeliveryInfo = new HashSet<DeliveryInfo>();
            this.T_OrderInfo = new HashSet<T_OrderInfo>();
            this.T_Favorites = new HashSet<T_Favorites>();
            this.T_ShoppingCart = new HashSet<T_ShoppingCart>();
        }
    
        public int F_UId { get; set; }
        public string F_UName { get; set; }
        public string F_UPwd { get; set; }
        public bool F_UState { get; set; }
        public System.DateTime F_UCreationDate { get; set; }
    
        public virtual T_UserDetailInfo T_UserDetailInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryInfo> DeliveryInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_OrderInfo> T_OrderInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Favorites> T_Favorites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ShoppingCart> T_ShoppingCart { get; set; }
    }
}
