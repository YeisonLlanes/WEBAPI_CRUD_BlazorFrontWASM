using BlazorCrud.Shared;

namespace BlazorCrud.Client.Services
{
    public interface IEmpleado
    {
        Task<List<EmpleadoDTO>> Lista();

        Task<EmpleadoDTO> Buscar(int id);

        Task<int> Guardar(EmpleadoDTO empleado);

        Task<int> Actualizar(EmpleadoDTO empleado);

        Task<bool> Eliminar(int id);
    }
}
