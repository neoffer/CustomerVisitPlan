using System;

namespace CustomerVisitPlan.Infrastructure
{
    public class EmailSender : IEmailSender
    {
        public bool NotifyByEmail(params string[] parameters)
        {
            // TODO: Bildirim email tasarımı ile birlikte burada hazırlanıp gönderilir
            return true;
        }
    }
}
