using System.Collections.Generic;

using SensitiveInformationConsole.Src.Validators;
using SensitiveInformationCore.Src.Main.EntityDomain;
using SensitiveInformationConsole.Src.Commands;
using System;
using SensitiveInformationConsole.Src.Containers;

namespace SensitiveInformationConsole.Src.Handlers
{
    internal class HandlerUpdate : IHandler
    {
        internal HandlerUpdate()
        {
        }

        public void Handle(List<string> listArgs)
        {
            ValidatorArgument.Validate(listArgs);
            ValidatorOptionCommandKey.Validate(listArgs[0]);
            string optionCommandKey = listArgs[0];
            listArgs.RemoveAt(0);
            ValidatorArgument.Validate(listArgs);
            string idOrUuid = listArgs[0];
            listArgs.RemoveAt(0);
            List<SensitiveInformation> listSI = ContainerUseCase.getUseCaseCrud().Read();

            if (optionCommandKey.Equals(CommandOptionKey.SI_UUID))
            {
                SensitiveInformation modelSI = listSI.Find(si => si.uuid.Equals(idOrUuid));
                ValidatorIsNull.Validate(modelSI);
                modelSI = HandlerAddHelper.Handle(listArgs, modelSI);
                ContainerUseCase.getUseCaseCrud().Update(idOrUuid, modelSI);
            }
            else if (optionCommandKey.Equals(CommandOptionKey.SI_ID))
            {
                SensitiveInformation modelSI = listSI.Find(si => si.id.ToString().Equals(idOrUuid));
                ValidatorIsNull.Validate(modelSI);
                modelSI = HandlerAddHelper.Handle(listArgs, modelSI);
                ContainerUseCase.getUseCaseCrud().Update(Int32.Parse(idOrUuid), modelSI);
            }

            Console.WriteLine("Update sucessfully");
        }
    }
}
