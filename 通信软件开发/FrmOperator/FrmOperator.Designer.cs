namespace OperatorForm
{
    partial class FrmOperator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperator));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBtnImport = new System.Windows.Forms.ToolStripButton();
            this.tSBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.dgvSIPMessage = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrcIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrcPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromSIPUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DstIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DstPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToSIPUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIPbody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSIPMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnImport,
            this.tSBtnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1528, 41);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBtnImport
            // 
            this.tSBtnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnImport.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnImport.Image")));
            this.tSBtnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnImport.Name = "tSBtnImport";
            this.tSBtnImport.Size = new System.Drawing.Size(66, 35);
            this.tSBtnImport.Text = "导入";
            this.tSBtnImport.Click += new System.EventHandler(this.tSBtnImport_Click);
            // 
            // tSBtnRefresh
            // 
            this.tSBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnRefresh.Image")));
            this.tSBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnRefresh.Name = "tSBtnRefresh";
            this.tSBtnRefresh.Size = new System.Drawing.Size(66, 35);
            this.tSBtnRefresh.Text = "刷新";
            this.tSBtnRefresh.Click += new System.EventHandler(this.tSBtnRefresh_Click);
            // 
            // dgvSIPMessage
            // 
            this.dgvSIPMessage.AllowUserToAddRows = false;
            this.dgvSIPMessage.AllowUserToDeleteRows = false;
            this.dgvSIPMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSIPMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.MessageType,
            this.CallID,
            this.SrcIP,
            this.SrcPort,
            this.FromSIPUrl,
            this.FromTag,
            this.DstIP,
            this.DstPort,
            this.ToSIPUrl,
            this.ToTag,
            this.Protocol,
            this.SIPbody});
            this.dgvSIPMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSIPMessage.Location = new System.Drawing.Point(0, 41);
            this.dgvSIPMessage.Name = "dgvSIPMessage";
            this.dgvSIPMessage.ReadOnly = true;
            this.dgvSIPMessage.RowHeadersWidth = 82;
            this.dgvSIPMessage.RowTemplate.Height = 40;
            this.dgvSIPMessage.Size = new System.Drawing.Size(1528, 776);
            this.dgvSIPMessage.TabIndex = 1;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "时间";
            this.Time.MinimumWidth = 10;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 200;
            // 
            // MessageType
            // 
            this.MessageType.DataPropertyName = "MessageType";
            this.MessageType.HeaderText = "消息类型";
            this.MessageType.MinimumWidth = 10;
            this.MessageType.Name = "MessageType";
            this.MessageType.ReadOnly = true;
            this.MessageType.Width = 200;
            // 
            // CallID
            // 
            this.CallID.DataPropertyName = "CallID";
            this.CallID.HeaderText = "Call-ID";
            this.CallID.MinimumWidth = 10;
            this.CallID.Name = "CallID";
            this.CallID.ReadOnly = true;
            this.CallID.Width = 200;
            // 
            // SrcIP
            // 
            this.SrcIP.DataPropertyName = "SrcIP";
            this.SrcIP.HeaderText = "源IP";
            this.SrcIP.MinimumWidth = 10;
            this.SrcIP.Name = "SrcIP";
            this.SrcIP.ReadOnly = true;
            this.SrcIP.Width = 200;
            // 
            // SrcPort
            // 
            this.SrcPort.DataPropertyName = "SrcPort";
            this.SrcPort.HeaderText = "源端口";
            this.SrcPort.MinimumWidth = 10;
            this.SrcPort.Name = "SrcPort";
            this.SrcPort.ReadOnly = true;
            this.SrcPort.Width = 200;
            // 
            // FromSIPUrl
            // 
            this.FromSIPUrl.DataPropertyName = "FromSIPUrl";
            this.FromSIPUrl.HeaderText = "发起者SIP-Url";
            this.FromSIPUrl.MinimumWidth = 10;
            this.FromSIPUrl.Name = "FromSIPUrl";
            this.FromSIPUrl.ReadOnly = true;
            this.FromSIPUrl.Width = 250;
            // 
            // FromTag
            // 
            this.FromTag.DataPropertyName = "FromTag";
            this.FromTag.HeaderText = "发起者Tag";
            this.FromTag.MinimumWidth = 10;
            this.FromTag.Name = "FromTag";
            this.FromTag.ReadOnly = true;
            this.FromTag.Width = 200;
            // 
            // DstIP
            // 
            this.DstIP.DataPropertyName = "DstIP";
            this.DstIP.HeaderText = "目的IP";
            this.DstIP.MinimumWidth = 10;
            this.DstIP.Name = "DstIP";
            this.DstIP.ReadOnly = true;
            this.DstIP.Width = 200;
            // 
            // DstPort
            // 
            this.DstPort.DataPropertyName = "DstPort";
            this.DstPort.HeaderText = "目的端口";
            this.DstPort.MinimumWidth = 10;
            this.DstPort.Name = "DstPort";
            this.DstPort.ReadOnly = true;
            this.DstPort.Width = 200;
            // 
            // ToSIPUrl
            // 
            this.ToSIPUrl.DataPropertyName = "ToSIPUrl";
            this.ToSIPUrl.HeaderText = "接收者SIP-Url";
            this.ToSIPUrl.MinimumWidth = 10;
            this.ToSIPUrl.Name = "ToSIPUrl";
            this.ToSIPUrl.ReadOnly = true;
            this.ToSIPUrl.Width = 250;
            // 
            // ToTag
            // 
            this.ToTag.DataPropertyName = "ToTag";
            this.ToTag.HeaderText = "接收者Tag";
            this.ToTag.MinimumWidth = 10;
            this.ToTag.Name = "ToTag";
            this.ToTag.ReadOnly = true;
            this.ToTag.Width = 200;
            // 
            // Protocol
            // 
            this.Protocol.DataPropertyName = "ProtocolType";
            this.Protocol.HeaderText = "传输协议";
            this.Protocol.MinimumWidth = 10;
            this.Protocol.Name = "Protocol";
            this.Protocol.ReadOnly = true;
            this.Protocol.Width = 200;
            // 
            // SIPbody
            // 
            this.SIPbody.DataPropertyName = "SIPbody";
            this.SIPbody.HeaderText = "内容";
            this.SIPbody.MinimumWidth = 10;
            this.SIPbody.Name = "SIPbody";
            this.SIPbody.ReadOnly = true;
            this.SIPbody.Width = 200;
            // 
            // FrmOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 817);
            this.Controls.Add(this.dgvSIPMessage);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmOperator";
            this.Text = "数据操作";
            this.Load += new System.EventHandler(this.FrmOperator_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSIPMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtnImport;
        private System.Windows.Forms.DataGridView dgvSIPMessage;
        private System.Windows.Forms.ToolStripButton tSBtnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrcIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrcPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromSIPUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DstIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DstPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToSIPUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIPbody;
    }
}
