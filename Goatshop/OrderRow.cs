//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Goatshop
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderRow
    {
        public int Order_ID { get; set; }
        public int Product_ID { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
