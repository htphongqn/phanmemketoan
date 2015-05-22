using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using ketoansoft.app.Class.Data;
using System.Drawing;

namespace ketoansoft.app.Class.Global
{
    public class Unit
    {
        private static CFGRepo _CFGRepo = new CFGRepo();
        public virtual void Get_AllowEdit(GridView grv)
        {
            string msg = "";
            if (grv.OptionsBehavior.Editable)
            {
                grv.OptionsBehavior.Editable = false;
                msg = "Đã tắt chế độ chỉnh sửa!";
            }
            else
            {
                grv.OptionsBehavior.Editable = true;
                msg = "Đã bật chế độ chỉnh sửa!";
            }
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public virtual void Get_ColorTick(GridView grv, object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["DANH_DAU"]);
                if (category == "T")
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
        }
        public static void UnitGridview(GridView grv)
        {
            grv.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            grv.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 12);
            grv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            grv.ColumnPanelRowHeight = 45;
            grv.RowHeight = 30;

            grv.OptionsPrint.UsePrintStyles = true;
            grv.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            grv.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            grv.OptionsView.AllowHtmlDrawHeaders = true;
            grv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
        }
        public static bool IsFormActived(string FormName)
        {
            try
            {
                FormName = EmptyNull(FormName).ToLower();
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name.ToString().ToLower() == FormName)                 
                    {
                        Application.OpenForms[FormName].Activate();
                        return true;
                    }
                }
            }
            catch { return false; }
            return false;
        }
        public static string EmptyNull(object sInfo)
        {
            if (sInfo == null) return "";
            return sInfo.ToString().Trim();
        }
        public static string Get_CompanyName(string idv)
        {
            return _CFGRepo.GetNameByIDV(idv);
        }
        public static string Get_InfoRows(GridView grv, string[] arr)
        {
            string str = "";
            for (int i = 0; i < arr.Count(); i++)
            {
                str += "[" + grv.GetFocusedRowCellValue(arr[i]) + "]  ";
            }
            return str;
        }
        
    }
}
