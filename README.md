# Plain Rabbitmq

Base Rabbitmq demo wrapper around RabbitMQ.Client encapsulating the boilerplate code.

## Installation

## Usage

DI Registration

```csharp
services.AddSingleton<IConnectionProvider>(new ConnectionProvider("Queue Url"));
services.AddSingleton<ISubscriber>(x => new Subscriber(x.GetService<IConnectionProvider>(),
	"exchange name",
    "queue name",
    "routing key",
    ExchangeType.Topic));
services.AddScoped<IPublisher>(x => new Publisher(x.GetService<IConnectionProvider>(),
	"exchange name",
    ExchangeType.Topic));
```

Publisher

```csharp
publisher.Publish(JsonConvert.SerializeObject(object), "routing key", headers);
```

Subscriber
```csharp
subscriber.Subscribe((message, header) => {
    Console.WriteLine(message);
    return true;
});
```

Async Subscriber
```csharp
subscriber.SubscribeAsync(async (message, header) => {
    Console.WriteLine(message);
    return await Task.FromResult(true);
});
```

## License
[MIT](https://choosealicense.com/licenses/mit/)
