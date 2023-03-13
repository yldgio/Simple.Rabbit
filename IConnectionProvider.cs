namespace Simple.Rabbit
{
    using RabbitMQ.Client;
    using System;
    public interface IConnectionProvider : IDisposable
    {
        IConnection GetConnection();
    }
}
