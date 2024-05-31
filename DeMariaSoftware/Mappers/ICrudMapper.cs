namespace DeMariaSoftware.Mappers
{
    public interface ICrudMapper<TRequest, TResponse, TEntity>
    {
        TEntity MapToEntity(TRequest request);
        TResponse MapToResponse(TEntity registro);
    }
}
