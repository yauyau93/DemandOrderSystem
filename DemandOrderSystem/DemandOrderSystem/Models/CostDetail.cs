//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemandOrderSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CostDetail
    {
        public Nullable<System.DateTime> CLOSE_DATE { get; set; }
        public string SUBPOENA_NO { get; set; }
        public System.DateTime SUBPOENA_DATE { get; set; }
        public string DEP_UNIT_CODE1 { get; set; }
        public string DEP_UNIT_CODE2 { get; set; }
        public string COST_UNIT_CODE { get; set; }
        public string ACC_CODE { get; set; }
        public string ACC_NAME { get; set; }
        public decimal AMT { get; set; }
        public string ENTRY_TYPE { get; set; }
        public string COST_TYPE_CODE { get; set; }
        public string EXP_APPL_NO { get; set; }
        public string BUG_ITEM_CODE { get; set; }
        public string BUG_ITEM_NAME { get; set; }
        public System.DateTime LAST_UPDATE { get; set; }
    }
}
