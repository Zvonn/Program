//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Program
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reports
    {
        public int ReportID { get; set; }
        public string ReportType { get; set; }
        public string Period { get; set; }
        public string ReportData { get; set; }
        public int GeneratedBy { get; set; }
    
        public virtual Passwords Passwords { get; set; }
    }
}
