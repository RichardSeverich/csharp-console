using System;
using System.Collections.Generic;

using SensitiveInformationCore.Src.Main.CoreManager;
using SensitiveInformationCore.Src.Main.Models;

namespace SensitiveInformationConsole.Src.Handlers
{
    internal class HandlerList : IHandler
    {
        internal HandlerList()
        {
        }

        public void Handle(List<string> listArgs)
        {
            List<ModelSensitiveInformation> listSI = CoreManagerSensitiveInformation.Read();
            listSI = HandlerListHelper.Handle(listArgs, listSI);

            foreach (var SI in listSI)
            {
                Console.WriteLine(SI.ToStringJson());
            }
        }
    }
}
