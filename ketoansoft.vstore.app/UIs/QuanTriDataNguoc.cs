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
using DevExpress.XtraGrid.Columns;

namespace ketoansoft.app.UIs
{
    public partial class QuanTriDataNguoc : Form
    {
        dbVstoreAppDataContext _db = new dbVstoreAppDataContext(Const.builder.ConnectionString);
        private KT_CTuGocRepo _KT_CTuGocRepo = new KT_CTuGocRepo();
        private KTTKRepo _KTTKRepo = new KTTKRepo();
        public QuanTriDataNguoc()
        {
            InitializeComponent();
        }

        #region Data
        private void Load_Data()
        {
            cboThang.Text = Utils.CStrDef(fTerm._month, "");

            DateTime dt = dtpTuNgay.Value;
            dt = new DateTime(dt.Year, Utils.CIntDef(cboThang.Text, 0), 1);
            dtpTuNgay.Value = dt;
            dtpDenNgay.Value = GetLastDayOfMonth(dt);
        }
        private void Load_Grid()
        {
            DateTime ngayBD = DateTime.ParseExact(dtpTuNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime ngayKT = DateTime.ParseExact(dtpDenNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            if (rdo01.Checked)
            {
                lblTitle.Text = String.Format("Xem số dư tài khoản từ ngày {0} đến {1}", dtpTuNgay.Text, dtpDenNgay.Text);
                var obj = _KTTKRepo.GetList();
                if(obj.Count > 0)
                {
                    string[] _fieldName = { "MaTk", "TenTk", "DuNoVnd", "DuCoVnd", "PsNoVnd", "PsCoVnd", "CkNoVnd", "CkCoVnd" };
                    string[] _caption = { "TK", "Tên tài khoản", "Vnd Dư Nợ", "Vnd Dư Có", "Vnd PS Nợ", "Vnd PS Có", "Vnd CK Nợ", "Vnd CK Có" };
                    Set_Field(_fieldName,_caption);
                    DataTable dt = new DataTable();
                    dt.Columns.AddRange(new DataColumn[8] { 
                            new DataColumn(_fieldName[0], typeof(string)),
                            new DataColumn(_fieldName[1], typeof(string)),
                            new DataColumn(_fieldName[2],typeof(double)),
                            new DataColumn(_fieldName[3],typeof(double)),
                            new DataColumn(_fieldName[4],typeof(double)),
                            new DataColumn(_fieldName[5],typeof(double)),
                            new DataColumn(_fieldName[6],typeof(double)),
                            new DataColumn(_fieldName[7],typeof(double))
                        });
                    for (int i = 0; i < obj.Count; i++)
                    {
                        dt.Rows.Add(obj[i].MA_TK, obj[i].TEN_TK
                            , _KT_CTuGocRepo.GetTongByTkNo(String.Format("{0:MM/dd/yyyy}",dtpTuNgay), String.Format("{0:MM/dd/yyyy}",dtpDenNgay), "TK_NO", obj[i].MA_TK), obj[i].VND_DU_CO
                            , obj[i].USD_PS_NO, obj[i].VND_PS_CO, obj[i].VND_CK_NO, obj[i].VND_CK_CO);
                    }
                    gridData1.DataSource = dt;
                }
                //gridData1.DataSource = _KT_CTuGocRepo.GetSoDuPhatSinh(ngayBD, ngayKT);
            }
        }
        #endregion

        #region Funtion
        private static DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        private void Set_Field(string[] _fieldName, string[] _caption)
        {
            if (gridView1.Columns.Count <= 0)
            {
                for (int i = 0; i < _fieldName.Count(); i++)
                {
                    GridColumn column = gridView1.Columns.Add();
                    column.Caption = _caption[i];
                    column.FieldName = _fieldName[i];
                    column.Visible = true;
                }
            }
        }
        #endregion

        #region Event
        private void QuanTriDataNguoc_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpTuNgay.Value;
            dt = new DateTime(dt.Year, Utils.CIntDef(cboThang.Text, 0), 1);
            dtpTuNgay.Value = dt;
            dtpDenNgay.Value = GetLastDayOfMonth(dt);
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Load_Grid();
            tabControl1.SelectedTabIndex = 1;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        
    }
}
