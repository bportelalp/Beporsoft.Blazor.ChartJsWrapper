﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public interface IMainAxisDataset
    {
        internal List<object> GetLabels();
    }
}
