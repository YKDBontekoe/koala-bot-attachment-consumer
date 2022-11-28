namespace Koala.AttachmentConsumerService.Options;

public class ServiceBusOptions
{
    public const string ServiceBus = "ServiceBus";
    
    public string ConnectionString { get; set; }
    
    public string AttachmentConsumerQueueName { get; set; }
}