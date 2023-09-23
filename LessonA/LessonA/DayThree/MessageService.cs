using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayThree
{
    internal interface IMessageService
    {
        void sendMessage(string message);
        void sendAudioMessage(string message);
        void sendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessage();
    }
    public interface IPayments
    {
        void Makepayment(float amount);
    }
    internal class WhatApp : IMessageService,IPayments
    {
        public void DeleteMessage()
        {
            Console.WriteLine("method not implement");
        }
        public void Makepayment(float amount)
        {
            Console.WriteLine($"PAID AMOUNT:{amount}");
        }
        public void ReceiveMessage()
        {
            Console.WriteLine("method not implement");
        }
        public void sendAudioMessage(string message)
        {
            Console.WriteLine("method not implement");
        }
        public void sendMessage(string message)
        {
            Console.WriteLine("method not implement");
        }
        public void sendVideoMessage(string message)
        {
            Console.WriteLine("method not implement");
        }
    }
    //end of class

    public class MessageTester
    {
        public static void TestOne()
        {
            IMessageService messageService = new WhatApp();
            messageService.sendMessage("hello");
            messageService.ReceiveMessage();
        }

        
    }
}
