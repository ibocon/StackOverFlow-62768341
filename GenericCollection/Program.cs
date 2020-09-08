using System;
using System.Collections.Generic;

namespace GenericCollection
{
    interface IBaseViewModel<out T> where T : BaseModel { }

    abstract class BaseModel { }

    abstract class BaseViewModel<T> : IBaseViewModel<T> where T : BaseModel 
    {
        protected T model;
    }

    class ModelA : BaseModel { }

    class ViewModelA : BaseViewModel<ModelA> { }

    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<IBaseViewModel<BaseModel>>();
            collection.Add(new ViewModelA());
        }
    }
}
