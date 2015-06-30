using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ketoansoft.app.Components.clsVproUtility;
using ketoansoft.app.Class.Global;
using ketoansoft.app.Class.Data;

namespace ketoansoft.app
{
    public partial class SOCTCN11 : Form
    {
        private dbVstoreAppDataContext _db = new dbVstoreAppDataContext(Const.builder.ConnectionString);
        private KT_CTuGocRepo _KT_CTuGocRepo = new KT_CTuGocRepo();
        public SOCTCN11()
        {
            InitializeComponent();
        }

        private void SOCTCN11_Load(object sender, EventArgs e)
        {
            loaddtpNgay();
            cboThang.Text = DateTime.Now.Month.ToString();
        }

        #region process datetime
        private DateTime GetFirstDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
        private DateTime GetFirstDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
        private DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        private DateTime GetLastDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        private void loaddtpNgay()
        {
            dtpTuNgay.Value = GetFirstDayOfMonth(DateTime.Now);
            dtpDenngay.Value = GetLastDayOfMonth(DateTime.Now);
            dtNgayin.Value = DateTime.Now;
        }
        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpTuNgay.Value = GetFirstDayOfMonth(Utils.CIntDef(cboThang.Text, 1));
            dtpDenngay.Value = GetLastDayOfMonth(Utils.CIntDef(cboThang.Text, 1));
        }
        #endregion

        #region btn Click
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("LOAI"), new DataColumn("SO"), new DataColumn("NGAY"), 
                new DataColumn("DIENGIAI"), new DataColumn("TKDU"), new DataColumn("NO"), new DataColumn("CO") });

            _db = new dbVstoreAppDataContext(Const.builder.ConnectionString);
            var list = this._db.KT_CTuGocs.Where(u => u.NGAY_CTU.Value != null && u.NGAY_CTU.Value.Date >= dtpTuNgay.Value.Date && u.NGAY_CTU.Value.Date <= dtpDenngay.Value.Date);
            foreach (var item in list)
            {
                DataRow dr = dt.NewRow();
                dr["LOAI"] = item.MA_CTU;
                dr["SO"] = item.SO_CTU;
                dr["NGAY"] = item.NGAY_CTU;
                dr["DIENGIAI"] = item.DIEN_GIAI;
                dr["TKDU"] = item.TK_CO;
                dr["NO"] = "";
                dr["CO"] = "";
                dt.Rows.Add(dr);
            }
            
            ExcelUtlity Utlity = new ExcelUtlity();
            Utlity.WriteDataTableToExcel_SOCTCN11_Mauchuan(dt);
        }
        #endregion




    }
}
