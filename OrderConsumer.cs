using MassTransit;
using Store_1.Model;

internal class OrderConsumer : IConsumer<Product>
{
    public async Task Consume(ConsumeContext<Product> context)
    {
        await Console.Out.WriteLineAsync(context.Message.productName);
    }
}