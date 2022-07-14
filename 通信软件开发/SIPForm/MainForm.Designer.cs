
namespace SIPForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonImport = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DoughnutChart = new Sunny.UI.UIDoughnutChart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucPieChart1 = new HZH_Controls.Controls.UCPieChart();
            this.BarChart = new Sunny.UI.UIBarChart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderIndex = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTime = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMessageType = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderInfo = new System.Windows.Forms.ColumnHeader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStripMain.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonImport});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMain.Size = new System.Drawing.Size(1182, 27);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonImport
            // 
            this.toolStripButtonImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonImport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImport.Image")));
            this.toolStripButtonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImport.Name = "toolStripButtonImport";
            this.toolStripButtonImport.Size = new System.Drawing.Size(43, 24);
            this.toolStripButtonImport.Text = "导入";
            this.toolStripButtonImport.Click += new System.EventHandler(this.toolStripButtonImport_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DoughnutChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1174, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "统计2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DoughnutChart
            // 
            this.DoughnutChart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoughnutChart.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoughnutChart.Location = new System.Drawing.Point(250, 40);
            this.DoughnutChart.Margin = new System.Windows.Forms.Padding(2);
            this.DoughnutChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.DoughnutChart.Name = "DoughnutChart";
            this.DoughnutChart.Size = new System.Drawing.Size(514, 382);
            this.DoughnutChart.SubFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoughnutChart.TabIndex = 0;
            this.DoughnutChart.Text = "uiDoughnutChart1";
            this.DoughnutChart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BarChart);
            this.tabPage2.Controls.Add(this.ucPieChart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1174, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "统计1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucPieChart1
            // 
            this.ucPieChart1.BackColor = System.Drawing.Color.Transparent;
            this.ucPieChart1.CenterOfCircleColor = System.Drawing.Color.White;
            this.ucPieChart1.CenterOfCircleWidth = 0;
            this.ucPieChart1.DataSource = new SIPForm.UserCtr.PieItem[0];
            this.ucPieChart1.Location = new System.Drawing.Point(66, 8);
            this.ucPieChart1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPieChart1.Name = "ucPieChart1";
            this.ucPieChart1.Size = new System.Drawing.Size(427, 399);
            this.ucPieChart1.TabIndex = 0;
            this.ucPieChart1.TiTle = null;
            this.ucPieChart1.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucPieChart1.TitleFroeColor = System.Drawing.Color.Black;
            // 
            // BarChart
            // 
            this.BarChart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BarChart.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BarChart.Location = new System.Drawing.Point(475, 8);
            this.BarChart.Margin = new System.Windows.Forms.Padding(2);
            this.BarChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.BarChart.Name = "BarChart";
            this.BarChart.Size = new System.Drawing.Size(514, 387);
            this.BarChart.SubFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BarChart.TabIndex = 1;
            this.BarChart.Text = "uiBarChart1";
            this.BarChart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1174, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信令列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIndex,
            this.columnHeaderTime,
            this.columnHeaderMessageType,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader9,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader10,
            this.columnHeaderInfo});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1166, 486);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderIndex
            // 
            this.columnHeaderIndex.Text = "序号";
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "时间";
            this.columnHeaderTime.Width = 120;
            // 
            // columnHeaderMessageType
            // 
            this.columnHeaderMessageType.Text = "消息类型";
            this.columnHeaderMessageType.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Call_ID";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "源IP";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "源端口";
            this.columnHeader8.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "发起者SIP-Url";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "发起者Tag";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "目的IP";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "目的端口";
            this.columnHeader9.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "接收者SIP-Url";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "接收者Tag";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "传输协议";
            // 
            // columnHeaderInfo
            // 
            this.columnHeaderInfo.Text = "内容";
            this.columnHeaderInfo.Width = 200;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 527);
            this.tabControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonImport;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UIDoughnutChart DoughnutChart;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIBarChart BarChart;
        private HZH_Controls.Controls.UCPieChart ucPieChart1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderIndex;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderMessageType;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeaderInfo;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

