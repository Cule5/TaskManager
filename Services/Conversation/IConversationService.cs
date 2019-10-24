using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Conversation
{
    public interface IConversationService
    {
        System.Threading.Tasks.Task SendMessageAsync();
    }
}
