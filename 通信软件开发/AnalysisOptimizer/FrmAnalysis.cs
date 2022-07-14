using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalysisOptimizerForm
{
    public partial class AnalysisOptimizer : Form
    {
        public AnalysisOptimizer()
        {
            InitializeComponent();
        }

        private void BindDgv()
        {
            string SrcIP = txtSrcIP.Text.Trim();
            string DstIP = txtDstIP.Text.Trim();
            List<SIPPaser.Mod.SipMessage> sipMessages = SIPPaser.Mod.SipMessage.ListAll();
            if (SrcIP.Trim().Length == 0 && SrcIP.Trim().Length == 0)
            {
                dgvSIPMessage.DataSource = sipMessages;
            }
            else if (SrcIP.Trim().Length != 0 && DstIP.Trim().Length == 0)
            {
                dgvSIPMessage.DataSource = sipMessages.FindAll(m => m.SrcIP.Contains(SrcIP));
            }
            else if (SrcIP.Trim().Length == 0 && DstIP.Trim().Length != 0)
            {
                dgvSIPMessage.DataSource = sipMessages.FindAll(m => m.DstIP.Contains(DstIP));
            }
            else
            {
                dgvSIPMessage.DataSource = sipMessages.FindAll(m => m.SrcIP.Contains(SrcIP) && m.DstIP.Contains(DstIP));
            }
        }

        private void AnalysisOptimizer_Load(object sender, EventArgs e)
        {
            BindDgv();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDgv();
        }
    }
}
