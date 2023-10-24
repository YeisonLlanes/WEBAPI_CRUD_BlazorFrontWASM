using BlazorCrud.Shared;

namespace BlazorCrud.Client.Services
{
    public interface IDepartamento
    {
        Task<List<DepartamentoDTO>> ListaDepartamento();
    }
}
