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
    
    public partial class ProjectRiskItem
    {
        public string PrjID { get; set; }
        public string RiskID { get; set; }
        public string RiskIssueOwner { get; set; }
        public Nullable<System.DateTime> RiskDate { get; set; }
        public string RiskDes { get; set; }
        public string RiskImpact { get; set; }
        public Nullable<int> RiskProbability { get; set; }
        public string RiskGrade { get; set; }
        public string RiskCoverage { get; set; }
        public string RiskTime { get; set; }
        public string RiskRule { get; set; }
        public string RiskCountermeasure { get; set; }
        public string RiskOwner { get; set; }
        public string RiskStatus { get; set; }
        public string RiskMemo { get; set; }
        public Nullable<decimal> ImpactValue { get; set; }
    }
}
