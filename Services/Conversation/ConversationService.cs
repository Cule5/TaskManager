using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Conversation.Factories;
using Core.Domain.Conversation.Repositories;
using Core.Domain.User.Repositories;
using Infrastructure.UnitOfWork;
using Services.Conversation.Dtos;

namespace Services.Conversation
{
    public class ConversationService:IConversationService
    {
        private readonly IConversationRepository _conversationRepository = null;
        private readonly IUserRepository _userRepository = null;
        private readonly IConversationFactory _conversationFactory = null;
        private readonly IUnitOfWork _unitOfWork = null;
        public ConversationService(IConversationRepository conversationRepository,IUserRepository userRepository,IUnitOfWork unitOfWork,IConversationFactory conversationFactory)
        {
            _conversationRepository = conversationRepository;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
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
            await _unitOfWork.SaveAsync();
        }

        public async System.Threading.Tasks.Task ChangeMessageStateAsync(int conversationId)
        {
            var dbConversation = await _conversationRepository.GetAsync(conversationId);
            dbConversation.ChangeStatus();
            await _unitOfWork.SaveAsync();
        }
    }
}
