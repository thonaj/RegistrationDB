//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonsterApp.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonsterType
    {
        public int MonsterTypeId { get; set; }
        public string TypeName { get; set; }
        public bool Active { get; set; }
    
        public virtual Monster Monster { get; set; }
    }
}
