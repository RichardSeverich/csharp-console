using System;
using System.Collections.Generic;

using SensitiveInformationConsole.Src.Validators;
using SensitiveInformationCore.Src.Main.CoreManager;
using SensitiveInformationConsole.Src.Commands;

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
                CoreManagerSensitiveInformation.Delete(listArgs[0]);
            }
            else if (optionCommand.ToString().Equals(CommandOptionKey.SI_ID))
            {
                CoreManagerSensitiveInformation.Delete(Int32.Parse(listArgs[0]));
            }

            Console.WriteLine("Remove sucessfully");
        }
    }
}
