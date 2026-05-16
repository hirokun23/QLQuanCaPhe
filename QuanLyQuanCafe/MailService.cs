using System;
using MailKit.Net.Smtp;
using MimeKit;

namespace QuanLyQuanCafe
{
    public class MailService
    {
        public static void SendOTP(string toEmail, string otp)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Quan Cafe", "quanlycafehn@gmail.com"));
            message.To.Add(new MailboxAddress("", toEmail));

            message.Subject = "Mã OTP khôi phục mật khẩu";

            message.Body = new TextPart("plain")
            {
                Text = $"Mã OTP của bạn là: {otp}"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);

                client.Authenticate(
                    "quanlycafehn@gmail.com",
                    "rhrd aqur lqad pyux"
                );

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}