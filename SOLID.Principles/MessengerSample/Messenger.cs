using System;
using SOLID.Principles.MessengerSample.Operations;

namespace SOLID.Principles.MessengerSample
{
    public class Messenger
    {
        public bool Send(Message message, MessageSendTypeEnum sendType = MessageSendTypeEnum.Chat)
        {
            return MessageSendFactory.GetMessageSendType(sendType).Send(message);
        }
    }
}
