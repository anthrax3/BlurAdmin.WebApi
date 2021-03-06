﻿using System;
using System.Collections.Generic;
using LegacyApplication.Shared.ByModule.Work.Enums;
using LegacyApplication.Shared.Features.Base;

namespace LegacyApplication.ViewModels.Work
{
    public class InternalMailViewModel : EntityBase
    {
        public string UserName { get; set; }
        public string PersonName { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime SendTime { get; set; }
        public bool HasDeleted { get; set; }
        public MailType MailType { get; set; }
        public string MailTypeDisplay => MailType.ToString();

        public List<InternalMailToViewModel> Tos { get; set; }
        public List<InternalMailAttachmentViewModel> Attachments { get; set; }
    }
}
