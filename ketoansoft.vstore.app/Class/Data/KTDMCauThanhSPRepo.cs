using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ketoansoft.app.Class.Data
{
    public class KTDMCauThanhSPRepo
    {
        dbVstoreAppDataContext db = new dbVstoreAppDataContext();

        public virtual KT_DMCauThanhSP GetById(string idMe, string idCon)
        {
            try
            {
                return this.db.KT_DMCauThanhSPs.Single(u => u.MADM_ME == idMe && u.MADM_CON == idCon);
            }
            catch
            {
                return null;
            }
        }
        public virtual IQueryable GetAll()
        {
            return this.db.KT_DMCauThanhSPs;
        }
        public virtual void Create(KT_DMCauThanhSP user)
        {
            try
            {
                this.db.KT_DMCauThanhSPs.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Update(KT_DMCauThanhSP user)
        {
            try
            {
                KT_DMCauThanhSP userOld = this.GetById(user.MADM_ME, user.MADM_CON);
                userOld = user;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Remove(string idMe, string idCon)
        {
            try
            {
                KT_DMCauThanhSP user = this.GetById(idMe, idCon);
                this.Remove(user);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Remove(KT_DMCauThanhSP user)
        {
            try
            {
                db.KT_DMCauThanhSPs.DeleteOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual int Delete(string idMe, string idCon)
        {
            try
            {
                KT_DMCauThanhSP user = this.GetById(idMe, idCon);
                return this.Delete(user);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public virtual int Delete(KT_DMCauThanhSP user)
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
