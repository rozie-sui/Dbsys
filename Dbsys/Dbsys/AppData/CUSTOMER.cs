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
    
    public partial class CUSTOMER
    {
        public CUSTOMER()
        {
            this.ORDERS = new HashSet<ORDERS>();
        }
    
        public string CUST_CODE { get; set; }
        public string CUST_NAME { get; set; }
        public string CUST_CITY { get; set; }
        public string WORKING_AREA { get; set; }
        public string CUST_COUNTRY { get; set; }
        public Nullable<int> GRADE { get; set; }
        public Nullable<decimal> OPENING_AMT { get; set; }
        public Nullable<decimal> RECEIVE_AMT { get; set; }
        public Nullable<decimal> PAYMENT_AMT { get; set; }
        public Nullable<decimal> OUTSTANDING_AMT { get; set; }
        public string PHONE_NO { get; set; }
        public string AGENT_CODE { get; set; }
    
        public virtual AGENTS AGENTS { get; set; }
        public virtual ICollection<ORDERS> ORDERS { get; set; }
    }
}
