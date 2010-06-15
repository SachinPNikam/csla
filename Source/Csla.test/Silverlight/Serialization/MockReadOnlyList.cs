﻿//-----------------------------------------------------------------------
// <copyright file="MockReadOnlyList.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>no summary</summary>
//-----------------------------------------------------------------------
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Csla;
using Csla.Serialization;
using Csla.Xaml;

namespace cslalighttest.Serialization
{
  [Serializable]
  public class MockReadOnlyList : ReadOnlyBindingListBase<MockReadOnlyList, MockReadOnly>
  {
    public MockReadOnlyList() { }

    public MockReadOnlyList(params MockReadOnly[] items)
    {
      IsReadOnly = false;
      AddRange(items);
      IsReadOnly = true;
    }
  }
}