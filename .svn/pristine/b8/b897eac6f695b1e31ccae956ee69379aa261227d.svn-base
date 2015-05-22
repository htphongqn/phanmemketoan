using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ketoansoft.app.Class.Data
{
    public class KTDMBHRepo
    {
        dbVstoreAppDataContext db = new dbVstoreAppDataContext();

        public virtual KT_DMBH GetById(string id)
        {
            try
            {
                return this.db.KT_DMBHs.Single(u => u.IMEI == id);
            }
            catch
            {
                return null;
            }
        }
        public virtual IQueryable GetAll()
        {
            return this.db.KT_DMBHs;
        }
        public virtual void Create(KT_DMBH user)
        {
            try
            {
                this.db.KT_DMBHs.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Update(KT_DMBH user)
        {
            try
            {
                KT_DMBH userOld = this.GetById(user.IMEI);
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
                KT_DMBH user = this.GetById(id);
                this.Remove(user);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Remove(KT_DMBH user)
        {
            try
            {
                db.KT_DMBHs.DeleteOnSubmit(user);
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
                KT_DMBH user = this.GetById(id);
                return this.Delete(user);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public virtual int Delete(KT_DMBH user)
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
