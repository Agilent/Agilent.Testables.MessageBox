// (c) Copyright 2024 Agilent Technologies, Inc. All Rights Reserved.

using System.Collections.Generic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snapshooter;
using Snapshooter.MSTest;
using static System.Reflection.BindingFlags;

namespace MessageBox.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ApiParityTests
    {

        [TestMethod]
        public void MessageBox()
        {
            AssertParity(
                referenceType: typeof(System.Windows.Forms.MessageBox),
                abstractionType: typeof(Agilent.Ace.MessageBox.Wrappers.MessageBox)
            );
        }

        private static void AssertParity(Type referenceType, Type abstractionType)
        {
            IEnumerable<string> GetMembers(Type type)
            {
                return type
                .GetMembers(bindingAttr: Instance | Static | Public | FlattenHierarchy)
                .Select(x => x.ToString())
                .OrderBy(x => x, StringComparer.Ordinal);
            }

            var referenceMembers = GetMembers(referenceType);
            var abstractionMembers = GetMembers(abstractionType);
            var diff = new ApiDiff(
                extraMembers: abstractionMembers.Except(referenceMembers),
                missingMembers: referenceMembers.Except(abstractionMembers)
            );
            Snapshot.Match(diff, SnapshotNameExtension.Create(SnapshotSuffix));
        }


#if NET481
        private const string SnapshotSuffix = ".NET Framework 4.8.1";

#elif NET7_0
        private const string SnapshotSuffix = ".NET 7.0";
#else
#error Unknown target framework.
#endif

        private readonly struct ApiDiff
        {
            public ApiDiff(IEnumerable<string> extraMembers, IEnumerable<string> missingMembers)
            {
                ExtraMembers = extraMembers.ToArray();
                MissingMembers = missingMembers.ToArray();

            }

            public string[] ExtraMembers { get; }
            public string[] MissingMembers { get; }
        }
    }
}
