using System;
namespace SOLID.Principles.MessengerSample.Interfaces
{
    public interface IMessageSend
    {
        bool Send(Message message);
    }
}
