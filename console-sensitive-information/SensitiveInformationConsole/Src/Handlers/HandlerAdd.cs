using System;
using System.Collections.Generic;

using SensitiveInformationCore.Src.Main.Models;
using SensitiveInformationCore.Src.Main.CoreManager;

namespace SensitiveInformationConsole.Src.Handlers
{
    internal class HandlerAdd : IHandler
    {
        internal HandlerAdd()
        {
        }

        public void Handle(List<string> listArgs)
        {
            ModelSensitiveInformation modelSI;
            modelSI = HandlerAddHelper.Handle(listArgs, new ModelSensitiveInformation());
            CoreManagerSensitiveInformation.Create(modelSI);
            Console.WriteLine("Create sucessfully");
        }
    }
}
