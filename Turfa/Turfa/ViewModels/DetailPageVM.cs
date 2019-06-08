using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Turfa.ViewModels
{
    public class DetailPageVM
    {
            public async Task SendEmail(string subject, string body, List<string> recipients)
            {
                try
                {
                    var message = new EmailMessage
                    {
                        Subject = subject,
                        Body = body,
                        To = recipients,
                        //Cc = ccRecipients,
                        //Bcc = bccRecipients
                    };
                    await Email.ComposeAsync(message);
                }
                catch (FeatureNotSupportedException)
            {
                    // Email is not supported on this device
                }
                catch (Exception)
            {
                    // Some other exception occurred
                }
            }

    }
}
