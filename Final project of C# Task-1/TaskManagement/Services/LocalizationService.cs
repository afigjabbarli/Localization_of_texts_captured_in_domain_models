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
        
        
        public static SupportedCulture CurrentCulture { get; set; } = SupportedCulture.Rus;

        public static string GetTranslation(TranslationKey key)
        {
            Type translationConstantType = typeof(TranslationConstant);

            string fieldName = $"{key}_{CurrentCulture}";
            FieldInfo fieldInfo = translationConstantType.GetField(fieldName)!;

            return (string)fieldInfo.GetValue(fieldName)!;
        }

        public static string DisplayingBlogsTitleCurrentLanguage(TranslationKey key, int blogId)
        {

            string fieldNameTitle = $"{key}_{CurrentCulture}";
            foreach (Blog blog in DataContext.Blogs)
            {
                if (blog.Id == blogId)
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
        public static string DisplayingBlogsContentCurrentLanguage(TranslationKey key, int blogId)
        {
            string fieldNameContent = $"{key}_{CurrentCulture}";
            foreach (Blog blog in DataContext.Blogs)
            {
                if (blog.Id == blogId)
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
            

           


            

        
         






    



         





    }        

}
                        
                        
                        














