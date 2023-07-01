using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDir_Testing
{
    public class Message
    {
        public string MsgText { get; set; }
        public string Department { get; set; }

        public Message(string m, string d)
        {
            MsgText = m;
            Department = d;
        }
    }


    public class MessageManager
    {
        private static MessageManager instance;
        private List<Message> messageList;

        private MessageManager()
        {
            messageList = new List<Message>();
        }

        public static MessageManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MessageManager();
                }
                return instance;
            }
        }

        public List<Message> MessageList
        {
            get { return messageList; }
        }
    }
}
