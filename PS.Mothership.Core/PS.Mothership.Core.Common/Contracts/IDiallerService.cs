﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PS.Mothership.Core.Common.Contracts
{
    [ServiceContract(CallbackContract = typeof (IDiallerServiceCallback), Name = "DiallerService")]
    public interface IDiallerService
    {
    }
}
