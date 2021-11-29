using CoreBusiness;

namespace UseCases
{
    public interface IGetProductByIdByUseCase
    {
        Product Execute(int productId);
    }
}