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
    public partial class FrmSetUser : Form
    {
        private DelBinDgv _delBinDgv;
        public FrmSetUser(DelBinDgv delBinDgv)
        {
            InitializeComponent();
            _delBinDgv = delBinDgv;
        }
        private User _user;
        public FrmSetUser(DelBinDgv delBinDgv, string userID):this(delBinDgv)
        {
            _user = User.ListAll().Find(m => m.ID == userID);


        }

        private void FrmSetUser_Load(object sender, EventArgs e)
        {
            List<TitleConstrast> titleConstrasts = new List<TitleConstrast>();

            titleConstrasts = TitleConstrast.ListAll();
            cbxTitle.DataSource = titleConstrasts;
            cbxTitle.DisplayMember = "Title";
            cbxTitle.ValueMember = "Title";

            if(_user != null)
            {
                txtID.Text = _user.ID;
                txtPassword.Text = _user.Password;
                txtName.Text = _user.Name;
                cbxSex.Text = _user.Sex;
                cbxTitle.Text = _user.Title;
                lbConfirmPassword.Visible = false;
                txtPasswordConfirm.Visible = false;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string id = txtID.Text.Trim();
            string password = txtPassword.Text.Trim();
            string userName = txtName.Text.Trim();
            string sex = cbxSex.Text;
            string title = cbxTitle.Text;
            if (id.Trim().Length == 0 || userName.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户信息");
            }
            else
            {
                if (txtPassword.Text == txtPasswordConfirm.Text || _user != null)
                {
                    if(_user == null)
                    {
                        User user = new User
                        {
                            ID = id,
                            Password = password,
                            Name = userName,
                            Sex = sex,
                            Title = title
                        };
                        User.Insert(user);
                        MessageBox.Show("用户添加成功");
                    }
                    else
                    {
                        _user.ID = id;
                        _user.Password = password;
                        _user.Name = userName;
                        _user.Sex = sex;
                        _user.Title = title;
                        User.Update(_user);
                        MessageBox.Show("用户信息修改成功");
                    }

                    _delBinDgv();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("密码不一致");
                    txtPassword.Text = "";
                    txtPasswordConfirm.Text = "";
                }
            }

        }
    }
}
