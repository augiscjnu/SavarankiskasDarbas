﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailoSkaitimasCore.Contrackts
{
    public interface IFailoSkaitymas
    {
        List<string> skaitytiDoumenis(string failoKelias);
    }
}
