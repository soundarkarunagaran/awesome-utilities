﻿using System.Text;
using System.IO;

namespace System.Net.Mail
{
    /// <summary>
    ///     An SMTP client that actually just writes files to disk.
    /// </summary>
    public class FileSmtpClient : ISmtpClient
    {
        private readonly string directory;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSmtpClient"/> class.
        /// </summary>
        /// <param name="directory">The directory.</param>
        public FileSmtpClient(string directory = null)
        {
            this.directory = directory ?? "emails";
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Send(MailMessage message)
        {
            if (!Directory.Exists(this.directory))
            {
                Directory.CreateDirectory(this.directory);
            }

            var builder = new StringBuilder();
            builder.AppendLine("From: " + message.From);
            foreach (var to in message.To)
            {
                builder.AppendLine("To: " + to);
            }
            foreach (var cc in message.CC)
            {
                builder.AppendLine("CC: " + cc);
            }
            foreach (var bcc in message.Bcc)
            {
                builder.AppendLine("Bcc: " + bcc);
            }
            
            builder.AppendLine();
            builder.AppendLine("Subject: " + message.Subject);
            builder.AppendLine("Body: ");
            builder.AppendLine(message.Body);

            File.WriteAllText(Path.Combine(this.directory, string.Format(@"{0}.txt", DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss"))), builder.ToString());
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="recipients">The recipients.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="body">The body.</param>
        public void Send(string from, string recipients, string subject, string body)
        {
            this.Send(new MailMessage(from, recipients, subject, body));
        }
    }
}