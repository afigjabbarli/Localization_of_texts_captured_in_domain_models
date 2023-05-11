using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Client.Commands;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;

namespace TaskManagement.Services
{
    public class MessageService
    {
        private MessageRepository _messageRepository;

        public MessageService()
        {
            _messageRepository = new MessageRepository();
        }

        public void SenApprovedMessage(Blog blog)
        {
            string approvedMessage = PrepareBlogMessage(MessageTemplate.BLOG_APPROVED_TEMPLATE, blog);
            SendMessage(approvedMessage, blog.Owner);
        }

        public void SendRejectedMessage(Blog blog)
        {
            string rejectedMessage = PrepareBlogMessage(MessageTemplate.BLOG_REJECTED_TEMPLATE, blog);
            SendMessage(rejectedMessage, blog.Owner);
        }

        private string PrepareBlogMessage(string blogMessageTemplate, Blog blog)
        {
            return blogMessageTemplate
              .Replace(MessageTemplateKeyword.FIRST_NAME, blog.Owner.Name)
              .Replace(MessageTemplateKeyword.LAST_NAME, blog.Owner.LastName)
              .Replace(MessageTemplateKeyword.BLOG_TITLE, blog.Title_Aze);
        }

        public void SendMessage(string message, User sender, User receiver)
        {
            User user = ComposingOfMessages.AcceptAndConfirmReceiverEmail();
            string subject_Aze = ComposingOfMessages.AcceptAndConfirmMessageSubjectAze();
            string content_Aze = ComposingOfMessages.AcceptAndConfirmMessageContentAze();
            string subject_Rus = ComposingOfMessages.AcceptAndConfirmMessageSubjectRus();
            string content_Rus = ComposingOfMessages.AcceptAndConfirmMessageContentRus();
            string subject_Eng = ComposingOfMessages.AcceptAndConfirmMessageSubjectEng();
            string content_Eng = ComposingOfMessages.AcceptAndConfirmMessageContentEng();
            Message messageRecord = new Message(subject_Aze, content_Rus, subject_Eng, content_Aze, subject_Rus, content_Eng , sender, receiver);
            _messageRepository.Insert(messageRecord);
        }

        /// <summary>
        /// Sender will be current logged user
        /// </summary>
        public void SendMessage(string message, User receiver)
        {
            SendMessage(message, UserService.CurrentUser, receiver);
        }
    }
}
