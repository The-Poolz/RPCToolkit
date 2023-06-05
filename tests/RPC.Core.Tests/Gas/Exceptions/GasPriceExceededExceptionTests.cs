﻿using Xunit;
using System.Runtime.Serialization;

namespace RPC.Core.Gas.Exceptions.Tests;

public class GasPriceExceededExceptionTests : ExceptionSerializationTestBase<GasPriceExceededException, TestableGasPriceExceededException>
{
    [Fact]
    internal void GasPriceExceededException_SerializationTest()
    {
        RunSerializationTest("Gas price exceeded.");
    }

    protected override TestableGasPriceExceededException CreateTestableException(SerializationInfo info, StreamingContext context) =>
        new(info, context);
}
