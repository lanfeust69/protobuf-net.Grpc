﻿using ProtoBuf;
using System.ServiceModel;
using System.Threading.Tasks;

namespace CodeFirst
{
    [ProtoContract]
    public sealed class IncrementResult
    {
        [ProtoMember(1)]
        public int Count { get; set; }
    }

    [ServiceContract(Name = "PerfTest.VanillaGrpc")]
    public interface IVanillaGrpc
    {
        public Task IncrementAsync();

        public Task<IncrementResult> ResetAsync();
    }

    [ServiceContract(Name = "PerfTest.ProtobufNetGrpc")]
    public interface IProtobufNetGrpc
    {
        public Task IncrementAsync();

        public Task<IncrementResult> ResetAsync();
    }
}
