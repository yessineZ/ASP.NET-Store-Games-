﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yessine.Utility {
    public class EmailSender: IEmailSender  {
        public Task SendEmailAsync(string email ,string subject, string htmlmessage) {
            return Task.CompletedTask;
        }
    }
}
