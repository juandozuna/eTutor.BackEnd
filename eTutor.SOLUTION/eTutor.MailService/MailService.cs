﻿using System;
using System.Threading.Tasks;
using eTutor.Core.Contracts;
using eTutor.Core.Models;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace eTutor.SendGridMail
{
    public class MailService : IMailService
    {

        private readonly IConfiguration _configuration;
        private readonly string _apiKey;


        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
            _apiKey = _configuration.GetSection("SendGrid")["ApiKey"];
            
            
        }


        public async Task<IOperationResult<int>> SendEmailToRegisteredUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IOperationResult<int>> SendPasswordResetEmail(User user, string token)
        {
            var passwordRecoveryUrl = _configuration.GetSection("Settings")["PasswordRecoveryUrl"];
            passwordRecoveryUrl = passwordRecoveryUrl.Replace("{userId}", token);

            var sendGridClient = new SendGridClient(_apiKey);
            var from = new EmailAddress("no_reply@etutor.com", "Etutor");
            var to = new EmailAddress(user.Email, user.FullName);
            var msg = MailHelper.CreateSingleTemplateEmail(from, to, "d-307bb4ffcd3747d5bb22f5cf096cc689",
                new { Name = "Juan Daniel Ozuna", ResetLink = "https://google.com" });
            Response response = await sendGridClient.SendEmailAsync(msg);

            //d-307bb4ffcd3747d5bb22f5cf096cc689

            if (response.StatusCode >= System.Net.HttpStatusCode.BadRequest)
            {
                return BasicOperationResult<int>.Fail("Error sending mail");
            }

            return BasicOperationResult<int>.Ok();
        }
    }
}
