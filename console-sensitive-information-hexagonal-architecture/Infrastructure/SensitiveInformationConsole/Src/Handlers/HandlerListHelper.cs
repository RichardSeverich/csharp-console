using System.Collections.Generic;

using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationConsole.Src.Validators;
using SensitiveInformationCore.Src.Main.EntityDomain;
using SensitiveInformationConsole.Src.Builders;

namespace SensitiveInformationConsole.Src.Handlers
{
    internal class HandlerListHelper
    {
        private HandlerListHelper()
        {
        }

        internal static List<SensitiveInformation> Handle(List<string> listArgs, List<SensitiveInformation> listSI)
        {
            if (listArgs.Count == 0)
            {
                return listSI;
            }

            ValidatorOptionCommandAll.Validate(listArgs[0]);
            string optionCommand = listArgs[0];

            if (!CommandOption.SI_FAVORITE.Equals(optionCommand))
            {
                listArgs.RemoveAt(0);
            }

            ValidatorArgument.Validate(listArgs);
            listSI = BuilderFilteredListSI.Build(optionCommand, listArgs[0], listSI);
            listArgs.RemoveAt(0);

            if (listArgs.Count >= 1)
            {
                Handle(listArgs, listSI);
            }

            return listSI;
        }
    }
}
