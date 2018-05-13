namespace TeduShop.Data.Infrastructure
{
    // DbFactory de khoi tao doi tuong DbContext thay vi build truoc tiep thi se thongg qua doi tuong Factory nay
    public class DbFactory : Disposable, IDbFactory
    {
        private TeduShopDbContext dbContext;

        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}