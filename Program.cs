using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

class Program
{
    private DiscordSocketClient _client;

    static async Task Main(string[] args) => await new Program().RunBotAsync();

    public async Task RunBotAsync()
    {
        var config = new DiscordSocketConfig
        {
            GatewayIntents = GatewayIntents.Guilds | 
                             GatewayIntents.GuildMembers | 
                             GatewayIntents.GuildMessages 
        };

        _client = new DiscordSocketClient(config);

        _client.Log += Log; 
        _client.Ready += OnReady;

        var token = ""; 
        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();

        await Task.Delay(-1); // Държи програмата отворена
    }

    private async Task OnReady()
    {
        Console.WriteLine("✅ Ботът е онлайн!");

        var sendWelcomeMessages = true; 
        var test = new FakeUserJoinedTest(_client, sendWelcomeMessages);
        await test.SimulateUserJoin();
    }

    private Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }
}