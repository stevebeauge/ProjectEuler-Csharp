// <copyright file="PrimesTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections.Generic;
using Lib;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lib
{
    /// <summary>This class contains parameterized unit tests for Primes</summary>
    [PexClass(typeof(Primes))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class PrimesTest
    {
        /// <summary>Test stub for GetPrimes(UInt64)</summary>
        [PexMethod]
        public IEnumerable<ulong> GetPrimes(ulong upperBound)
        {
            IEnumerable<ulong> result = Primes.GetPrimes(upperBound);
            return result;
            // TODO: add assertions to method PrimesTest.GetPrimes(UInt64)
        }

        /// <summary>Test stub for IsPrime(UInt64)</summary>
        [PexMethod]
        public bool IsPrime(ulong value)
        {
            bool result = Primes.IsPrime(value);
            return result;
            // TODO: add assertions to method PrimesTest.IsPrime(UInt64)
        }
    }
}
