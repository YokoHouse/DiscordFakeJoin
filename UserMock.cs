using Discord;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class UserMock : IUser
{
    public ulong Id { get; } = 1234567890; 
    public string Username { get; } = "TestUser"; 
    public bool IsBot { get; } = false; 
    public string Mention => $"<@{Id}>"; 
    public UserStatus Status { get; } = UserStatus.Online; 
    public DateTimeOffset CreatedAt => DateTimeOffset.UtcNow;
    public string Discriminator { get; } = "0001"; 

    
    public IReadOnlyCollection<ClientType> ActiveClients => new List<ClientType>();  
    public IReadOnlyCollection<IActivity> Activities => new List<IActivity>();
    public string AvatarDecorationHash => ""; 
    public ulong? AvatarDecorationSkuId => null;
    public string AvatarId => ""; 
    public Task<IDMChannel> CreateDMChannelAsync(RequestOptions options = null) => Task.FromResult<IDMChannel>(null);
    public ushort DiscriminatorValue => 1; 
    public string GetAvatarDecorationUrl() => ""; 
    public string GetDefaultAvatarUrl() => ""; 
    public string GetDisplayAvatarUrl(ImageFormat format = ImageFormat.Auto, ushort size = 128) => ""; 
    public string GetAvatarUrl(ImageFormat format = ImageFormat.Auto, ushort size = 128) => ""; 
    public string GlobalName => ""; 
    public bool IsWebhook => false; 
    public UserProperties? PublicFlags => null;
}