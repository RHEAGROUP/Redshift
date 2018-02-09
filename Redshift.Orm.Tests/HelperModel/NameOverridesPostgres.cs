﻿#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NameOverridesPostgres.cs" company="RHEA System S.A.">
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

namespace Redshift.Orm.Tests.HelperModel
{
    using System.Runtime.Serialization;
    using Orm.Attributes;
    using Orm.EntityObject;

    public class NameOverridesPostgres : EntityObject<NameOverridesPostgres>
    {
        [IgnoreDataMember]
        public override string TableName => "\"overrideTable\"";

        public int Id { get; set; }

        [EntityColumnNameOverride("\"stringColumnNameThisIsOverride\"")]
        public string SomeString { get; set; }
    }
}
