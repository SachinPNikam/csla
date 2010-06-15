﻿//-----------------------------------------------------------------------
// <copyright file="FieldDataList.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>no summary</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Csla.Serialization;

namespace Csla.Core.FieldManager
{
  [Serializable]
  internal class FieldDataList : Csla.Core.MobileObject, Csla.Serialization.Mobile.ISerializationNotification
  {
    [NonSerialized()]
    private Dictionary<string, int> _fieldIndex = new Dictionary<string, int>();
    private Csla.Core.MobileBindingList<IFieldData> _fields = new Csla.Core.MobileBindingList<IFieldData>();

    public FieldDataList()
    { /* required due to serialization ctor */ }

    public bool TryGetValue(string key, out IFieldData result)
    {
      int index;
      if (_fieldIndex.TryGetValue(key, out index))
      {
        result = _fields[index];
        return true;
      }
      else
      {
        result = null;
        return false;
      }
    }

    public bool ContainsKey(string key)
    {
      return _fieldIndex.ContainsKey(key);
    }

    public IFieldData GetValue(string key)
    {
      return _fields[_fieldIndex[key]];
    }

    public void Add(string key, IFieldData value)
    {
      _fields.Add(value);
      _fieldIndex.Add(key, _fields.Count - 1);
    }

    internal string FindPropertyName(object value)
    {
      foreach (var item in _fields)
        if (ReferenceEquals(item.Value, value))
          return item.Name;
      return null;
    }

    public Csla.Core.MobileBindingList<IFieldData> GetFieldDataList()
    {
      return _fields;
    }

    //#region  ISerializable

    //protected FieldDataList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    //{
    //  _fields = (List<IFieldData>)(info.GetValue("Fields", typeof(List<IFieldData>)));
    //  RebuildIndex();
    //}

    //public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    //{
    //  info.AddValue("Fields", _fields);
    //}

    private void RebuildIndex()
    {
      var position = 0;
      foreach (IFieldData item in _fields)
      {
        _fieldIndex.Add(item.Name, position);
        position += 1;
      }
    }

    //#endregion


    #region ISerializationNotification Members

    void Csla.Serialization.Mobile.ISerializationNotification.Deserialized()
    {
      RebuildIndex();
    }

    #endregion
  }
}