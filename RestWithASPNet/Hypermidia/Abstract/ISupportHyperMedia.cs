﻿using System;
using System.Collections.Generic;

namespace RestWithASPNet.Hypermidia.Abstract
{
    public interface ISupportHyperMedia
    {
        List<HyperMidiaLink> links { get; set; }
    }
}
