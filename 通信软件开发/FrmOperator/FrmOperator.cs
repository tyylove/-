using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlHelper;
using SIPPaser;
using SIPForm;

namespace OperatorForm
{
    public partial class FrmOperator : Form
    {
        public FrmOperator()
        {
            InitializeComponent();
        }

        private void FrmOperator_Load(object sender, EventArgs e)
        {
            BindDgv();
        }

        private void BindDgv()
        {
            dgvSIPMessage.AutoGenerateColumns = false;
            List<SIPPaser.Mod.SipMessage> sipMessages = SIPPaser.Mod.SipMessage.ListAll();
            dgvSIPMessage.DataSource = sipMessages;
        }

        private void tSBtnRefresh_Click(object sender, EventArgs e)
        {
            BindDgv();
        }

        private void tSBtnImport_Click(object sender, EventArgs e)
        {
            SIPForm.MainForm.ImportSIPMessageList();
            BindDgv();
        }
    }
}
