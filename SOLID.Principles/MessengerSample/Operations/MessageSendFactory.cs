using System;
using SOLID.Principles.MessengerSample.Interfaces;

namespace SOLID.Principles.MessengerSample.Operations
{
    public class MessageSendFactory
    {
        public static IMessageSend GetMessageSendType(MessageSendTypeEnum type)
        {
            switch(type)
            {
                case MessageSendTypeEnum.Email:
                    return new MessageEmail();

                case MessageSendTypeEnum.SMS:
                    return new MessageSMS();

                default:
                    return new MessageEmail();
            }
        }
    }

    public enum MessageSendTypeEnum
    {
        Chat,
        Email,
        SMS
    }
}
