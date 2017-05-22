using System;
using Trial_Shop.Interfaces;
using Trial_Shop.Repository.DataBase;

namespace Trial_Shop.Repository
{
    public class Uow : IUow, IDisposable
    {
        private readonly ShopModel _context;

        private IUserRepository _userRepository;
        private IOrderRepository _orderRepository;
        private IOrderProductRepository _orderProductRepository;
        private IProductRepository _productRepository;

        public Uow()
        {
            _context = new ShopModel();

            _context.Configuration.LazyLoadingEnabled = false;
            _context.Configuration.AutoDetectChangesEnabled = false;
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public IUserRepository UserRepository
            => _userRepository ?? (_userRepository = new UserRepository(_context));

        public IOrderRepository OrderRepository
            => _orderRepository ?? (_orderRepository = new OrderRepository(_context));

        public IOrderProductRepository OrderProductRepository
            => _orderProductRepository ?? (_orderProductRepository = new OrderProductRepository(_context));

        public IProductRepository ProductRepository
            => _productRepository ?? (_productRepository = new ProductRepository(_context));

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
