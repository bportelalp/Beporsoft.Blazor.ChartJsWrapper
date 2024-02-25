﻿using Beporsoft.Blazor.Charts.Cartesian;
using Beporsoft.Blazor.Charts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beporsoft.Blazor.Charts.Datasets
{
    /// <summary>
    /// A dataset which display three dimensions of data at the same time. The location is determined by the dataset data, ignoring labels.
    /// </summary>
    /// <typeparam name="Tx"></typeparam>
    /// <typeparam name="Ty"></typeparam>
    /// <typeparam name="Tz"></typeparam>
    public class BubbleDataset<Tx, Ty, Tz> : CartesianDataset<BubblePoint<Tx, Ty, Tz>>
    {
        #region Constructors
        public BubbleDataset() : base(CartesianChartType.Line)
        {
        }

        public BubbleDataset(IEnumerable<BubblePoint<Tx, Ty, Tz>> data) : this()
        {
            foreach (var item in data)
            {
                Add(item);
            }
        }

        public BubbleDataset(string title, IEnumerable<BubblePoint<Tx, Ty, Tz>> data) : this(data)
        {
            Label = title;
        }
        #endregion
    }

    public class BubbleDataset<Txy, Tz> : BubbleDataset<Txy, Txy, Tz>
    {
        #region Constructors
        public BubbleDataset() : base()
        {
        }

        public BubbleDataset(IEnumerable<BubblePoint<Txy, Txy, Tz>> data) : this()
        {
            foreach (var item in data)
            {
                Add(item);
            }
        }

        public BubbleDataset(string title, IEnumerable<BubblePoint<Txy, Txy, Tz>> data) : this(data)
        {
            Label = title;
        }
        #endregion
    }

    public class BubbleDataset<Txyz> : BubbleDataset<Txyz, Txyz, Txyz>
    {
        #region Constructors
        public BubbleDataset() : base()
        {
        }

        public BubbleDataset(IEnumerable<BubblePoint<Txyz, Txyz, Txyz>> data) : this()
        {
            foreach (var item in data)
            {
                Add(item);
            }
        }

        public BubbleDataset(string title, IEnumerable<BubblePoint<Txyz, Txyz, Txyz>> data) : this(data)
        {
            Label = title;
        }
        #endregion
    }
}