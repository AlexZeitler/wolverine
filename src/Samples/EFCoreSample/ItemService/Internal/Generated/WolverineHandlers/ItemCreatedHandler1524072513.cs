// <auto-generated/>
#pragma warning disable

namespace Internal.Generated.WolverineHandlers
{
    // START: ItemCreatedHandler1524072513
    public class ItemCreatedHandler1524072513 : Wolverine.Runtime.Handlers.MessageHandler
    {


        public override System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            var itemCreatedHandler = new ItemService.ItemCreatedHandler();
            // The actual message body
            var itemCreated = (ItemService.ItemCreated)context.Envelope.Message;

            
            // The actual message execution
            itemCreatedHandler.Handle(itemCreated);

            return System.Threading.Tasks.Task.CompletedTask;
        }
    }

    // END: ItemCreatedHandler1524072513
    
    
}