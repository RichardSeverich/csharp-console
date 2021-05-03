using System.Collections.Generic;

using SensitiveInformationConsole.Src.Validators;
using SensitiveInformationCore.Src.Main.Models;
using SensitiveInformationCore.Src.Main.CoreManager;
using SensitiveInformationConsole.Src.Commands;
using System.Linq;
using System;

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
            List<ModelSensitiveInformation> listSI = CoreManagerSensitiveInformation.Read();

            if (optionCommandKey.Equals(CommandOptionKey.SI_UUID))
            {
                ModelSensitiveInformation modelSI = listSI.Find(si => si.uuid.Equals(idOrUuid));
                ValidatorIsNull.Validate(modelSI);
                modelSI = HandlerAddHelper.Handle(listArgs, modelSI);
                CoreManagerSensitiveInformation.Update(idOrUuid, modelSI);
            }
            else if (optionCommandKey.Equals(CommandOptionKey.SI_ID))
            {
                ModelSensitiveInformation modelSI = listSI.Find(si => si.id.ToString().Equals(idOrUuid));
                ValidatorIsNull.Validate(modelSI);
                modelSI = HandlerAddHelper.Handle(listArgs, modelSI);
                CoreManagerSensitiveInformation.Update(Int32.Parse(idOrUuid), modelSI);
            }

            Console.WriteLine("Update sucessfully");
        }
    }
}
