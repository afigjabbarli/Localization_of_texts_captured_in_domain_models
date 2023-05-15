using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Client.Commands;
using TaskManagement.Database.Models;

namespace TaskManagement.Contants
{
    public static class TranslationConstant
    {
        //public const string AccountBlocked_Aze = "Your account blocked aze";
        //public const string AccountBlocked_Rus = "Your account blocked rus";
        //public const string AccountBlocked_Eng = "Your account blocked eng";

        //public const string GetAdminName_Aze = "User pls enter your name aze:";
        //public const string GetAdminName_Rus = "User pls enter your name rus:";
        //public const string GetAdminName_Eng = "User pls enter your name eng:";

        public const string Blogs_Aze = "Bloglar menyusu";
        public const string Blogs_Rus = "Меню блогов";
        public const string Blogs_Eng = "Blogs menu";

        public const string Blogs_TitleAz_Aze = "Zehmet olmasa blogun bashlighini yazin(In Azerbaijani)";
        public const string Blogs_TitleAz_Rus = "Пожалуйста, напишите название блога(In Azerbaijani)";
        public const string Blogs_TitleAz_Eng = "Please write the title of the blog(In Azerbaijani)";

        public const string Blogs_TitleRu_Aze = "Zehmet olmasa blogun bashlighini yazin(In Russian)";
        public const string Blogs_TitleRu_Rus = "Пожалуйста, напишите название блога(In Russian)";
        public const string Blogs_TitleRu_Eng = "Please write the title of the blog(In Russian)";

        public const string Blogs_TitleEn_Aze = "Zehmet olmasa blogun bashlighini yazin(In English)";
        public const string Blogs_TitleEn_Rus = "Пожалуйста, напишите название блога(In English)";
        public const string Blogs_TitleEn_Eng = "Please write the title of the blog(In English)";

        public const string Titles_Aze = "Bloq başlığı:";
        public const string Titles_Rus = "Название блога:";
        public const string Titles_Eng = "Blog`s title:";

        public const string Blogs_ContentAz_Aze = "Zehmet olmasa blogun mezmununu yazin(In Azerbaijani):";
        public const string Blogs_ContentAz_Rus = "Пожалуйста, напишите содержание блога (In Azerbaijani):";
        public const string Blogs_ContentAz_Eng = "Please write the content of the blog (In Azerbaijani):";

        public const string Blogs_ContentRu_Aze = "Zehmet olmasa blogun mezmununu yazin(In Russian):";
        public const string Blogs_ContentRu_Rus = "Пожалуйста, напишите содержание блога (In Russian):";
        public const string Blogs_ContentRu_Eng = "Please write the content of the blog (In Russian):";

        public const string Blogs_ContentEn_Aze = "Zehmet olmasa blogun mezmununu yazin(In English):";
        public const string Blogs_ContentEn_Rus = "Пожалуйста, напишите содержание блога (In English):";
        public const string Blogs_ContentEn_Eng = "Please write the content of the blog (In English):";

        public const string Incorrect_Information_Aze = "Daxil edilen melumat sehvdir! Xahish edirik yeniden daxil edin...";
        public const string Incorrect_Information_Rus = "Введенная информация неверна! Пожалуйста, введите еще раз...";
        public const string Incorrect_Information_Eng = "The information entered is incorrect! Please re-enter...";

        public const string blogTitle_Aze = "Bloq başlığı tapılmadı! Zehmet olmasa nömreni yeniden daxil edin...";
        public const string blogTitle_Rus = "Название блога не найдено! Пожалуйста, введите номер еще раз...";
        public const string blogTitle_Eng = "Blog title not found! Please re-enter the number...";

        public const string blogContent_Aze = "Bloq mezmunu tapılmadı! Nomreni yeniden daxil edin...";
        public const string blogContent_Rus = "Содержимое блога не найдено! Пожалуйста, введите номер еще раз...";
        public const string blogContent_Eng = "Blog content not found! Please re-enter the number...";

        public const string messageSubject_Aze = "Mesaj başlığı tapılmadı! Zehmet olmasa nömreni yeniden daxil edin...";
        public const string messageSubject_Rus = "Название cообщение не найдено! Пожалуйста, введите номер еще раз...";
        public const string messageSubject_Eng = "Message subject not found! Please re-enter the number...";

        public const string messageContent_Aze = "Mesaj mezmunu tapılmadı! Nomreni yeniden daxil edin...";
        public const string messageContent_Rus = "Содержимое cообщение не найдено! Пожалуйста, введите номер еще раз...";
        public const string messageContent_Eng = "Message content not found! Please re-enter the number...";


        public const string shownCommand_Aze = "Zehmet olmasa ekranda gosterilen emrlerden birini sechin.";
        public const string shownCommand_Rus = "Пожалуйста, выберите одну из команд, показанных на экране.";
        public const string shownCommand_Eng = "Please choose one of the commands shown on the screen.";

        public const string registerCommand_Aze = "Qeydiyyat";
        public const string registerCommand_Rus = "Регистр";
        public const string registerCommand_Eng = "Register";

        public const string loginCommand_Aze = "Girish";
        public const string loginCommand_Rus = "Авторизоваться";
        public const string loginCommand_Eng = "Login";

        public const string languageCommand_Aze = "Dil sechimleri";
        public const string languageCommand_Rus = "языковые опции";
        public const string languageCommand_Eng = "Update language";

        public const string Exit_Aze = "Chixish";
        public const string Exit_Rus = "Выход";
        public const string Exit_Eng = "Exit";

        public const string InputCommand_Aze = "Emr:" + " ";
        public const string InputCommand_Rus = "команда:" + " ";
        public const string InputCommand_Eng = "Command:" + " ";

        public const string ByeBye_Aze = "Sagh ol";
        public const string ByeBye_Rus = "Пока-пока";
        public const string ByeBye_Eng = "Bye-bye";

        public const string Invalid_Command_Aze = "Yanlısh emr, xahish edirem yeniden cehd edin";
        public const string Invalid_Command_Rus = "Неверная команда, пожалуйста, попробуйте еще раз";
        public const string Invalid_Command_Eng = "Invalid command, pls try again";

        public const string Enter_FirstName_Aze = "Zehmet olmasa adinizi daxil edin:";
        public const string Enter_FirstName_Rus = "Пожалуйста, введите Ваше имя:";
        public const string Enter_FirstName_Eng = "Please enter your name:";

        public const string Enter_LastName_Aze = "Zehmet olmasa soyadinizi daxil edin:";
        public const string Enter_LastName_Rus = "Пожалуйста, введите свою фамилию:";
        public const string Enter_LastName_Eng = "Please enter your last name:";

        public const string Enter_Password_Aze = "Zehmet olmasa shifrenizi daxil edin:";
        public const string Enter_Password_Rus = "Пожалуйста введите ваш пароль:";
        public const string Enter_Password_Eng = "Please enter your password:";

        public const string Enter_ConfirmPassword_Aze = "Zehmet olmasa tesdiq shifrenizi daxil edin:";
        public const string Enter_ConfirmPassword_Rus = "Пожалуйста, введите проверочный код:";
        public const string Enter_ConfirmPassword_Eng = "Please enter your verification code:";

        public const string Enter_Email_Aze = "Zehmet olmasa elektron pocht unvaninizi daxil edin:";
        public const string Enter_Email_Rus = "Пожалуйста, введите Ваш адрес электронной почты:";
        public const string Enter_Email_Eng = "Please enter your email address:";

        public const string Unique_Email_Aze = "Bu email artiq sistmede movcuddur!!!";
        public const string Unique_Email_Rus = "Этот адрес электронной почты уже доступен в системе!!!";
        public const string Unique_Email_Eng = "This email is already available in the system!!!";

        public const string Email_Format_Aze = "Sizin email formata uyghun deyil. Format: Metn(yalniz boyuk ve kichik herfler, reqemler)/@/code.edu.az";
        public const string Email_Format_Rus = "Ваш адрес электронной почты не соответствует формату. Формат: Текст (только прописные и строчные буквы, цифры)/@/code.edu.az";
        public const string Email_Format_Eng = "Your email does not match the format. Format: Text (only upper and lower case letters, numbers)/@/code.edu.az";

        public const string Hello_Admin_Aze = "Salamlar hormetli admin";
        public const string Hello_Admin_Rus = "привет дорогой админ";
        public const string Hello_Admin_Eng = "Hello dear admin";

        public const string Show_Users_Aze = "Istifadechilerin gosterilmesi";
        public const string Show_Users_Rus = "показ пользователей";
        public const string Show_Users_Eng = "Show-users";

        public const string Show_Users_ByEmail_Aze = "Istifadechilerin emaile uyghun gosterilmesi";
        public const string Show_Users_ByEmail_Rus = "показ пользователей по электронной почте";
        public const string Show_Users_ByEmail_Eng = "Show-user-by-email";

        public const string Show_Users_ById_Aze = "Istifadechilerin identifikasiya koduna uyghun gosterilmesi";
        public const string Show_Users_ById_Rus = "Отображение в соответствии с идентификационным кодом пользователя";
        public const string Show_Users_ById_Eng = "Show-user-by-id";

        public const string Add_User_Aze = "Istifadechi elave etmek";
        public const string Add_User_Rus = "Добавить пользователя";
        public const string Add_User_Eng = "Add-user";

        public const string Promote_Admin_Aze = "Istifadechinin admin olunmasi";
        public const string Promote_Admin_Rus = "Делаем пользователя админом";
        public const string Promote_Admin_Eng = "Promote-to-admin";

        public const string DePromote_FromAdmin_Aze = "Istifadechinin adminlikden chixarilmasi";
        public const string DePromote_FromAdmin_Rus = "Удаление пользователя из администрации";
        public const string DePromote_FromAdmin_Eng = "Depromote-from-admin";

        public const string Update_Settings_Aze = "Yeniləmə-parametrlər";
        public const string Update_Settings_Rus = "Обновить настройки";
        public const string Update_Settings_Eng = "Update-settings";

            
        public const string Remove_User_Aze = "Istifadechinin silinmesi";
        public const string Remove_User_Rus = "Удалить пользователя";
        public const string Remove_User_Eng = "Remove-user";

        public const string Block_User_Aze = "Istifadechinin bloklanmasi";
        public const string Block_User_Rus = "Блокировать пользователя";
        public const string Block_User_Eng = "Block-user";

        public const string Message_To_Aze = "Mesaj gonderilmesi";
        public const string Message_To_Rus = "Сообщение для";
        public const string Message_To_Eng = "Message-to";

        public const string Logout_Aze = "Chixish";
        public const string Logout_Rus = "Выйти";
        public const string Logout_Eng = "Logout";

        public const string Show_Users_From_Register_Date_Aze = "Istifadechilerin daxil edilen tarixden gosterilmesi";
        public const string Show_Users_From_Register_Date_Rus = "Отображение пользователей с введенной даты";
        public const string Show_Users_From_Register_Date_Eng = "Showing users from the entered date";

        public const string Registr_Date_Aze = "Qeydiyyat tarixi:";
        public const string Registr_Date_Rus = "Дата регистрации:";
        public const string Registr_Date_Eng = "Register date:";

        public const string Email_Not_Aze = "E-poçt tapılmadı";
        public const string Email_Not_Rus = "Электронная почта не найдена";
        public const string Email_Not_Eng = "Email not found";

        public const string Invalid_Input_Aze = "Yanlış daxil edilmish melumat! Lütfen yeniden cehd edin";
        public const string Invalid_Input_Rus = "Неверный ввод, пожалуйста, попробуйте еще раз";
        public const string Invalid_Input_Eng = "Invalid input pls try again";

        public const string Input_User_Id_Aze = "Zehmet olmasa istifadeçi ID-sini daxil edin:";
        public const string Input_User_Id_Rus = "Пожалуйста, введите идентификатор пользователя:";
        public const string Input_User_Id_Eng = "Please enter user ID:";

        public const string User_Not_Aze = "Istifadechi tapilmadi";
        public const string User_Not_Rus = "Пользователь не найден";
        public const string User_Not_Eng = "User not found";

        public const string Already_Admin_Aze = "İstifadeçi artıq admindir";
        public const string Already_Admin_Rus = "Пользователь уже является админом";
        public const string Already_Admin_Eng = "User is already is admin";

        public const string From_User_To_Admin_Aze = "İstifadeçi müveffeqiyyetle admin vezifesine yükseldi!";
        public const string From_User_To_Admin_Rus = "Пользователь успешно повышен до администратора!";
        public const string From_User_To_Admin_Eng = "User succussfully promoted to admin!";

        public const string Cant_yourself_Aze = "Özünüz edə bilməzsiniz";
        public const string Cant_yourself_Rus = "Вы не можете сами";
        public const string Cant_yourself_Eng = "You can't yourself";

        public const string Already_Standart_Aze = "İstifadechi artıq standartdır";
        public const string Already_Standart_Rus = "Пользователь уже стандартный";
        public const string Already_Standart_Eng = "User is already standart";

        public const string From_Admin_To_User_Aze = "Admin muveffeqiyyetle adminden istifadechiye chevrildi!";
        public const string From_Admin_To_User_Rus = "Администратор успешно понижен в статусе администратора до пользователя!";
        public const string From_Admin_To_User_Eng = "Admin succussfully depromoted from admin to user!";

        public const string Cant_Remove_Admin_Aze = "Istifadechi admindir.Siz onu sile bilmezsiz";
        public const string Cant_Remove_Admin_Rus = "Пользователь является администратором, которого вы не можете удалить.";
        public const string Cant_Remove_Admin_Eng = "User is admin you can't remove";

        public const string Cant_Ban_Admin_Aze = "Istifadechi admindir.Ona qadagha qoya bilmezsiniz!";
        public const string Cant_Ban_Admin_Rus = "Пользователь админ, его нельзя забанить";
        public const string Cant_Ban_Admin_Eng = "User is admin you can't ban him!";

        public const string Hello_User_Aze = "Salam, hormetli istifadechi :";
        public const string Hello_User_Rus = "Привет! дорогой пользователь :";
        public const string Hello_User_Eng = "Hello! dear user :";

        public const string Welcome_User_Menu_Aze = "Istifadechi menyusuna xosh gelmisiz...";
        public const string Welcome_User_Menu_Rus = "Добро пожаловать в меню пользователя...";
        public const string Welcome_User_Menu_Eng = "Welcome to the user menu...";

        public const string Update_Settings_Command_Aze = "Parametrleri yenilemek";
        public const string Update_Settings_Command_Rus = "Команда обновления настроек";
        public const string Update_Settings_Command_Eng = "Update settings command";

        public const string Close_Account_Command_Aze = "Hesabi baghlamaq";
        public const string Close_Account_Command_Rus = "Команда закрытия учетной записи";
        public const string Close_Account_Command_Eng = "Close Account Command";

        public const string Message_Management_Aze = "Mesajlarin idare olunmasi paneli";
        public const string Message_Management_Rus = "Панель управления сообщениями";
        public const string Message_Management_Eng = "Message Management Panel";

        public const string Blog_Management_Aze = "Bloglarin idare olunmasi paneli";
        public const string Blog_Management_Rus = "Панель управления блогом";
        public const string Blog_Management_Eng = "Blog Management Panel";

        public const string Blog_Management_Panel_Aze = "Bloq İdarəetmə Paneli";
        public const string Blog_Management_Panel_Rus = "Панель управления блогом";
        public const string Blog_Management_Panel_Eng = "Blog Management Panel";

        public const string Command_Not_Found_Aze = "Bu emr menyuda yoxdur! Lutfen, yeniden daxil olun...";
        public const string Command_Not_Found_Rus = "Этой команды нет в меню! Пожалуйста, введите еще раз...";
        public const string Command_Not_Found_Eng = "This command is not in the menu! Please re-enter...";

        public const string Invalid_Password_Aze = "Etibarsız parol";
        public const string Invalid_Password_Rus = "Неверный пароль";
        public const string Invalid_Password_Eng = "Invalid passowrd";

        public const string Inbox_Aze = "Gelenler qutusu";
        public const string Inbox_Rus = "Входящие";
        public const string Inbox_Eng = "Inbox";

        public const string Sent_Aze = "Gonderildi";
        public const string Sent_Rus = "Отправил";
        public const string Sent_Eng = "Sent";

        public const string Compose_Aze = "Yaz";
        public const string Compose_Rus = "Написать";
        public const string Compose_Eng = "Compose";

        public const string List_Rec_Messages_Aze = "Qebul edilen mesajların siyahısı";
        public const string List_Rec_Messages_Rus = "Список полученных сообщений";
        public const string List_Rec_Messages_Eng = "List of received messages";

        public const string Mes_Sen_FullName_Aze = "Mesaj gonderenin tam adı:";
        public const string Mes_Sen_FullName_Rus = "Имя и фамилия отправителя сообщения:";
        public const string Mes_Sen_FullName_Eng = "Message sender fullname:";

        public const string Mes_Sen_Email_Aze = "Mesaj gonderenin elektron pocht unvani:";
        public const string Mes_Sen_Email_Rus = "Адрес электронной почты отправителя сообщения:";
        public const string Mes_Sen_Email_Eng = "Email address of the message sender:";

        public const string Mes_Subject_Aze = "Mesajın movzusu:";
        public const string Mes_Subject_Rus = "Тема сообщения:";
        public const string Mes_Subject_Eng = "Message subject:";

        public const string Mes_Crt_Dt_Aze = "Mesajın yaradılma tarixi:";
        public const string Mes_Crt_Dt_Aze_Rus = "Дата создания сообщения:";
        public const string Mes_Crt_Dt_Aze_Eng = "Message created date:";

        public const string Mes_Cur_Row_Nmb_Aze = "Mesajin cari sira nomresi:";
        public const string Mes_Cur_Row_Nmb_Rus = "Номер текущей строки сообщения:";
        public const string Mes_Cur_Row_Nmb_Eng = "Message current row number:";

        public const string List_Sen_Messages_Aze = "Gonderilen mesajların siyahısı";
        public const string List_Sen_Messages_Rus = "Список отправленных сообщений";
        public const string List_Sen_Messages_Eng = "List of sent messages";

        public const string Mes_Rec_FullName_Aze = "Mesaj qebuledicisinin tam adı:";
        public const string Mes_Rec_FullName_Rus = "Полное имя получателя сообщения:";
        public const string Mes_Rec_FullName_Eng = "Message receiver fullname:";

        public const string Mes_Rec_Email_Aze = "Mesaj qebul edenin e-poçtu:";
        public const string Mes_Rec_Email_Rus = "Электронная почта получателя сообщения::";
        public const string Mes_Rec_Email_Eng = "Message receiver email:";

        public const string Pls_Enter_Email_Of_Rec_Aze = "Zehmet olmasa qebuledicinin e-pochtunu daxil edin:";
        public const string Pls_Enter_Email_Of_Rec_Rus = "Пожалуйста, введите адрес электронной почты получателя:";
        public const string Pls_Enter_Email_Of_Rec_Eng = "Please enter eMail of receiver:";

        public const string This_Aze = "Bu";
        public const string This_Rus = "Этот";
        public const string This_Eng = "This";

        public const string User_Alr_Blck_Aze = "istifadechi artıq bloklanıb və siz ona mesaj göndere bilmezsiniz...";
        public const string User_Alr_Blck_Rus = "пользователь уже заблокирован и вы не можете отправить ему сообщение...";
        public const string User_Alr_Blck_Eng = "user is already blocked and you cannot send him a message...";

        public const string No_For_This_Email_Aze = "Bu e-poçt uchun hech bir istifadechi tapılmadı! E-pochtu yeniden daxil edin...";
        public const string No_For_This_Email_Rus = "Для этого письма не найдено ни одного пользователя! Пожалуйста, введите адрес электронной почты еще раз...";
        public const string No_For_This_Email_Eng = "No user found for this email! Please re-enter the email...";

        public const string Message_Id_Aze = "Mesaj ID";
        public const string Message_Id_Rus = "Идентификатор сообщения";
        public const string Message_Id_Eng = "Message ID";

        public const string Message_Input_Content_Aze = "Mesajin metni:";
        public const string Message_Input_Content_Rus = "Содержание сообщения";
        public const string Message_Input_Content_Eng = "Message`s content";

        public const string show_Blogs_With_Comments_Aze = "Bloglari sherhlerle birge gosterin";
        public const string show_Blogs_With_Comments_Rus = "Показать блоги с комментариями";
        public const string show_Blogs_With_Comments_Eng = "Show blogs with comments";

        public const string ChooseLanguageCommand_Aze = "Zehmet olmasa uyghun dili sechin:";
        public const string ChooseLanguageCommand_Rus = "Выберите подходящий язык:";
        public const string ChooseLanguageCommand_Eng = "Please choose the appropriate language:";

        public const string EngLanguage_Aze = "Ingilis dili";
        public const string EngLanguage_Rus = "Английский язык";
        public const string EngLanguage_Eng = "English Language";

        public const string RusLanguage_Aze = "Rus dili";
        public const string RusLanguage_Rus = "Русский язык";
        public const string RusLanguage_Eng = "Russian Language";

        public const string AzeLanguage_Aze = "Azerbaycan dili";
        public const string AzeLanguage_Rus = "азербайджанский язык";
        public const string AzeLanguage_Eng = "Azerbaijani Language";

        public const string Empty_Blog_Box_Aze = "Bloq qutusu hazırda boshdur...";
        public const string Empty_Blog_Box_Rus = "В настоящее время окно блога пусто...";
        public const string Empty_Blog_Box_Eng = "The blog box is currently empty...";

        public const string Comments_Aze = "Sherhler:";
        public const string Comments_Rus = "Комментарии:";
        public const string Comments_Eng = "Comments:";

        public const string Rej_Blog_Com_Aze = "Bloqlarin Tesdiq Edilmemesi";
        public const string Rej_Blog_Com_Rus = "Отказ от блогов";
        public const string Rej_Blog_Com_Eng = "Reject Blog Command";

        public const string App_Blog_Com_Aze = "Bloglarin Tesdiq Olunmasi";
        public const string App_Blog_Com_Rus = "Одобрение блогов";
        public const string App_Blog_Com_Eng = "Approve Blog Command";

        public const string Show_Crt_Blog_Com_Aze = "Yaradılmış Bloqlarin Gosterilmesi Komandasi";
        public const string Show_Crt_Blog_Com_Rus = "Команда Показать созданные блоги";
        public const string Show_Crt_Blog_Com_Eng = "Show Created Blogs Command";

        public const string Rej_And_App_By_Admin_Aze = "Hormetli admin, zehmet olmasa bloq kodunu daxil edin:" + " ";
        public const string Rej_And_App_By_Admin_Rus = "Уважаемый администратор, пожалуйста, введите код блога:" + " ";
        public const string Rej_And_App_By_Admin_Eng = "Dear admin, pls enter blogcode:" + " ";

        public const string Blg_Not_Found_Aze = "Bloq tapılmadı";
        public const string Blg_Not_Found_Rus = "Блог не найден";
        public const string Blg_Not_Found_Eng = "Blog not found";

        public const string Add_Blg_Com_Aze = "Blog elave edin";
        public const string Add_Blg_Com_Rus = "Добавить блог";
        public const string Add_Blg_Com_Eng = "Add Blog Command";

        public const string Dis_Crt_Blgs_Aze = "Yaradılmısh Bloqların Gosterilmesi";
        public const string Dis_Crt_Blgs_Rus = "Отображение созданных блогов";
        public const string Dis_Crt_Blgs_Eng = "Display of Created Blogs";

        public const string Add_Comment_Aze = "Sherh elave et";
        public const string Add_Comment_Rus = "Добавить комментарий";
        public const string Add_Comment_Eng = "Add Comment";

    }





}
