﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IQueryDB
    {
        ArrayList QueryAll();
        ArrayList QueryByCriteria();
    }
}