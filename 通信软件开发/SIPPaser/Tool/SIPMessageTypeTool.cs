using SIPPaser.Mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPPaser.Tool
{
    public class  SIPMessageTypeTool
    {
        public static SIPMessageType Paser(string msgtype,out int code)
        {
            code = 0;
            msgtype = msgtype.Trim().ToUpper();
            switch (msgtype)
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
                    return SIPMessageType.REGISTER;
                case "OPTIONS":
                    return SIPMessageType.OPTIONS;

                case "SUBSCRIBE":
                    return SIPMessageType.SUBSCRIBE;
                case "NOTIFY":
                    return SIPMessageType.NOTIFY;

                    
                default:
                    {
                        
                        if(int.TryParse(msgtype,out code))
                            return SIPMessageType.REPLAY;
                        else
                            return SIPMessageType.Other;
                    }

            }
        }
    }
}
