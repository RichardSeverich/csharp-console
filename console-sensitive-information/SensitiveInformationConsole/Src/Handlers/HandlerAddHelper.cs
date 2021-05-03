using System.Collections.Generic;

using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationConsole.Src.Validators;
using SensitiveInformationCore.Src.Main.Models;
using SensitiveInformationConsole.Src.Builders;

namespace SensitiveInformationConsole.Src.Handlers
{
    internal class HandlerAddHelper
    {
        private HandlerAddHelper()
        {
        }

        internal static ModelSensitiveInformation Handle(List<string> listArgs, ModelSensitiveInformation modelSI)
        {
            if (listArgs.Count == 0)
            {
                return modelSI;
            }

            ValidatorOptionCommand.Validate(listArgs[0]);
            string optionCommand = listArgs[0];

            if (!CommandOption.SI_FAVORITE.Equals(optionCommand))
            {
                listArgs.RemoveAt(0);
            }

            ValidatorArgument.Validate(listArgs);
            modelSI = BuilderSensitiveInformation.Build(optionCommand, modelSI, listArgs[0]);
            listArgs.RemoveAt(0);

            if (listArgs.Count >= 1)
            {
                Handle(listArgs, modelSI);
            }

            return modelSI;
        }
    }
}
