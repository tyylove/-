using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Management
{
    /// <summary>
    /// 我们自己声明了一个string/int关键字    
    /// </summary>
    public delegate void DelBinDgv();
    public partial class ManagerForm : Form
    {
        DelBinDgv delBinDgv;
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            BindCbx();
            BindDgv();
            delBinDgv = BindDgv;
        }

        private void BindDgv()
        {
            string userID = txtUserID.Text.Trim();
            var title = cbxBase.SelectedValue.ToString();
            dgvUserBases.AutoGenerateColumns = false;
            List<UserBases> userBases = UserBases.ListAll();
            if (title == "-查询所有-" && userID.Trim().Length == 0)
            {
                dgvUserBases.DataSource = userBases;
            }
            else if (title == "-查询所有-" && userID.Trim().Length != 0)
            {
                dgvUserBases.DataSource = userBases.FindAll(m => m.ID.Contains(userID));
            }
            else if(userID.Trim().Length == 0 && title != "-查询所有-")
            {
                dgvUserBases.DataSource = userBases.FindAll(m => m.Title == title);
            }
            else
            {
                dgvUserBases.DataSource = userBases.FindAll(m => m.ID.Contains(userID) && m.Title == title);
            }
        }

        private void BindCbx()
        {
            List<UserBases> userBases = new List<UserBases>();

            userBases = UserBases.ListAllByTitle();
            userBases.Insert(0, new UserBases
            {
                ID = "0",
                UserName = "0",
                Sex = "0",
                Title = "-查询所有-",
            });
            cbxBase.DataSource = userBases;
            cbxBase.DisplayMember = "Title";
            cbxBase.ValueMember = "Title";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDgv();
        }

        private void dgvUserBases_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                tsmAdd.Visible = true;
                tsmEdit.Visible = false;
                tsmDelete.Visible = false;

            }
        }

        private void dgvUserBases_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(e.RowIndex>-1)
                {
                    dgvUserBases.Rows[e.RowIndex].Selected = true;
                    tsmAdd.Visible = true;
                    tsmEdit.Visible = true;
                    tsmDelete.Visible = true;
                }
            }
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            FrmSetUser frmSetUser = new FrmSetUser(delBinDgv);
            frmSetUser.ShowDialog();
            BindDgv();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            string userID = dgvUserBases.SelectedRows[0].Cells["ID"].Value.ToString();
            FrmSetUser frmSetUser = new FrmSetUser(delBinDgv,userID);
            frmSetUser.ShowDialog();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            string userID = dgvUserBases.SelectedRows[0].Cells["ID"].Value.ToString();
            User.Delete(userID);
            MessageBox.Show("删除成功");
            BindDgv();
        }
    }
}
