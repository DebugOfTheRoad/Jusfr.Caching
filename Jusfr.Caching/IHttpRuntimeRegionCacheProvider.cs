﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jusfr.Caching {
    public interface IHttpRuntimeRegionCacheProvider : IHttpRuntimeCacheProvider {
        String Region { get; }
    }
}
