using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;

namespace NewFileNotfier
{
    class Email
    {
        private const string NAMESPACE = "MAPI";
        public string ToAddresses { get; set; }
        public string CCAddresses { get; set; }
        public string BCCAddresses { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Attachement { get; set; }

        private Microsoft.Office.Interop.Outlook.MailItem mail;

        public Email() 
        {
        }

        public Email(string toAddresses, string fromAddress = "", string subject = "", string body = "", string ccAddress = "", string bccAddress = "")
        {
            ToAddresses = toAddresses;
            FromAddress = fromAddress;
            CCAddresses = ccAddress;
            BCCAddresses = bccAddress;
            Subject = subject;
            Body = body;
        }

        private void validate()
        {
            if (string.IsNullOrWhiteSpace(ToAddresses))
                throw new Exception("No To Address set.");
            if (string.IsNullOrWhiteSpace(FromAddress))
                throw new Exception("No From Address set.");
            if (string.IsNullOrWhiteSpace(Subject))
                throw new Exception("No From Subject set.");
            if (string.IsNullOrWhiteSpace(Body))
                throw new Exception("No From Body set.");
        }

        private void buildMessage()
        {
            var outlook = new Microsoft.Office.Interop.Outlook.Application();
            mail = outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            mail.To = ToAddresses;
            mail.CC = CCAddresses;
            mail.BCC = BCCAddresses;
            mail.Subject = Subject;
            mail.Body = Body;
            if (Attachement != null)
            {
                mail.Attachments.Add(Attachement, Type.Missing, Type.Missing, Type.Missing);
            }
        }

        public void Send()
        {
            validate();
            buildMessage();

            var outlook = new Microsoft.Office.Interop.Outlook.Application();
            var outlookNamespace = outlook.GetNamespace(NAMESPACE);
            outlookNamespace.Logon(Type.Missing,Type.Missing, true, true);

            mail.Send();
        }
    }
}
