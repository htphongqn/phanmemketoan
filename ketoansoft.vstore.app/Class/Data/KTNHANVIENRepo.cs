using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ketoansoft.app.Class.Data
{
    public class KTNHANVIENRepo
    {
        dbVstoreAppDataContext db = new dbVstoreAppDataContext();

        public virtual KT_NHANVIEN GetById(int id)
        {
            try
            {
                return this.db.KT_NHANVIENs.Single(u => u.ID == id);
            }
            catch
            {
                return null;
            }
        }
        public virtual IQueryable GetAll()
        {
            return this.db.KT_NHANVIENs;
        }
        public virtual void Create(KT_NHANVIEN user)
        {
            try
            {
                this.db.KT_NHANVIENs.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Update(KT_NHANVIEN user)
        {
            try
            {
                KT_NHANVIEN userOld = this.GetById(user.ID);
                userOld = user;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public virtual void Remove(int id)
        {
            try
            {
                KT_NHANVIEN user = this.GetById(id);
                this.Remove(user);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Remove(KT_NHANVIEN user)
        {
            try
            {
                db.KT_NHANVIENs.DeleteOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual int Delete(int id)
        {
            try
            {
                KT_NHANVIEN user = this.GetById(id);
                return this.Delete(user);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public virtual int Delete(KT_NHANVIEN user)
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
