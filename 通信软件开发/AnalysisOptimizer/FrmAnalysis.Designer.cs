namespace AnalysisOptimizerForm
{
    partial class AnalysisOptimizer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDstIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSrcIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSIPMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtDstIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSrcIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1347, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1079, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDstIP
            // 
            this.txtDstIP.Location = new System.Drawing.Point(714, 98);
            this.txtDstIP.Name = "txtDstIP";
            this.txtDstIP.Size = new System.Drawing.Size(200, 38);
            this.txtDstIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "目的IP地址";
            // 
            // txtSrcIP
            // 
            this.txtSrcIP.Location = new System.Drawing.Point(204, 98);
            this.txtSrcIP.Name = "txtSrcIP";
            this.txtSrcIP.Size = new System.Drawing.Size(200, 38);
            this.txtSrcIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "源IP地址";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSIPMessage);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1347, 486);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            this.dgvSIPMessage.Location = new System.Drawing.Point(3, 34);
            this.dgvSIPMessage.Name = "dgvSIPMessage";
            this.dgvSIPMessage.ReadOnly = true;
            this.dgvSIPMessage.RowHeadersWidth = 82;
            this.dgvSIPMessage.RowTemplate.Height = 40;
            this.dgvSIPMessage.Size = new System.Drawing.Size(1341, 449);
            this.dgvSIPMessage.TabIndex = 2;
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
            // AnalysisOptimizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 748);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnalysisOptimizer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnalysisOptimizer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSIPMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSIPMessage;
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDstIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSrcIP;
        private System.Windows.Forms.Label label1;
    }
}
