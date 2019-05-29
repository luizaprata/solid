namespace Commerce.TightCoupling.Model
{
    public interface INotificationService
    {
        void NotifyCustomer(Cart cart);
    }
}

