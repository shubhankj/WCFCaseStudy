﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAnalyserService" in both code and config file together.
    [ServiceContract]
    public interface IAnalyserService
    {
        [OperationContract]
        [WebInvoke(Method ="GET", UriTemplate ="/AnalyseCode/{threshold}",RequestFormat =WebMessageFormat.Json,ResponseFormat =WebMessageFormat.Json,BodyStyle =WebMessageBodyStyle.Wrapped)]
        string AnalyseCode(string threshold);
    }
}