namespace BancoDosDevs.Business.Contract
{
    public interface IBaseRepository <DEntity>
    {
        void Delete(int id);
        void Save(DEntity Entity);
        void Update(int id);
        List<DEntity> GetAll();
    }
}