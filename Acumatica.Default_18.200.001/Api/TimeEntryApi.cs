using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;
using Acumatica.RESTClient.Api;

namespace Acumatica.Default_18_200_001.Api
{
    public partial class TimeEntryApi : EntityAPI<TimeEntry>
    {
        public TimeEntryApi(Configuration configuration) : base(configuration)
        {
        }
    }
}