
namespace Simple.Rabbit
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface ISubscriber : IDisposable
    {
        void Subscribe(Func<string, IDictionary<string, object>, bool> callback);
        void SubscribeAsync(Func<string, IDictionary<string, object>, Task<bool>> callback);
    }
}
