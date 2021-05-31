using System;
using System.Collections.Generic;

using SensitiveInformationCore.Src.Main.EntityDomain;
using SensitiveInformationConsole.Src.Containers;

namespace SensitiveInformationConsole.Src.Handlers
{
    internal class HandlerAdd : IHandler
    {
        internal HandlerAdd()
        {
        }

        public void Handle(List<string> listArgs)
        {
            SensitiveInformation modelSI;
            modelSI = HandlerAddHelper.Handle(listArgs, new SensitiveInformation());
            ContainerUseCase.getUseCaseCrud().Create(modelSI);
            Console.WriteLine("Create sucessfully");
        }
    }
}
