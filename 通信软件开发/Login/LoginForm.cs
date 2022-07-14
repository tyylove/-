using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Login.Models;
using Login.Utility;
using Management;
using OperatorForm;
using AnalysisOptimizerForm;


namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userbases = new LoginUserBases();
            userbases.ID = txtUserName.Text;
            userbases.Password = txtPassword.Text;
            string cmd = "select * from user where ID = '"+ userbases.ID+"' and Password ='"+userbases.Password+"'";
            var mysqlConnect = new MysqlConnect();
            var connect = mysqlConnect.ConnectToMysql();
            MySqlCommand mySqlCommand = new MySqlCommand(cmd, connect);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            if(mySqlDataReader.Read())
            {
                //MessageBox.Show("登陆成功");
                var Title = mySqlDataReader["Title"].ToString();
                if(Title=="1")
                {
                    this.Hide();
                    ManagerForm mana = new ManagerForm();
                    mana.ShowDialog();
                    Application.Exit();
                }
                else if(Title=="2")
                {
                    this.Hide();
                    FrmOperator frmOperator = new FrmOperator();
                    frmOperator.ShowDialog();
                    Application.Exit();
                }
                else if(Title=="3")
                {
                    this.Hide();
                    AnalysisOptimizer analysisOptimizer = new AnalysisOptimizer();
                    analysisOptimizer.ShowDialog();
                    Application.Exit();
                }
                else if (Title=="4")
                {
                    this.Hide();
                    SIPForm.MainForm sipForm = new SIPForm.MainForm();
                    sipForm.ShowDialog();
                    Application.Exit();
                }
                //MessageBox.Show(Title);
                mySqlDataReader.Close();
            }
            else
            {
                txtPassword.Text = "";
                MessageBox.Show("登录失败");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*' ;
        }
    }
}
