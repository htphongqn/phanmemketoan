using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ketoansoft.app.Class.Data
{
    public class KTDMKURepo
    {
        dbVstoreAppDataContext db = new dbVstoreAppDataContext();

        public virtual KT_DMKU GetById(string so_ku, string so_hd, string ma_tk, string ma_dtpn)
        {
            try
            {
                return this.db.KT_DMKUs.Single(u => u.SO_KU == so_ku && u.SO_HD == so_hd && u.MA_TK == ma_tk && u.MA_DTPN == ma_dtpn);
            }
            catch
            {
                return null;
            }
        }
        public virtual IQueryable GetAll()
        {
            return this.db.KT_DMKUs;
        }
        public virtual void Create(KT_DMKU user)
        {
            try
            {
                this.db.KT_DMKUs.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Update(KT_DMKU user)
        {
            try
            {
                KT_DMKU userOld = this.GetById(user.SO_KU, user.SO_HD, user.MA_TK, user.MA_DTPN);
                userOld = user;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Remove(string so_ku, string so_hd, string ma_tk, string ma_dtpn)
        {
            try
            {
                KT_DMKU user = this.GetById(so_ku, so_hd, ma_tk, ma_dtpn);
                this.Remove(user);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual void Remove(KT_DMKU user)
        {
            try
            {
                db.KT_DMKUs.DeleteOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public virtual int Delete(string so_ku, string so_hd, string ma_tk, string ma_dtpn)
        {
            try
            {
                KT_DMKU user = this.GetById(so_ku, so_hd, ma_tk, ma_dtpn);
                return this.Delete(user);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public virtual int Delete(KT_DMKU user)
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
