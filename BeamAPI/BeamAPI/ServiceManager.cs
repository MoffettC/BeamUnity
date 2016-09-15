using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ServiceManager<T> : AbstractService{
    protected readonly HashSet<T> services = new HashSet<T>();

    //@SuppressWarnings("unchecked")
    //public (V : <T>) V get(Class<V> type) {
    //    foreach (T service in this.services) {
    //        if (service.GetType == type) {
    //            return (V)service;
    //        }
    //    }
    //    return null;
    //}

    public T get(Class<V> type) {
        foreach (T service in this.services) {
            if (service.GetType == type) {
                return (V)service;
            }
        }
        return null;
    }

    public bool register(T service) {
        return this.services.Add(service);
    }

    public bool unregister(T service) {
        return this.services.Remove(service);
    }

    public void unregisterAll() {
        this.services.Clear();
    }

}

