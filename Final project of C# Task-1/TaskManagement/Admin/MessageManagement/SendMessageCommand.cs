using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Client;
using TaskManagement.Client.Commands;
using TaskManagement.Common.Commands;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Admin.MessageManagement
{
    public class SendMessageCommand : ICommandHandler
    {
        public void Handle()
        {
            MessageRepository messageRepository = new MessageRepository();
            User user = ComposingOfMessages.AcceptAndConfirmReceiverEmail();
            string subject_Aze = ComposingOfMessages.AcceptAndConfirmMessageSubjectAze();
            string content_Aze = ComposingOfMessages.AcceptAndConfirmMessageContentAze();
            string subject_Rus = ComposingOfMessages.AcceptAndConfirmMessageSubjectRus();
            string content_Rus = ComposingOfMessages.AcceptAndConfirmMessageContentRus();
            string subject_Eng = ComposingOfMessages.AcceptAndConfirmMessageSubjectEng();
            string content_Eng = ComposingOfMessages.AcceptAndConfirmMessageContentEng();

            Message message = new Message(subject_Aze, subject_Rus, subject_Eng, content_Aze, content_Rus, content_Eng, UserService.CurrentUser, user);
        }
    }
}
