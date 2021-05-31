using System;
using System.Collections.Generic;
using SensitiveInformationConsole.Src.Containers;
using SensitiveInformationCore.Src.Main.EntityDomain;

namespace SensitiveInformationConsole.Src.Handlers
{
    internal class HandlerList : IHandler
    {
        internal HandlerList()
        {
        }

        public void Handle(List<string> listArgs)
        {
            List<SensitiveInformation> listSI = ContainerUseCase.getUseCaseCrud().Read();
            listSI = HandlerListHelper.Handle(listArgs, listSI);

            foreach (var SI in listSI)
            {
                Console.WriteLine(SI.ToStringJson());
            }
        }
    }
}
