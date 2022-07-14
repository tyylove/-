using SIPPaser.Mod;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPPaser
{
    public class SIPPaserServer
    {
        public SIPPaserServer()
        {
            SIPList = new List<SipMessage>();
            CallIDDic = new Dictionary<string, List<SipMessage>>();
        }
        public List<SipMessage> SIPList { get; private set; }
        /// <summary>
        /// 第一步
        /// </summary>
        /// <param name="path"></param>
        public void ImportSIPTxt(string path)
        {
            
            //文件读取
            using (var fileread = File.OpenText(path))
            {
                string line = null;
                //消息的缓存区
                StringBuilder build = new StringBuilder();
                while ((line = fileread.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        build.AppendLine(line);
                    }
                    else //new sip message
                    {
                        var msgstr = build.ToString();
                        build.Clear();
                        //解析
                        var msg = SIPPaserTool.PaserMsgStr(msgstr);
                        if (msg != null)
                        {
                            SIPList.Add(msg);
                            //Console.WriteLine(msg.ToString());
                        }
                    }
                }
                //Console.WriteLine(string.Format("msg count:{0}", SIPList.Count));
                //Console.ReadLine();
            }
        }

        /// <summary>
        /// 基于CallID的SIP信令字典
        /// </summary>
        public Dictionary<string,List<SipMessage>> CallIDDic { get; set; }

        /// <summary>
        /// 第二步 对SIP信令进行分组
        /// </summary>
        public void GroupByCALLID()
        {
            CallIDDic.Clear();
            //遍历SIPLIST
            foreach(var sip in SIPList)
            {
                //判断一下，在CallIDDic已经插入对应的CALLID
                if (CallIDDic.ContainsKey(sip.CallID))
                {
                    CallIDDic[sip.CallID].Add(sip);
                }
                else
                {
                    var siplist = new List<SipMessage>();
                    siplist.Add(sip);
                    CallIDDic[sip.CallID] = siplist;
                }

            }

        }
        /// <summary>
        /// 统计注册
        /// </summary>
        public void StatuReg()
        {

        }

        /// <summary>
        /// 统计拨打
        /// </summary>
        public void StatuCall()
        {

        }

    }
}
