using System;

namespace Solid_Violation_Examples.DIP
{
    public class EmailSender
    {
        public void Send(Email email) =>
            Console.WriteLine($"To: {email.To}, Subject: {email.Subject}, Message: {email.Message}");
    }
}
