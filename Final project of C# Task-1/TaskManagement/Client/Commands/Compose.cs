using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;
using TaskManagement.Services.JsonService;

namespace TaskManagement.Client.Commands
{
    public class Compose:ICommandHandler
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
            messageRepository.Insert(message);
            DataOfSerializationAndDeserialization.MessagesDataFromRamToFolder();
        }

        public static void CommentNotificationMessage(string blogCode)
        {
            MessageRepository messageRepository = new MessageRepository();
            foreach (User user in DataContext.Users)
            {
                if (user.Password.Equals("StudentOffice"))
                {

                    foreach (Blog blog in DataContext.Blogs)
                    {
                        if (blog.BlogCode.Equals(blogCode))
                        {
                            User userSystem = user;
                            string subject_Aze = "Bildirish";
                            string content_Aze = $"<<{blog.BlogCode}>> kodlu blogunuza <<{UserService.CurrentUser.Name}>> <<{UserService.CurrentUser.LastName}>> terefinden comment elave olundu.";
                            string subject_Rus = "Уведомление";
                            string content_Rus = $"Комментарий был добавлен пользователем <<{UserService.CurrentUser.Name}>> <<{UserService.CurrentUser.LastName}>> в ваш блог с кодом <<{blog.BlogCode}>>.";
                            string subject_Eng = "Notification";
                            string content_Eng = $"A comment was added by <<{UserService.CurrentUser.Name}>> <<{UserService.CurrentUser.LastName}>> to your blog with code <<{blog.BlogCode}>>.";

                            Message message = new Message(subject_Aze, subject_Rus, subject_Eng, content_Aze, content_Rus, content_Eng, userSystem, blog.Owner);
                            messageRepository.Insert(message);
                            DataOfSerializationAndDeserialization.MessagesDataFromRamToFolder();

                        }
                    }

                }

            }


        }
    }
}
