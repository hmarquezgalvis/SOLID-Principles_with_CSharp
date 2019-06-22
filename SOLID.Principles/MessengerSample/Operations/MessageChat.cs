using System;
using SOLID.Principles.MessengerSample.Interfaces;

namespace SOLID.Principles.MessengerSample.Operations
{
    public class MessageChat
        : IMessageSend
    {

        public bool Send(Message message)
        {
            return true;
        }
    }
}
