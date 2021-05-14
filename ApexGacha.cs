using System;
using System.Reflection;
using System.Threading.Tasks;
using ConsoleAppFramework;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.Options;

namespace ApexRandomBot
{
    public class ApexGacha : ConsoleAppBase
    {
        private IOptions<Config> _config;
        private DiscordSocketClient _client;
        private CommandService _command;

        public ApexGacha(IOptions<Config> config)
        {
            _config = config;
        }
        public async Task ExecuteAsync()
        { 
            _client = new DiscordSocketClient();
            _command = new CommandService();
            _client.Log += message =>
            {
                Console.WriteLine($"{message.Message} : {message.Exception}");
                return Task.CompletedTask;
            };

            _client.MessageReceived += MessageHandle;
            await _command.AddModulesAsync(Assembly.GetEntryAssembly(), null);
            await _client.LoginAsync(TokenType.Bot, _config.Value.DiscordToken);
            await _client.StartAsync();

            await Task.Delay(-1, Context.CancellationToken);

            await _client.StopAsync();
        }

        private async Task MessageHandle(SocketMessage message)
        {
            if (!(message is SocketUserMessage msg) || msg.Author.IsBot) return;

            var argPos = 0;
            if (!(msg.HasCharPrefix('!', ref argPos)) || msg.HasMentionPrefix(_client.CurrentUser, ref argPos)) return;
            var context = new CommandContext(_client, msg);

            await _command.ExecuteAsync(context, argPos, null);
        }
    }
}
