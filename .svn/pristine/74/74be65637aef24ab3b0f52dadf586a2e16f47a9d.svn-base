using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ketoansoft.app.Class.Global;

namespace ketoansoft.app
{
    public partial class fMain : DevComponents.DotNetBar.OfficeForm
    {
        public fMain()
        {
            InitializeComponent();
        }

        #region Form function
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                MessageBox.Show("Bạn phải đóng tất cả form con trước khi đóng form main!", "Thông báo", MessageBoxButtons.OK);
                e.Cancel = true;
            }
            base.OnFormClosing(e);
            if (!e.Cancel)
            {
                if (MessageBox.Show("Bạn có muốn đóng form Main không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region showForm
        private void showForm_CaiThongSo()
        {
            if (Unit.IsFormActived("CaiThongSo")) return;

            CaiThongSo _from = null;
            if (_from == null || _from.IsDisposed)
            {
                _from = new CaiThongSo();
                _from.MdiParent = this;
                _from.Show();
            }
            else
            {
                _from.Activate();
            }
        }
        private void showForm_DanhMucTaiKhoan()
        {
            if (Unit.IsFormActived("DanhMucTaiKhoan")) return;

            DanhMucTaiKhoan _from = null;
            if (_from == null || _from.IsDisposed)
            {
                _from = new DanhMucTaiKhoan();
                _from.MdiParent = this;
                _from.Show();
            }
            else
            {
                _from.Activate();
            }
        }
        private void showForm_DanhMucCacLoaiChungTu()
        {
            if (Unit.IsFormActived("DanhMucCacLoaiChungTu")) return;

            DanhMucCacLoaiChungTu _from = null;
            if (_from == null || _from.IsDisposed)
            {
                _from = new DanhMucCacLoaiChungTu();
                _from.MdiParent = this;
                _from.Show();
            }
            else
            {
                _from.Activate();
            }
        }
        private void showForm_DoiTuongPhapNhan()
        {
            if (Unit.IsFormActived("DoiTuongPhapNhan")) return;

            DoiTuongPhapNhan _from = null;
            if (_from == null || _from.IsDisposed)
            {
                _from = new DoiTuongPhapNhan();
                _from.MdiParent = this;
                _from.Show();
            }
            else
            {
                _from.Activate();
            }
        }
        private void showForm_DanhMucDienGiai()
        {
            if (Unit.IsFormActived("DanhMucDienGiai")) return;

            DanhMucDienGiai _from = null;
            if (_from == null || _from.IsDisposed)
            {
                _from = new DanhMucDienGiai();
                _from.MdiParent = this;
                _from.Show();
            }
            else
            {
                _from.Activate();
            }
        }
        private void showForm_DanhMucCongTrinh()
        {
            if (Unit.IsFormActived("DanhMucCongTrinh")) return;

            DanhMucCongTrinh _from = null;
            if (_from == null || _from.IsDisposed)
            {
                _from = new DanhMucCongTrinh();
                _from.MdiParent = this;
                _from.Show();
            }
            else
            {
                _from.Activate();
            }
        }
        private void showForm_DanhMucKheUoc()
        {
            if (Unit.IsFormActived("DanhMucKheUoc")) return;

            DanhMucKheUoc _from = null;
            if (_from == null || _from.IsDisposed)
            {
                _from = new DanhMucKheUoc();
                _from.MdiParent = this;
                _from.Show();
            }
            else
            {
                _from.Activate();
            }
        }
        private void showForm_DanhMucCauthanhSP()
        {
            if (Unit.IsFormActived("CauThanhSanPham")) return;

            CauThanhSanPham _from = null;
            if (_from == null || _from.IsDisposed)
            {
                _from = new CauThanhSanPham();
                _from.MdiParent = this;
                _from.Show();
            }
            else
            {
                _from.Activate();
            }
        }
        private void showForm(int iform)
        {
            switch (iform) 
            {
                case Const.CAIDATTHONGSO: showForm_CaiThongSo(); break;
                case Const.DANHMUCTAIKHOAN: showForm_DanhMucTaiKhoan(); break;
                case Const.DANHMUCCACLOAICHUNGTU: showForm_DanhMucCacLoaiChungTu(); break;
                case Const.DOITUONGPHAPNHAN: showForm_DoiTuongPhapNhan(); break;
                case Const.DANHMUCDIENGIAI: showForm_DanhMucDienGiai(); break;
                case Const.DANHMUCCACCONGTRINH: showForm_DanhMucCongTrinh(); break;
                case Const.DANHMUCCAUTHANHSANPHAM: showForm_DanhMucCauthanhSP(); break;
                case Const.DANHMUCKHEUOC: showForm_DanhMucKheUoc(); break;
            }
        }
        #endregion

        private void fMain_Load(object sender, EventArgs e)
        {
            try
            {
                showForm(fHome._IdAction);
            }
            catch (Exception) { }
        }
        #region buttonItem Click
        private void btnDanhmuctaikhoan_Click(object sender, EventArgs e)
        {
            showForm_DanhMucTaiKhoan();
        }
        private void btnDanhmuccacloaichungtu_Click(object sender, EventArgs e)
        {
            showForm_DanhMucCacLoaiChungTu();
        }
        private void btnDoituongphapnhan_Click(object sender, EventArgs e)
        {
            showForm_DoiTuongPhapNhan();
        }
        private void btnDanhmucdiengiai_Click(object sender, EventArgs e)
        {
            showForm_DanhMucDienGiai();
        }
        private void btnDanhmuccongtrinh_Click(object sender, EventArgs e)
        {
            showForm_DanhMucCongTrinh();
        }
        private void btnDMCauthanhSP_Click(object sender, EventArgs e)
        {
            showForm_DanhMucCongTrinh();
        }
        private void btnDanhmuckheuoc_Click(object sender, EventArgs e)
        {
            showForm_DanhMucKheUoc();
        }
        #endregion

        #region shortcutKey
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.KeyCode == Keys.Q && e.Control)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion        





    }
}