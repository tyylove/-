using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlHelper;
using MySql.Data.MySqlClient;
using System.Data;

namespace SIPPaser.Mod
{
    /// <summary>
    /// SIP消息定义
    /// </summary>
    public class SipMessage
    {
        /// <summary>
        /// 消息发送的时间
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        public SIPMessageType MessageType { get; set; }
        public ProtocolType ProtocolType { get; set; }
        public string SrcIP { get; set; }
        public string SrcPort { get; set; }
        public string DstIP { get; set; }
        public string DstPort { get; set; }
     
        public int? StatusCode { get; set; }

        public string CallID { get; set; }
        public string FromSIPUrl { get; set; }
        public string FromTag { get; set; }
        public string ToSIPUrl { get; set; }
        public string ToTag { get; set; }

        public string SIPBody { get; set; }

        public string GetDisplayType()
        {
            if (this.MessageType == SIPPaser.Mod.SIPMessageType.REPLAY)
                return StatusCode.ToString();
            else
                return MessageType.ToString();

        }

        public override string ToString()
        {
            return string.Format("Time:{0:HH:mm:ss} Type:{1} StatusCode:{2} CallID:{3}", Time,MessageType,StatusCode,CallID);
        }

        public static int Insert(SipMessage sipMessage)
        {
            return MySqlHelper.MySqlConnect.ExecuteNonQuery($"INSERT INTO sipMessage(Time,MessageType,CallID,SrcIP,SrcPort,FromSIPUrl,FromTag,DstIP,DstPort,ToSIPUrl,ToTag,ProtocolType,SIPBody) VALUES (@Time,@MessageType,@CallID,@SrcIP,@SrcPort,@FromSIPUrl,@FromTag,@DstIP,@DstPort,@ToSIPUrl,@ToTag,@ProtocolType,@SIPBody)",
                new MySqlParameter("@Time", sipMessage.Time.ToString()),
                new MySqlParameter("@MessageType", sipMessage.MessageType.ToString()),
                new MySqlParameter("@CallID", sipMessage.CallID),
                new MySqlParameter("@SrcIP", sipMessage.SrcIP),
                new MySqlParameter("@SrcPort", sipMessage.SrcPort),
                new MySqlParameter("@FromSIPUrl", sipMessage.FromSIPUrl),
                new MySqlParameter("@FromTag", sipMessage.FromTag),
                new MySqlParameter("@DstIP", sipMessage.DstIP),
                new MySqlParameter("@DstPort", sipMessage.DstPort),
                new MySqlParameter("@ToSIPUrl", sipMessage.ToSIPUrl),
                new MySqlParameter("@ToTag", sipMessage.ToTag),
                new MySqlParameter("@ProtocolType", sipMessage.ProtocolType.ToString()),
                new MySqlParameter("@SIPBody", sipMessage.SIPBody)
                );
        }

        public static int QueryMessageType(string MessageType)
        {
            return MySqlHelper.MySqlConnect.ExecuteTableRows("SELECT * FROM sipmessage WHERE MessageType = @MessageType",
                new MySqlParameter("@MessageType",MessageType)
                );
        }

        public static List<SipMessage> ListAll()
        {
            List<SipMessage> sipMessages = new List<SipMessage>();
            DataTable dt = MySqlHelper.MySqlConnect.ExecuteTable("SELECT * FROM sipmessage");
            foreach (DataRow dr in dt.Rows)
            {
                sipMessages.Add(ToModel(dr));
            }
            return sipMessages;
        }

        private static SipMessage ToModel(DataRow dr)
        {
            DateTime dateTime = new DateTime();
            SipMessage sipMessage = new SipMessage();
            sipMessage.Time = Convert.ToDateTime(dr["Time"].ToString());
            sipMessage.MessageType = SIPMessToModel(dr["MessageType"].ToString());
            sipMessage.CallID = dr["CallID"].ToString();
            sipMessage.SrcIP = dr["SrcIP"].ToString();
            sipMessage.SrcPort = dr["SrcPort"].ToString();
            sipMessage.FromSIPUrl = dr["FromSIPUrl"].ToString();
            sipMessage.FromTag = dr["FromTag"].ToString();
            sipMessage.DstIP = dr["DstIP"].ToString();
            sipMessage.DstPort = dr["DstPort"].ToString();
            sipMessage.ToSIPUrl = dr["ToSIPUrl"].ToString();
            sipMessage.ToTag = dr["ToTag"].ToString();
            sipMessage.ProtocolType = ProTypeToModel(dr["ProtocolType"].ToString());
            sipMessage.SIPBody = dr["SIPBody"].ToString();

            return sipMessage;

        }


        public static ProtocolType ProTypeToModel(string protypestr)
        {
            switch (protypestr)
            {
                case "UDP":
                    return ProtocolType.UDP;
                case "TCP":
                    return ProtocolType.TCP;
                default:
                    return ProtocolType.Error;
            }
        }

        public static SIPMessageType SIPMessToModel(string sipMessstr)
        {
            switch (sipMessstr)
            {
                case "INVITE":
                    return SIPMessageType.INVITE;
                case "ACK":
                    return SIPMessageType.ACK;
                case "BYE":
                    return SIPMessageType.BYE;
                case "CANCEL":
                    return SIPMessageType.CANCEL;
                case "REGISTER":
                    return SIPMessageType.CANCEL;
                case "OPTIONS":
                    return SIPMessageType.OPTIONS;
                case "NOTIFY":
                    return SIPMessageType.NOTIFY;
                case "SUBSCRIBE":
                    return SIPMessageType.SUBSCRIBE;
                case "REPLAY":
                    return SIPMessageType.REPLAY;
                default:
                    return SIPMessageType.Other;
            }
        }


    }
}
