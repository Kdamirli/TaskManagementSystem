//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assignment
    {
        public int id { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<int> dueDate { get; set; }
        public Nullable<bool> implementationMark { get; set; }
        public Nullable<System.DateTime> controlDate { get; set; }
        public string reasonsDefault { get; set; }
        public Nullable<int> project_id { get; set; }
    }
}
