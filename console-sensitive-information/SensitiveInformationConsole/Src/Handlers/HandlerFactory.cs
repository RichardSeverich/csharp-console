using SensitiveInformationConsole.Src.Commands;

namespace SensitiveInformationConsole.Src.Handlers
{
    internal class HandlerFactory
    {
        private HandlerFactory()
        {
        }

        internal static IHandler GetHandler(string command)
        {
            switch (command.ToLower())
            {
                case Command.AGREGATE:
                    return new HandlerAdd();

                case Command.REMOVE:
                    return new HandlerRemove();

                case Command.UPDATE:
                    return new HandlerUpdate();

                case Command.LIST:
                    return new HandlerList();

                default:
                    return null;
            }
        }
    }
}
