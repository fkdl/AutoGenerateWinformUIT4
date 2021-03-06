//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModelLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExecutionLogStorage
    {
        public long LogEntryId { get; set; }
        public string InstanceName { get; set; }
        public Nullable<System.Guid> ReportID { get; set; }
        public string UserName { get; set; }
        public string ExecutionId { get; set; }
        public byte RequestType { get; set; }
        public string Format { get; set; }
        public string Parameters { get; set; }
        public Nullable<byte> ReportAction { get; set; }
        public System.DateTime TimeStart { get; set; }
        public System.DateTime TimeEnd { get; set; }
        public int TimeDataRetrieval { get; set; }
        public int TimeProcessing { get; set; }
        public int TimeRendering { get; set; }
        public byte Source { get; set; }
        public string Status { get; set; }
        public long ByteCount { get; set; }
        public long RowCount { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
