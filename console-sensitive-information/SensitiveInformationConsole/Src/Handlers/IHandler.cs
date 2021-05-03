using System.Collections.Generic;

namespace SensitiveInformationConsole.Src.Handlers
{
    interface IHandler
    {
        public void Handle(List<string> listArgs);
    }
}
