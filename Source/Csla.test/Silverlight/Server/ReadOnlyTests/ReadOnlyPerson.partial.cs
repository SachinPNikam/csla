﻿//-----------------------------------------------------------------------
// <copyright file="ReadOnlyPerson.partial.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>no summary</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csla.Testing.Business.ReadOnlyTest
{
  public partial class ReadOnlyPerson
  {
    private ReadOnlyPerson() { }

    private void DataPortal_Fetch(SingleCriteria<ReadOnlyPerson, Guid> criteria)
    {
      LoadProperty<Guid>(IdProperty, criteria.Value);
      LoadProperty(NameProperty, criteria.Value.ToString());
      LoadProperty(BirthdateProperty, new DateTime(1980, 1, 1));
    }
  }
}