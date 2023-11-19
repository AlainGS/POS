namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaracion o matricula de nuestra interface a nivel de repository
        ICategoryRepository Category {  get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
