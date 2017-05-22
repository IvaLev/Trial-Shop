namespace Trial_Shop.Interfaces
{
    public interface IUow
    {
        IUserRepository UserRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOrderProductRepository OrderProductRepository { get; }
        IProductRepository ProductRepository { get; }
    }
}
