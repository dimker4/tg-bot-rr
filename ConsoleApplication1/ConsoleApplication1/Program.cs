using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MihaZupan;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace ConsoleApplication1
{
    class Program
    {
        private static TelegramBotClient Bot;

        static void Main(string[] args)
        {
            var proxy = new HttpToSocks5Proxy("162.243.7.181", 54669);
            proxy.ResolveHostnamesLocally = true;

            Bot = new TelegramBotClient("656676434:AAHtZ9yd-HaGyM1CoROJyXxgMuzgyt03r1o", proxy);
            Bot.OnMessage += Bot_OnMessage; 
            Bot.SetWebhookAsync("");

            var me = Bot.GetMeAsync().Result;
            Console.Title = me.Username;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static async void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            Message msg = e.Message;

            if (msg == null) return;

            // Если сообщение текстовое
            if (msg.Type == MessageType.Text)
            {
                await Bot.SendTextMessageAsync(msg.Chat.Id, "Hello, " + msg.From.FirstName + "!");
            }

        }
    }
}
