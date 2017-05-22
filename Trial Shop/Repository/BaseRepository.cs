using Trial_Shop.Repository.DataBase;

namespace Trial_Shop.Repository
{
    public class BaseRepository
    {
        protected readonly ShopModel Context;

        public BaseRepository(ShopModel context)
        {
            Context = context;
        }
    }
}
