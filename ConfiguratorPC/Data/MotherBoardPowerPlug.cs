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
    
    public partial class MotherBoardPowerPlug
    {
        public MotherBoardPowerPlug()
        {
            this.MotherBoardPowerConnectors = new HashSet<MotherBoardPowerConnector>();
            this.MotherBoards = new HashSet<MotherBoard>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<MotherBoardPowerConnector> MotherBoardPowerConnectors { get; set; }
        public virtual ICollection<MotherBoard> MotherBoards { get; set; }
    }
}
