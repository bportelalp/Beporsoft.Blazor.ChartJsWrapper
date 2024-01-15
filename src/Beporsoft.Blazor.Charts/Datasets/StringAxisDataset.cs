﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beporsoft.Blazor.Charts.Common;

namespace Beporsoft.Blazor.Charts.Datasets
{
    public class StringAxisDataset : List<string>, IAxisLabels
    {
        List<object> IAxisLabels.GetLabels()
        {
            return this.Select(i => (object)i).ToList();
        }
    }
}
