using System.Threading;
using System.Threading.Tasks;
using Shared.Abstractions.Messaging;

namespace Shared.Infrastructure.Messaging.Dispatchers;

internal sealed class AsyncMessageDispatcher : IAsyncMessageDispatcher
{
    private readonly IMessageChannel _channel;
    private readonly IMessageContextProvider _messageContextProvider;

    public AsyncMessageDispatcher(IMessageChannel channel, IMessageContextProvider messageContextProvider)
    {
        _channel = channel;
        _messageContextProvider = messageContextProvider;
    }

    public async Task PublishAsync<T>(T message, CancellationToken cancellationToken = default)
        where T : class, IMessage
    {
        var messageContext = _messageContextProvider.Get(message);
        await _channel.Writer.WriteAsync(new MessageEnvelope(message, messageContext), cancellationToken);
    }
}