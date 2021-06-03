using System;
using System.Collections.Generic;

using SensitiveInformationConsole.Src.Validators;
using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationConsole.Src.Containers;

namespace SensitiveInformationConsole.Src.Handlers
{
    internal class HandlerRemove : IHandler
    {
        internal HandlerRemove()
        {
        }

        public void Handle(List<string> listArgs)
        {
            ValidatorArgument.Validate(listArgs);
            ValidatorOptionCommandKey.Validate(listArgs[0]);
            string optionCommand = listArgs[0];
            listArgs.RemoveAt(0);
            ValidatorArgument.Validate(listArgs);

            if (optionCommand.Equals(CommandOptionKey.SI_UUID))
            {
                ContainerUseCase.getUseCaseCrud().Delete(listArgs[0]);
            }
            else if (optionCommand.ToString().Equals(CommandOptionKey.SI_ID))
            {
                ContainerUseCase.getUseCaseCrud().Delete(Int32.Parse(listArgs[0]));
            }

            Console.WriteLine("Remove sucessfully");
        }
    }
}
