namespace Simple.Rabbit
{
    using System;
    using System.Collections.Generic;
    public interface IPublisher : IDisposable
    {
        void Publish(string message, string routingKey, IDictionary<string, object> messageAttributes, string? timeToLive = null);
    }
}
