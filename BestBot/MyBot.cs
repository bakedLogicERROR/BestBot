using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BestBot
{
    public class MyBot
    {
        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public static BarDice game = new BarDice();

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            await _client.LoginAsync(Discord.TokenType.Bot, "MzU1NDk4OTc5NzY2ODI5MDY3.DJN6Qg.5J_ebi-Kek07WPdr0HJrpS8utYA");

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }

        private void Log(object sender, LogMessage e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
