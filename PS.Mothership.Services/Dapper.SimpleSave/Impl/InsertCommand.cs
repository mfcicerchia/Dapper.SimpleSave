﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.SimpleSave.Impl {
    public class InsertCommand : DeleteCommand
    {
        public InsertCommand(RemoveOperation operation) : base(operation)
        {
        }
    }
}
