//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dbsys.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDERS
    {
        public int ORD_NUM { get; set; }
        public Nullable<decimal> ORD_AMOUNT { get; set; }
        public Nullable<decimal> ADVANCE_AMOUNT { get; set; }
        public Nullable<System.DateTime> ORD_DATE { get; set; }
        public string CUST_CODE { get; set; }
        public string AGENT_CODE { get; set; }
        public string ORD_DESCRIPTION { get; set; }
    
        public virtual AGENTS AGENTS { get; set; }
        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}
