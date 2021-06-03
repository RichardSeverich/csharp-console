using System.Collections.Generic;
using SensitiveInformationConsole.Src.Handlers;
using SensitiveInformationConsole.Src.Validators;

namespace SensitiveInformationConsole.Src
{
    class App
    {
        static void Main(string[] args)
        {
            List<string> listArgs = new List<string>(args);
            ValidatorArgument.Validate(listArgs);
            ValidatorEntryCommand.Validate(listArgs[0]);
            listArgs.RemoveAt(0);
            IHandler handler = HandlerFactory.GetHandler(args[0]);
            handler.Handle(listArgs);
        }
    }
}
