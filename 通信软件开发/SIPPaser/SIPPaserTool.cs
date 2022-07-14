using SIPPaser.Mod;
using SIPPaser.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPPaser
{
    /// <summary>
    /// SIP信令解析工具
    /// </summary>
    public  class SIPPaserTool
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg">SIP的字符串</param>
        /// <returns>SIP信令的结构</returns>
        public static SipMessage PaserMsgStr(string msg)
        {
            //判断输入是否是正常
            if (string.IsNullOrEmpty(msg))
                return null;

            SipMessage sipmsg = new SipMessage();
            //time
            //Epoch Time: xxxxxx seconds
            var timestr = GetFiled(msg, "Epoch Time:", " seconds");
            double datetime=-1;
            if (double.TryParse(timestr.Trim(), out datetime))
            {
                sipmsg.Time = GetDateTime(datetime) ;
            }
            else
                return null;

            //Call-ID: NjgzM2E5MGIxYTNiZTYxYTViNmVkZDIyM2UzOGViNTA.\r\n
            sipmsg.CallID = GetFiled(msg, "Call-ID:", "\r\n");

            //Session Initiation Protocol (BYE)
            var msgtype = GetFiled(msg, "Session Initiation Protocol (", ")");
            int code = 0;
            sipmsg.MessageType = SIPMessageTypeTool.Paser(msgtype,out code);

            if(sipmsg.MessageType == SIPMessageType.REPLAY)
            {
                sipmsg.StatusCode = code;
            }
            //SrcIP
            sipmsg.SrcIP= GetFiled(msg, "Source Address: ", "\r\n");
            //DstIP
            sipmsg.DstIP = GetFiled(msg, "Destination Address: ", "\r\n");
            //SrcPort
            sipmsg.SrcPort = GetFiled(msg, "Source Port: ", "\r\n");
            //DstPort
            sipmsg.DstPort= GetFiled(msg, "Destination Port: ", "\r\n");
            //FromSIPUrl
            sipmsg.FromSIPUrl= GetFiled(msg, "SIP from address: ", "\r\n");
            //ToSIPUrl
            sipmsg.ToSIPUrl = GetFiled(msg, "SIP to address: ", "\r\n");
            sipmsg.FromTag = GetFiled(msg, "SIP from tag: ", "\r\n");
            //ToSIPUrl
            sipmsg.ToTag = GetFiled(msg, "SIP to tag: ", "\r\n");


            //Protocol

            //消息协议 TCP UDP
            var protocol = GetFiled(msg, "Transport:", "\r\n");
            int pro = 0;
            sipmsg.ProtocolType = SIPProcotolTypeTool.Pro(protocol, out pro);
            if (pro == 0)
            {
                sipmsg.ProtocolType = ProtocolType.UDP;
            }
            else if (pro == 1)
            {
                sipmsg.ProtocolType = ProtocolType.TCP;
            }
            else
                sipmsg.ProtocolType = ProtocolType.Error;

            //sip body
            int startindex = msg.IndexOf("Session Initiation Protocol (");
            if (startindex > 0)
                sipmsg.SIPBody = msg.Substring(startindex, msg.Length - startindex);
            else
                return null;


            return sipmsg;
        }

        /// <summary>
        /// 从start到end取对应的字符串
        /// </summary>
        /// <param name="msg">SIP消息</param>
        /// <param name="start">字段的开头</param>
        /// <param name="end">字段的结尾</param>
        /// <returns>从start到end间的字符串</returns>
        static string GetFiled(string msg,string start,string end)
        {
            int startindex = msg.IndexOf(start);
            int endindex = 0;
            if (startindex > 0)
            {
                endindex = msg.IndexOf(end, startindex);
                if (endindex < startindex)
                    return null;
                startindex += start.Length;//跳过开始
                var timestr = msg.Substring(startindex, endindex - startindex);
                return timestr;
            }
            return null;
        }
        static DateTime GetDateTime(double seconds)
        {
            return new DateTime(1970, 1, 1, 8, 0, 0, DateTimeKind.Utc).AddSeconds(seconds);
        }
    }
}
