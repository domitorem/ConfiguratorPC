//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConfiguratorPC.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DataStorage
    {
        public int IdComponent { get; set; }
        public short MemorySize { get; set; }
        public decimal Width { get; set; }
        public short Length { get; set; }
        public decimal Thickness { get; set; }
    
        public virtual Component Component { get; set; }
        public virtual HDD HDD { get; set; }
        public virtual SSD SSD { get; set; }
    }
}
