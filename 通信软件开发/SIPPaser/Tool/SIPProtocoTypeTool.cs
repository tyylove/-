using SIPPaser.Mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPPaser.Tool
{
    public class SIPProcotolTypeTool
    {
        public static ProtocolType Pro(string msgtype, out int pro)
        {
            pro = 0;
            msgtype = msgtype.Trim().ToUpper();
            switch (msgtype)
            {
                case "UDP":
                    return ProtocolType.UDP;
                case "TCP":
                    return ProtocolType.TCP;
                default :
                    return ProtocolType.Error;
                            
            }
           
        }
    }
}
