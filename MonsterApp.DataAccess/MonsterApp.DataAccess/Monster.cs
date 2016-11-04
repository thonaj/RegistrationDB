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
    
    public partial class Monster
    {
        public int MonsterId { get; set; }
        public Nullable<int> GenderId { get; set; }
        public Nullable<int> TitleId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public bool Active { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual MonsterType MonsterType { get; set; }
        public virtual Title Title { get; set; }
    }
}
