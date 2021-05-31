using SensitiveInformationApplication.Src.Main.UseCases;
using SensitiveInformationDatabase.Src.Repository;

namespace SensitiveInformationAPI.Containers
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
