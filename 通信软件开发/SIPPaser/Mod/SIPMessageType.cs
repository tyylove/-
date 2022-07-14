using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPPaser.Mod
{
    public enum SIPMessageType
    {
        Other=0,
        INVITE,
        ACK,
        BYE,
        CANCEL,
        REGISTER,
        OPTIONS,
        NOTIFY,
        SUBSCRIBE,
        //响应消息，由status code 确定消息类型
        REPLAY,
        ////临时响应
        //Code_1XX,
        ////成功响应
        //Code_200,
        ////重定向响应
        //Code_3XX,
        ////客户出错
        //Code_4XX,
        ////服务器出错
        //Code_5XX,
        ////全局故障
        //Code_6XX,
        
    }




}
