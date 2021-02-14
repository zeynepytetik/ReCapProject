using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow.CommonModels;

namespace Core.Utilities
{
    public class IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
