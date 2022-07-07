namespace BancoDosDevs.Business.Contract
{
    public interface IBaseRepository <BEntity>
    {
        void Delete(int id);
        void Save(BEntity Entity);
        void Update(int id);
    }
}