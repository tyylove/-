using SIPPaser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny;
using Sunny.UI;

namespace SIPForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        SIPPaserServer _sipPaserServer;
        private void MainForm_Load(object sender, EventArgs e)
        {
            //导入文件
            _sipPaserServer = new SIPPaserServer();
            this.SetChart();
            SetBarChartData();
            SetDoughnutCharData();
        }
        private void SetChart()
        {
            int inv = SIPPaser.Mod.SipMessage.QueryMessageType("INVITE");
            int reg = SIPPaser.Mod.SipMessage.QueryMessageType("REGISTER");
            int ack = SIPPaser.Mod.SipMessage.QueryMessageType("ACK");
            int bye = SIPPaser.Mod.SipMessage.QueryMessageType("BYE");
            int can = SIPPaser.Mod.SipMessage.QueryMessageType("CANCEL");
            int opt = SIPPaser.Mod.SipMessage.QueryMessageType("OPTIONS");
            int sub = SIPPaser.Mod.SipMessage.QueryMessageType("SUBSCRIBE");
            int not = SIPPaser.Mod.SipMessage.QueryMessageType("NOTIFY");
            int rep = SIPPaser.Mod.SipMessage.QueryMessageType("REPLAY");

            //饼状图
            var name = new string[] { "呼叫", "注册", "ACK", "结束", "取消", "可选项", "SUB", "NOT", "REP" };
            var values = new int[] { inv, reg, ack, bye, can, opt, sub, not, rep };
            var colors = new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.SeaGreen, Color.Black, Color.Green, Color.GreenYellow, Color.Gray, Color.HotPink };
            this.ucPieChart1.SetDataSource(name, values, colors);
            this.ucPieChart1.IsRenderPercent = true;

        }

        /// <summary>
        /// 设置柱状图数据内容
        /// </summary>
        /// <summary>
        /// 设置柱状图数据内容
        /// </summary>
        private void SetBarChartData()
        {
            int inv = SIPPaser.Mod.SipMessage.QueryMessageType("INVITE");
            int reg = SIPPaser.Mod.SipMessage.QueryMessageType("REGISTER");
            int ack = SIPPaser.Mod.SipMessage.QueryMessageType("ACK");
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "柱状图";
            option.Title.SubText = " ";

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("Bar1");

            var series = new UIBarSeries();
            series.Name = "Bar1";
            series.AddData(-1.1);
            series.AddData(-1.1);
            series.AddData(-1.1);
            option.Series.Add(series);

            option.XAxis.Data.Add("接通");
            option.XAxis.Data.Add("失败");
            option.XAxis.Data.Add("挂机");

            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;

            //option.XAxis.Name = "形式";
            option.XAxis.AxisLabel.Angle = 60;//(0° ~ 90°)

            //option.YAxis.Name = "数值";
            option.YAxis.AxisLabel.DecimalCount = 1;
            option.YAxis.AxisLabel.AutoFormat = false;

            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = 50 });
            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = -20 });

            option.ToolTip.AxisPointer.Type = UIAxisPointerType.Shadow;

            option.ShowValue = true;

            BarChart.SetOption(option);

            Random random = new Random(DateTime.Now.Millisecond);
            BarChart.Update("Bar1", 0, inv);
            BarChart.Update("Bar1", 1, reg);
            BarChart.Update("Bar1", 2, ack);

            BarChart.Refresh();
        }

        private void SetDoughnutCharData()
        {
            int inv = SIPPaser.Mod.SipMessage.QueryMessageType("INVITE");
            int reg = SIPPaser.Mod.SipMessage.QueryMessageType("REGISTER");
            int ack = SIPPaser.Mod.SipMessage.QueryMessageType("ACK");
            int bye = SIPPaser.Mod.SipMessage.QueryMessageType("BYE");
            int can = SIPPaser.Mod.SipMessage.QueryMessageType("CANCEL");

            var option = new UIDoughnutOption();

            //设置Title
            option.Title = new UITitle();
            option.Title.Text = "图表";
            option.Title.SubText = " ";
            option.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option.ToolTip.Visible = true;

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            option.Legend.AddData("注册");
            option.Legend.AddData("呼叫");
            option.Legend.AddData("结束");
            option.Legend.AddData("取消");

            //设置Series
            var series = new UIDoughnutSeries();
            series.Name = "数值";
            series.Center = new UICenter(50, 55);
            series.Radius.Inner = 50;
            series.Radius.Outer = 80;
            series.Label.Show = true;
            series.Label.Position = UIPieSeriesLabelPosition.Center;

            //增加数据
            series.AddData("注册", reg);
            series.AddData("呼叫", inv);
            series.AddData("结束", bye);
            series.AddData("取消", can);

            //增加Series
            option.Series.Clear();
            option.Series.Add(series);

            //设置Option
            DoughnutChart.SetOption(option);
            Random random = new Random(DateTime.Now.Millisecond);
            DoughnutChart.Update("数值", "注册", reg);
            DoughnutChart.Update("数值", "呼叫", inv);
            DoughnutChart.Update("数值", "结束", bye);
            DoughnutChart.Update("数值", "取消", can);

            DoughnutChart.Refresh();
        }


        private void toolStripButtonImport_Click(object sender, EventArgs e)
        {
            //TestSIPListView();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "文本文件|*.txt";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                _sipPaserServer.ImportSIPTxt(openFileDialog.FileName);
                RefreshSIPListView();
            }
        }
        private void RefreshSIPListView()
        {
            this.listView1.Items.Clear();
            int i = 0;
            foreach(var sipmsg in this._sipPaserServer.SIPList)
            {
                i++;
                ListViewItem li = new ListViewItem();
                li.Text = i.ToString();
                li.SubItems.Add(sipmsg.Time.ToString("yyyy-MM-dd HH:mm:ss  fff"));
                //if(sipmsg.MessageType == SIPPaser.Mod.SIPMessageType.REPLAY)
                //    li.SubItems.Add(sipmsg.StatusCode.ToString());
                //else
                // li.SubItems.Add(sipmsg.MessageType.ToString());
                li.SubItems.Add(sipmsg.GetDisplayType());//消息类型


               // li.SubItems.Add(sipmsg.ToString());//序号
                 listView1.Items.Add(li);
                li.SubItems.Add(sipmsg.CallID);


                //发送信息
                li.SubItems.Add(sipmsg.SrcIP);
                li.SubItems.Add(sipmsg.SrcPort);
                li.SubItems.Add(sipmsg.FromSIPUrl);
                li.SubItems.Add(sipmsg.FromTag);
                //接收信息
                li.SubItems.Add(sipmsg.DstIP);
                li.SubItems.Add(sipmsg.DstPort);
                li.SubItems.Add(sipmsg.ToSIPUrl);
                li.SubItems.Add(sipmsg.ToTag);

                li.SubItems.Add(sipmsg.ProtocolType.ToString());//传输协议
                li.SubItems.Add(sipmsg.ToString());//内容

                SIPPaser.Mod.SipMessage.Insert(sipmsg); 
            }
        }


        private void TestSIPListView()
        {
            this.listView1.Items.Clear();


            for (int i = 0; i < 10; i++)
            {
                ListViewItem li = new ListViewItem();
                li.Text = (i + 1).ToString();
                li.SubItems.Add("2022-5-6");
                li.SubItems.Add("SUBSCRIBE");
                li.SubItems.Add("1231321");
                listView1.Items.Add(li);
            }
        }

        private void toolStripButtonStat_Click(object sender, EventArgs e)
        {
            _sipPaserServer.GroupByCALLID();
        }


        public static void ImportSIPMessageList()
        {
            SIPPaserServer sipPaserServer = new SIPPaserServer();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "文本文件|*.txt";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<SIPPaser.Mod.SipMessage> sipMessages = new List<SIPPaser.Mod.SipMessage>();
                sipPaserServer.ImportSIPTxt(openFileDialog.FileName);
                foreach (var sipmsg in sipPaserServer.SIPList)
                {
                    SIPPaser.Mod.SipMessage.Insert(sipmsg);
                }
            }
        }

    }
}
