﻿using Orleans;
using System.Threading.Tasks;

namespace Kritner.Orleans.GettingStarted.GrainInterfaces
{
    public interface IEmailSenderGrain : IGrainWithGuidKey, IGrainInterfaceMarker
    {
        Task SendEmail(string from, string[] to, string subject, string body);
    }
}