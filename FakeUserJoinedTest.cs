using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

public class FakeUserJoinedTest
{
    private readonly DiscordSocketClient _client;
    private readonly bool _sendWelcomeMessages;

    public FakeUserJoinedTest(DiscordSocketClient client, bool sendWelcomeMessages)
    {
        _client = client;
        _sendWelcomeMessages = sendWelcomeMessages; 
    }
    
    public async Task SimulateUserJoin()
    {
        var fakeUser = new UserMock(); // Симулираме потребител
        await SimulateUserJoinPeriodically(fakeUser); 
    }

    
    private async Task SimulateUserJoinPeriodically(IUser user)
    {
        
        if (!_sendWelcomeMessages)
        {
            Console.WriteLine("❌ Изпращането на съобщения е изключено.");
            return;
        }

        // Замени с ID на твоя канал
        var channel = _client.GetChannel(chanelid - взима се от Discord) as SocketTextChannel;  // Използвай правилния канал ID

        if (channel == null)
        {
            Console.WriteLine("❌ Каналът не е намерен или ботът няма разрешение за достъп.");
            return;
        }

        
        for (int i = 0; i < 10; i++) 
        {
            await channel.SendMessageAsync($"{user.Username} се присъедини към сървъра!"); // Изпращаме съобщение в канала
            await Task.Delay(10000); 
        }
    }
}s