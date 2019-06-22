using System;
using SOLID.Principles.MessengerSample;
using Xunit;

namespace SOLID.Tests
{
    public class MessengerTest
    {
        [Fact]
        public void SendEmail()
        {
            var messenger = new Messenger();
            var message = new Message
            {
                To = "hector@dominio.com",
                Subject = "Email from Unit Test",
                Body = "Please, doesnt reply this email because is a test."
            };

            var result = messenger.Send(message, Principles.MessengerSample.Operations.MessageSendTypeEnum.Email);

            Assert.Equal(true, result);
        }

        [Fact]
        public void SendSMS()
        {
            var messenger = new Messenger();
            var message = new Message
            {
                To = "80010203040",
                Body = "Please, doesnt reply this SMS because is a test."
            };

            var result = messenger.Send(message, Principles.MessengerSample.Operations.MessageSendTypeEnum.SMS);

            Assert.Equal(true, result);
        }
        [Fact]
        public void SendChat()
        {
            var messenger = new Messenger();
            var message = new Message
            {
                To = "guest1234",
                Body = "Please, doesnt reply this chat message because is a test."
            };

            var result = messenger.Send(message, Principles.MessengerSample.Operations.MessageSendTypeEnum.Chat);

            Assert.Equal(true, result);
        }
    }
}
