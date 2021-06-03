using SensitiveInformationApplication.Src.Main.UseCases;
using SensitiveInformationDatabase.Src.Repository;

namespace SensitiveInformationConsole.Src.Containers
{
    internal class ContainerUseCase
    {
        private static ContainerUseCase instance;
        public UseCaseCrud useCaseCrud;

        private ContainerUseCase()
        {
            RepositorySensitiveInformation repo = new RepositorySensitiveInformation();
            useCaseCrud = new UseCaseCrud(repo);
        }

        internal static UseCaseCrud getUseCaseCrud()
        {
            return (instance == null) 
                ? new ContainerUseCase().useCaseCrud 
                : instance.useCaseCrud;
        }
    }
}
