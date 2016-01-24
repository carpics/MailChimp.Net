﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IActivityLogic
    {
        Task<IEnumerable<Activity>> GetAllAsync(string listId, BaseRequest request);
    }
}
