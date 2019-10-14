using System;

namespace FlyApi.Infra.CrossCutting.Caching.shared
{
    public interface ICacheKey<TItem>
    {
         string CacheKey { get; }
    }
}
