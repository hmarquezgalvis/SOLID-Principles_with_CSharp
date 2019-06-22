using System;
using SOLID.Principles.MessengerSample.Interfaces;

namespace SOLID.Principles.MessengerSample.Operations
{
    public class MessageSMS
        : IMessageSend
    {

        public bool Send(Message message)
        {
            return true;
        }
    }
}
