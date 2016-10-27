﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
   public class Efdata
   {
      private MonsterDBEntities db = new MonsterDBEntities();
      public List<Gender> GetGenders()
      {
         return db.Genders.ToList();
      }

      public bool InsertGender(Gender gender)
      {
         db.Genders.Add(gender);
         return db.SaveChanges() >0;
      }

      public bool changeGender(Gender gender, EntityState state )
      {
         var entry = db.Entry<Gender>(gender);
         entry.State = EntityState.Added;
         
         return db.SaveChanges() > 0;
      }
      public bool searchGender()
      {
         var actives = db.Genders.Where(a => a.Active);
         var inactives = db.Genders.Where(i => !i.Active);
         var ma = db.Genders.Where(m => m.GenderName.ToLower().Contains("ma".));
      }
   }
}