using TaskManagement.Admin.UpdateSettings.Validators;
using TaskManagement.Common.Validators;
using TaskManagement.Services;
using TaskManagement.Services.JsonService;

namespace TaskManagement.Common.Commands
{
    public abstract class BaseUpdateSettingsCommand : ICommandHandler
    {
        private BaseUserValidator _userValidator;

        public BaseUpdateSettingsCommand(BaseUserValidator userValidator)
        {
            _userValidator = userValidator;
        }

        public virtual void Handle()
        {
            UserService.CurrentUser.Name = _userValidator.GetAndValidateFirstName();
            UserService.CurrentUser.LastName = _userValidator.GetAndValidateLastName();
            UserService.CurrentUser.Password = _userValidator.GetAndValidatePassword();
            DataOfSerializationAndDeserialization.UsersDataFromRamToFolder();
            UserService.CurrentUser.UpdatedAt = DateTime.Now;
        }
    }
}
