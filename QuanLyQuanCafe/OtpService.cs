using System;
using MailKit.Net.Smtp;
using MimeKit;

namespace QuanLyQuanCafe
{
    public static class OtpService
    {
        public static string OTPCode;
        public static string CurrentUser;
        public static string CurrentEmail;

        public static void GenerateOTP()
        {
            Random rd = new Random();
            OTPCode = rd.Next(100000, 999999).ToString();
        }
    }
}
