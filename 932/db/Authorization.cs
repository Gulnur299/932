//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _932.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Authorization
    {
        public int id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int id_role { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
