//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sesion5.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Requests
    {
        public int RequestID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> MedicationID { get; set; }
        public Nullable<int> QuantityRequested { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
    
        public virtual Medications Medications { get; set; }
    }
}
