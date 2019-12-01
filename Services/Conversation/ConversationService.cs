using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Conversation.Factories;
using Core.Domain.Conversation.Repositories;
using Core.Domain.User.Repositories;
using Services.Conversation.Dtos;

namespace Services.Conversation
{
    public class ConversationService:IConversationService
    {
        private readonly IConversationRepository _conversationRepository = null;
        private readonly IUserRepository _userRepository = null;
        private readonly IConversationFactory _conversationFactory = null;
        public ConversationService(IConversationRepository conversationRepository,IUserRepository userRepository,IConversationFactory conversationFactory)
        {
            _conversationRepository = conversationRepository;
            _userRepository = userRepository;
            _conversationFactory = conversationFactory;
        }

        public async System.Threading.Tasks.Task SendMessageAsync(SendMessageDto sendMessageDto)
        {
            var sender=await _userRepository.GetAsync(sendMessageDto.SenderId);
            var receiver =await _userRepository.GetAsync(sendMessageDto.ReceiverId);
            var conversation = await _conversationFactory.CreateAsync(receiver, sender,sendMessageDto.Title ,sendMessageDto.Message);
            sender.SendedConversations.Add(conversation);
            receiver.ReceivedConversations.Add(conversation);
            await _conversationRepository.AddAsync(conversation);
        }

        public async System.Threading.Tasks.Task ChangeMessageStateAsync(int conversationId)
        {
            await _conversationRepository.GetAsync(conversationId);
        }
    }
}
