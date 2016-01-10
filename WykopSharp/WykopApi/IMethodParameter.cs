using System;
using System.Net.Http;

namespace WykopSharp
{
    public interface IMethodParameter : IEquatable<IMethodParameter>
    {
        string Name { get; }
    }

    public interface IPostParameter : IEquatable<IPostParameter>
    {
        string Name { get; }
        HttpContent AsHttpContent { get; }
    }

}