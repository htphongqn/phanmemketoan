using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ketoansoft.app.Class.Data
{
    public class KTBANGLUONGRepo
    {
        dbVstoreAppDataContext db = new dbVstoreAppDataContext();

        public virtual KT_BANG_LUONG GetById(int id)
        {
            try
            {
                return this.db.KT_BANG_LUONGs.Single(u => u.ID == id);
            }
            catch
            {
                return null;
            }
        }
        public virtual IQueryable GetAll()
        {
            return this.db.KT_BANG_LUONGs;
        }
        public virtual void Create(KT_BANG_LUONG user)
        {
            try
            {
                this.db.KT_BANG_LUONGs.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Update(KT_BANG_LUONG user)
        {
            try
            {
                KT_BANG_LUONG userOld = this.GetById(user.ID);
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
                KT_BANG_LUONG user = this.GetById(id);
                this.Remove(user);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Remove(KT_BANG_LUONG user)
        {
            try
            {
                db.KT_BANG_LUONGs.DeleteOnSubmit(user);
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
                KT_BANG_LUONG user = this.GetById(id);
                return this.Delete(user);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public virtual int Delete(KT_BANG_LUONG user)
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
