using System;
namespace CustomerVisitPlan.Infrastructure
{
    public interface IEmailSender
    {
        bool NotifyByEmail(params string[] parameters);
    }
}
