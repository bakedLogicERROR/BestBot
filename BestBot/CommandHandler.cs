using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BestBot
{
    public class CommandHandler
    {
        private DiscordSocketClient _client;

        private CommandService _service;

        public CommandHandler(DiscordSocketClient client)
        {
            this._client = client;

            this._service = new CommandService();

            this._service.AddModulesAsync(Assembly.GetEntryAssembly());

            this._client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage s)
        {
            var msg = s as SocketUserMessage;

            if (msg == null) return;

            var context = new SocketCommandContext(_client, msg);

            int argPos = 0;

            if (msg.HasStringPrefix("bar ", ref argPos) || msg.HasStringPrefix("Bar ", ref argPos))
            {
                var result = await _service.ExecuteAsync(context, argPos);

                if (!result.IsSuccess && result.Error != CommandError.UnknownCommand)
                {
                    await context.Channel.SendMessageAsync(result.ErrorReason);
                }
            }
            else if (msg.HasStringPrefix("Leedle", ref argPos) || msg.HasStringPrefix("leedle", ref argPos))
            {
                await context.Channel.SendMessageAsync(context.User.Mention + ", if you say 'Leedle' one more time I will chop your goddamn balls off!");
            }
            else if (msg.HasMentionPrefix(this._client.GetUser(355498979766829067), ref argPos))
            {
                await context.Channel.SendMessageAsync(context.User.Mention + " shut the fuck up.");
            }
            else if (msg.HasMentionPrefix(this._client.GetUser(228688913286299649), ref argPos))
            {
                await context.Channel.SendMessageAsync("Bro. " + this._client.GetUser(228688913286299649).Mention + " is my god. I do as he wills. He created me. I love him. I would suck is dick.");
            }
            else if (msg.HasMentionPrefix(this._client.GetUser(167312702841028608), ref argPos))
            {
                await context.Channel.SendMessageAsync("Best respect the admin bitch.");
            }
            /* Use this code to search for a prefix or to search for a specific person writing a message.
             * Disabled because the current iteration was annoying us.
            else if ((msg.HasStringPrefix("!r34 ", ref argPos) || msg.HasStringPrefix("!R34 ", ref argPos) || msg.HasStringPrefix("! r34 ", ref argPos) || msg.HasStringPrefix("! R34 ", ref argPos)) && context.User.Id == 167312702841028608)
            {
                await context.Channel.SendMessageAsync("Stop looking up porn and hail " + this._client.GetUser(228688913286299649).Mention + " as your new king!");

                for (int i = 0; i < 10; i ++)
                {
                    await context.Channel.SendMessageAsync("!r34 penis");
                }
            }*/
        }
    }
}
