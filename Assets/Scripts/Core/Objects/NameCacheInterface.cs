using UnityEngine;
using System.Collections;

namespace Core
{
    public interface NameCacheInterface<T> 
    {
        T GetByName(string name);
    } 
}