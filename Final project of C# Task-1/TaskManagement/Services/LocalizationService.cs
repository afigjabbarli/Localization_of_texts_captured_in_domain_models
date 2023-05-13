using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Exceptions;
using TaskManagement.Utilities;

namespace TaskManagement.Services
{
    public class LocalizationService
    {
        
        
        public static SupportedCulture CurrentCulture { get; set; } = SupportedCulture.Aze;

        public static string GetTranslation(TranslationKey key)
        {
            Type translationConstantType = typeof(TranslationConstant);

            string fieldName = $"{key}_{CurrentCulture}";
            FieldInfo fieldInfo = translationConstantType.GetField(fieldName)!;

            return (string)fieldInfo.GetValue(fieldName)!;
        }

        public static string DisplayingBlogsTitleCurrentLanguage(TranslationKey key, string blogCode)
        {

            string fieldNameTitle = $"{key}_{CurrentCulture}";
            foreach (Blog blog in DataContext.Blogs)
            {
                if (blog.BlogCode == blogCode)
                {
                    PropertyInfo info = blog.GetType().GetProperty(fieldNameTitle)!;
                    Type type = typeof(Blog);
                    if (info.Name == fieldNameTitle)
                    {
                        return (string)type.GetProperty(fieldNameTitle)?.GetValue(blog)!;
                    }
                }
            }
            return LocalizationService.GetTranslation(TranslationKey.blogTitle);

        }
        public static string DisplayingBlogsContentCurrentLanguage(TranslationKey key, string blogCode)
        {
            string fieldNameContent = $"{key}_{CurrentCulture}";
            foreach (Blog blog in DataContext.Blogs)
            {
                if (blog.BlogCode == blogCode)
                {
                    PropertyInfo info = blog.GetType().GetProperty(fieldNameContent)!;
                    Type type = typeof(Blog);
                    if (info.Name == fieldNameContent)
                    {
                       return (string)type.GetProperty(fieldNameContent)?.GetValue(blog)!;
                    }
                }
            }
            return LocalizationService.GetTranslation(TranslationKey.blogContent);
        }

        public static string DisplayingAllBlogsTitleCurrentLanguage(TranslationKey key, DateTime createdAt)
        {

            string fieldNameTitle = $"{key}_{CurrentCulture}";
            foreach (Blog blog in DataContext.Blogs)
            {
                
                 if(blog.CreatedAt == createdAt)
                 {
                    PropertyInfo info = blog.GetType().GetProperty(fieldNameTitle)!;
                    Type type = typeof(Blog);
                    if (info.Name == fieldNameTitle)
                    {
                        return (string)type.GetProperty(fieldNameTitle)?.GetValue(blog)!;
                    }


                 }
                
            }
            return LocalizationService.GetTranslation(TranslationKey.blogTitle);

        }

        public static string DisplayingMessagesSubjectCurrentLanguage(TranslationKey key, int MessageId)
        {
            string fieldNameSubject = $"{key}_{CurrentCulture}";
            foreach (Message message in DataContext.Messages)
            {
                if (message.Id == MessageId)
                {
                    PropertyInfo info = message.GetType().GetProperty(fieldNameSubject)!;
                    Type type = typeof(Message);
                    if (info.Name == fieldNameSubject)
                    {
                        return (string)type.GetProperty(fieldNameSubject)?.GetValue(message)!;
                    }
                }
            }
            return LocalizationService.GetTranslation(TranslationKey.messageSubject);
        }

        public static string DisplayingMessagesContentCurrentLanguage(TranslationKey key, int MessageId)
        {
            string fieldNameContent = $"{key}_{CurrentCulture}";
            foreach (Message message in DataContext.Messages)
            {
                if (message.Id == MessageId)
                {
                    PropertyInfo info = message.GetType().GetProperty(fieldNameContent)!;
                    Type type = typeof(Blog);
                    if (info.Name == fieldNameContent)
                    {
                        return (string)type.GetProperty(fieldNameContent)?.GetValue(message)!;
                    }
                }
            }
            return LocalizationService.GetTranslation(TranslationKey.messageContent);

        }
        public static string DisplayingAllMessagesSubjectCurrentLanguage(TranslationKey key, DateTime createdAt)
        {
            string fieldNameSubject = $"{key}_{CurrentCulture}";
            foreach (Message message in DataContext.Messages)
            {

                if (message.CreatedAt == createdAt)
                {
                    PropertyInfo info = message.GetType().GetProperty(fieldNameSubject)!;
                    Type type = typeof(Message);
                    if (info.Name == fieldNameSubject)
                    {
                        return (string)type.GetProperty(fieldNameSubject)?.GetValue(message)!;
                    }


                }

            }
            return LocalizationService.GetTranslation(TranslationKey.messageSubject);
        }
        














    }        

}
                        
                        
                        














