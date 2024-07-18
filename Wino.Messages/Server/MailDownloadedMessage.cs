﻿using Wino.Core.Domain.Entities;

namespace Wino.Messaging.Server
{
    public record MailDownloadedMessage(MailCopy DownloadedMail) : ServerMessageBase<MailDownloadedMessage>;
}
