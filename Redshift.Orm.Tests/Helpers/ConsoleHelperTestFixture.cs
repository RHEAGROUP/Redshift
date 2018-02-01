﻿#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleHelperTestFixture.cs" company="RHEA System S.A.">
//    Copyright (c) 2018 RHEA System S.A.
//
//    Author: Alex Vorobiev
//
//    This file is part of Redshift.Orm.Tests.
//
//    Redshift.Orm.Tests is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    Redshift.Orm.Tests is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with Redshift.Orm.Tests.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redshift.Orm.Tests.Helpers
{
    using NUnit.Framework;

    using Redshift.Orm.Helpers;

    [TestFixture]
    public class ConsoleHelperTestFixture
    {
        [Test]
        public void VerifyThatConsoleHelperWorks()
        {
            var columns = Tuple.Create("c1", "c2");
            var rows = new List<Tuple<string, string>>{ columns };

            var stringTable = rows.ToStringTable(new [] {"h1", "h2"}, a => a.Item1, a => a.Item2);

            Assert.IsFalse(string.IsNullOrWhiteSpace(stringTable));
        }

    }
}
