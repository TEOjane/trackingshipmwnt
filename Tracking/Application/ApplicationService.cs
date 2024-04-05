using Domain;

namespace Application;

public class ApplicationService : IApplicationService
{
    private ICargoRepository _cargoRepository;

    public ApplicationService(ICargoRepository cargoRepository)
    {
        _cargoRepository = cargoRepository;
    }
}