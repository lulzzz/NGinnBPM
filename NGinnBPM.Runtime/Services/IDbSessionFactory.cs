﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NGinnBPM.Runtime.Services
{
    public interface IDbSessionFactory
    {
        DbSession OpenSession();
        DbSession OpenSession(object connection);
    }
}
