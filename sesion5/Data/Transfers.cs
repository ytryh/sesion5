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
    
    public partial class Transfers
    {
        public int TransferID { get; set; }
        public Nullable<int> FromWarehouseID { get; set; }
        public Nullable<int> ToWarehouseID { get; set; }
        public Nullable<int> MedicationID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> TransferDate { get; set; }
    
        public virtual Medications Medications { get; set; }
        public virtual Warehouses Warehouses { get; set; }
        public virtual Warehouses Warehouses1 { get; set; }
    }
}
