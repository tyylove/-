using SIPPaser.Mod;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SIPPaser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<SipMessage> list = new List<SipMessage>();
            //文件读取
            using(var fileread = File.OpenText(@"E:\通信软件开发\资源\第四次课代码\sip-master\sip-master\测试数据\1.txt"))
            {
                string line = null;
                //消息的缓存区
                StringBuilder build = new StringBuilder();
                while ((line= fileread.ReadLine())!=null)
                {
                    if(!string.IsNullOrEmpty(line))
                    {
                        build.AppendLine(line);
                    }
                    else //new sip message
                    {
                        var msgstr = build.ToString();
                        build.Clear();
                        //解析
                        var msg = SIPPaserTool.PaserMsgStr(msgstr);
                         if(msg!=null)
                        {
                            list.Add(msg);
                            Console.WriteLine(msg.ToString());
                        }
                    }
                }
                Console.WriteLine(string.Format("msg count:{0}",list.Count));
                Console.ReadLine();
            }
        }
    }
}
