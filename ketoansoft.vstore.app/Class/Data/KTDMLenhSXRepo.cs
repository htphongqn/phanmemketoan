﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ketoansoft.app.Class.Data
{
    public class KTDMLenhSXRepo
    {
        dbVstoreAppDataContext db = new dbVstoreAppDataContext();

        public virtual KT_DMLenhSX GetById(string id)
        {
            try
            {
                return this.db.KT_DMLenhSXes.Single(u => u.MA_LENH_SX == id);
            }
            catch
            {
                return null;
            }
        }
        public virtual IQueryable GetAll()
        {
            return this.db.KT_DMLenhSXes;
        }
        public virtual void Create(KT_DMLenhSX user)
        {
            try
            {
                this.db.KT_DMLenhSXes.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Update(KT_DMLenhSX user)
        {
            try
            {
                KT_DMLenhSX userOld = this.GetById(user.MA_LENH_SX);
                userOld = user;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public virtual void Remove(string id)
        {
            try
            {
                KT_DMLenhSX user = this.GetById(id);
                this.Remove(user);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Remove(KT_DMLenhSX user)
        {
            try
            {
                db.KT_DMLenhSXes.DeleteOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual int Delete(string id)
        {
            try
            {
                KT_DMLenhSX user = this.GetById(id);
                return this.Delete(user);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public virtual int Delete(KT_DMLenhSX user)
        {
            try
            {
                //user.IsDelete = true;
                db.SubmitChanges();
                return 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}