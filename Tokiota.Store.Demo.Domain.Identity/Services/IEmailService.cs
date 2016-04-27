﻿namespace Tokiota.Store.Demo.Domain.Identity.Services
{
    using System.Net.Mail;
    using System.Threading.Tasks;

    public interface IEmailService
    {
        Task SendAsync(MailMessage message);
    }
}