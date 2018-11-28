﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    interface IPrinter
    {
        void PrintContent<T>(List<T> content);
    }
}
