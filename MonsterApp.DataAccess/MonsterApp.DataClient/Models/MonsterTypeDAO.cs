﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MonsterApp.DataClient.Models
{
   [DataContract]
   public class MonsterTypeDAO
   {
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public string name { get; set; }
   }
}