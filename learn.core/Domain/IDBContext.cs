﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace learn.core.Domain
{
   public interface IDBContext
    {

        public DbConnection dbConnection { get; }



    }
}
