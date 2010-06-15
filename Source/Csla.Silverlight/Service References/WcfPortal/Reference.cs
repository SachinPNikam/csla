﻿//-----------------------------------------------------------------------
// <copyright file="Reference.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>Criteria request type.</summary>
//-----------------------------------------------------------------------
namespace Csla.WcfPortal
{
  using System.Runtime.Serialization;

  /// <summary>
  /// Criteria request type.
  /// </summary>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
  [System.Runtime.Serialization.DataContractAttribute(Name = "CriteriaRequest", Namespace = "http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Silverlight")]
  public partial class CriteriaRequest : object, System.ComponentModel.INotifyPropertyChanged
  {

    private byte[] ClientContextField;

    private string ClientCultureField;

    private string ClientUICultureField;

    private byte[] CriteriaDataField;

    private byte[] GlobalContextField;

    private byte[] PrincipalField;

    private string TypeNameField;

    /// <summary>
    /// Gets or sets the client context byte array.
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] ClientContext
    {
      get
      {
        return this.ClientContextField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ClientContextField, value) != true))
        {
          this.ClientContextField = value;
          this.RaisePropertyChanged("ClientContext");
        }
      }
    }

    /// <summary>
    /// Gets or sets the client culture.
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string ClientCulture
    {
      get
      {
        return this.ClientCultureField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ClientCultureField, value) != true))
        {
          this.ClientCultureField = value;
          this.RaisePropertyChanged("ClientCulture");
        }
      }
    }

    /// <summary>
    /// Gets or sets the client UI culture.
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string ClientUICulture
    {
      get
      {
        return this.ClientUICultureField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ClientUICultureField, value) != true))
        {
          this.ClientUICultureField = value;
          this.RaisePropertyChanged("ClientUICulture");
        }
      }
    }

    /// <summary>
    /// Gets or sets the serialized criteria object.
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] CriteriaData
    {
      get
      {
        return this.CriteriaDataField;
      }
      set
      {
        if ((object.ReferenceEquals(this.CriteriaDataField, value) != true))
        {
          this.CriteriaDataField = value;
          this.RaisePropertyChanged("CriteriaData");
        }
      }
    }

    /// <summary>
    /// Gets or sets the global context.
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] GlobalContext
    {
      get
      {
        return this.GlobalContextField;
      }
      set
      {
        if ((object.ReferenceEquals(this.GlobalContextField, value) != true))
        {
          this.GlobalContextField = value;
          this.RaisePropertyChanged("GlobalContext");
        }
      }
    }

    /// <summary>
    /// Gets or sets the principal.
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] Principal
    {
      get
      {
        return this.PrincipalField;
      }
      set
      {
        if ((object.ReferenceEquals(this.PrincipalField, value) != true))
        {
          this.PrincipalField = value;
          this.RaisePropertyChanged("Principal");
        }
      }
    }

    /// <summary>
    /// Gets or sets the business object type name.
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string TypeName
    {
      get
      {
        return this.TypeNameField;
      }
      set
      {
        if ((object.ReferenceEquals(this.TypeNameField, value) != true))
        {
          this.TypeNameField = value;
          this.RaisePropertyChanged("TypeName");
        }
      }
    }

    /// <summary>
    /// Event raised when a property changes.
    /// </summary>
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Raises the property changed event.
    /// </summary>
    /// <param name="propertyName"></param>
    protected void RaisePropertyChanged(string propertyName)
    {
      System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if ((propertyChanged != null))
      {
        propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
      }
    }
  }

  /// <summary>
  /// 
  /// </summary>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
  [System.Runtime.Serialization.DataContractAttribute(Name = "WcfResponse", Namespace = "http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Silverlight")]
  public partial class WcfResponse : object, System.ComponentModel.INotifyPropertyChanged
  {

    private Csla.WcfPortal.WcfErrorInfo ErrorDataField;

    private byte[] GlobalContextField;

    private byte[] ObjectDataField;

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public Csla.WcfPortal.WcfErrorInfo ErrorData
    {
      get
      {
        return this.ErrorDataField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ErrorDataField, value) != true))
        {
          this.ErrorDataField = value;
          this.RaisePropertyChanged("ErrorData");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] GlobalContext
    {
      get
      {
        return this.GlobalContextField;
      }
      set
      {
        if ((object.ReferenceEquals(this.GlobalContextField, value) != true))
        {
          this.GlobalContextField = value;
          this.RaisePropertyChanged("GlobalContext");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] ObjectData
    {
      get
      {
        return this.ObjectDataField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ObjectDataField, value) != true))
        {
          this.ObjectDataField = value;
          this.RaisePropertyChanged("ObjectData");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="propertyName"></param>
    protected void RaisePropertyChanged(string propertyName)
    {
      System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if ((propertyChanged != null))
      {
        propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
      }
    }
  }

  /// <summary>
  /// 
  /// </summary>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
  [System.Runtime.Serialization.DataContractAttribute(Name = "WcfErrorInfo", Namespace = "http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Silverlight")]
  public partial class WcfErrorInfo : object, System.ComponentModel.INotifyPropertyChanged
  {

    private string ExceptionTypeNameField;

    private Csla.WcfPortal.WcfErrorInfo InnerErrorField;

    private string MessageField;

    private string SourceField;

    private string StackTraceField;

    private string TargetSiteNameField;

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string ExceptionTypeName
    {
      get
      {
        return this.ExceptionTypeNameField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ExceptionTypeNameField, value) != true))
        {
          this.ExceptionTypeNameField = value;
          this.RaisePropertyChanged("ExceptionTypeName");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public Csla.WcfPortal.WcfErrorInfo InnerError
    {
      get
      {
        return this.InnerErrorField;
      }
      set
      {
        if ((object.ReferenceEquals(this.InnerErrorField, value) != true))
        {
          this.InnerErrorField = value;
          this.RaisePropertyChanged("InnerError");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string Message
    {
      get
      {
        return this.MessageField;
      }
      set
      {
        if ((object.ReferenceEquals(this.MessageField, value) != true))
        {
          this.MessageField = value;
          this.RaisePropertyChanged("Message");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string Source
    {
      get
      {
        return this.SourceField;
      }
      set
      {
        if ((object.ReferenceEquals(this.SourceField, value) != true))
        {
          this.SourceField = value;
          this.RaisePropertyChanged("Source");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string StackTrace
    {
      get
      {
        return this.StackTraceField;
      }
      set
      {
        if ((object.ReferenceEquals(this.StackTraceField, value) != true))
        {
          this.StackTraceField = value;
          this.RaisePropertyChanged("StackTrace");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string TargetSiteName
    {
      get
      {
        return this.TargetSiteNameField;
      }
      set
      {
        if ((object.ReferenceEquals(this.TargetSiteNameField, value) != true))
        {
          this.TargetSiteNameField = value;
          this.RaisePropertyChanged("TargetSiteName");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="propertyName"></param>
    protected void RaisePropertyChanged(string propertyName)
    {
      System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if ((propertyChanged != null))
      {
        propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
      }
    }
  }

  /// <summary>
  /// 
  /// </summary>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
  [System.Runtime.Serialization.DataContractAttribute(Name = "UpdateRequest", Namespace = "http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Silverlight")]
  public partial class UpdateRequest : object, System.ComponentModel.INotifyPropertyChanged
  {

    private byte[] ClientContextField;

    private string ClientCultureField;

    private string ClientUICultureField;

    private byte[] GlobalContextField;

    private byte[] ObjectDataField;

    private byte[] PrincipalField;

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] ClientContext
    {
      get
      {
        return this.ClientContextField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ClientContextField, value) != true))
        {
          this.ClientContextField = value;
          this.RaisePropertyChanged("ClientContext");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string ClientCulture
    {
      get
      {
        return this.ClientCultureField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ClientCultureField, value) != true))
        {
          this.ClientCultureField = value;
          this.RaisePropertyChanged("ClientCulture");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string ClientUICulture
    {
      get
      {
        return this.ClientUICultureField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ClientUICultureField, value) != true))
        {
          this.ClientUICultureField = value;
          this.RaisePropertyChanged("ClientUICulture");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] GlobalContext
    {
      get
      {
        return this.GlobalContextField;
      }
      set
      {
        if ((object.ReferenceEquals(this.GlobalContextField, value) != true))
        {
          this.GlobalContextField = value;
          this.RaisePropertyChanged("GlobalContext");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] ObjectData
    {
      get
      {
        return this.ObjectDataField;
      }
      set
      {
        if ((object.ReferenceEquals(this.ObjectDataField, value) != true))
        {
          this.ObjectDataField = value;
          this.RaisePropertyChanged("ObjectData");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte[] Principal
    {
      get
      {
        return this.PrincipalField;
      }
      set
      {
        if ((object.ReferenceEquals(this.PrincipalField, value) != true))
        {
          this.PrincipalField = value;
          this.RaisePropertyChanged("Principal");
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="propertyName"></param>
    protected void RaisePropertyChanged(string propertyName)
    {
      System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if ((propertyChanged != null))
      {
        propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
      }
    }
  }

  /// <summary>
  /// 
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
  [System.ServiceModel.ServiceContractAttribute(Namespace = "http://ws.lhotka.net/WcfDataPortal", ConfigurationName = "WcfPortal.IWcfPortal")]
  public interface IWcfPortal
  {

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="callback"></param>
    /// <param name="asyncState"></param>
    /// <returns></returns>
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Create", ReplyAction = "http://ws.lhotka.net/WcfDataPortal/IWcfPortal/CreateResponse")]
    System.IAsyncResult BeginCreate(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="result"></param>
    /// <returns></returns>
    Csla.WcfPortal.WcfResponse EndCreate(System.IAsyncResult result);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="callback"></param>
    /// <param name="asyncState"></param>
    /// <returns></returns>
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Fetch", ReplyAction = "http://ws.lhotka.net/WcfDataPortal/IWcfPortal/FetchResponse")]
    System.IAsyncResult BeginFetch(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="result"></param>
    /// <returns></returns>
    Csla.WcfPortal.WcfResponse EndFetch(System.IAsyncResult result);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="callback"></param>
    /// <param name="asyncState"></param>
    /// <returns></returns>
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Update", ReplyAction = "http://ws.lhotka.net/WcfDataPortal/IWcfPortal/UpdateResponse")]
    System.IAsyncResult BeginUpdate(Csla.WcfPortal.UpdateRequest request, System.AsyncCallback callback, object asyncState);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="result"></param>
    /// <returns></returns>
    Csla.WcfPortal.WcfResponse EndUpdate(System.IAsyncResult result);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="callback"></param>
    /// <param name="asyncState"></param>
    /// <returns></returns>
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Delete", ReplyAction = "http://ws.lhotka.net/WcfDataPortal/IWcfPortal/DeleteResponse")]
    System.IAsyncResult BeginDelete(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="result"></param>
    /// <returns></returns>
    Csla.WcfPortal.WcfResponse EndDelete(System.IAsyncResult result);
  }

  /// <summary>
  /// 
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
  public interface IWcfPortalChannel : Csla.WcfPortal.IWcfPortal, System.ServiceModel.IClientChannel
  {
  }

  /// <summary>
  /// 
  /// </summary>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
  public partial class CreateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
  {

    private object[] results;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="results"></param>
    /// <param name="exception"></param>
    /// <param name="cancelled"></param>
    /// <param name="userState"></param>
    public CreateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
      base(exception, cancelled, userState)
    {
      this.results = results;
    }

    /// <summary>
    /// 
    /// </summary>
    public Csla.WcfPortal.WcfResponse Result
    {
      get
      {
        base.RaiseExceptionIfNecessary();
        return ((Csla.WcfPortal.WcfResponse)(this.results[0]));
      }
    }
  }

  /// <summary>
  /// 
  /// </summary>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
  public partial class FetchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
  {

    private object[] results;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="results"></param>
    /// <param name="exception"></param>
    /// <param name="cancelled"></param>
    /// <param name="userState"></param>
    public FetchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
      base(exception, cancelled, userState)
    {
      this.results = results;
    }
    /// <summary>
    /// 
    /// </summary>
    public Csla.WcfPortal.WcfResponse Result
    {
      get
      {
        base.RaiseExceptionIfNecessary();
        return ((Csla.WcfPortal.WcfResponse)(this.results[0]));
      }
    }
  }
  /// <summary>
  /// 
  /// </summary>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
  public partial class UpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
  {

    private object[] results;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="results"></param>
    /// <param name="exception"></param>
    /// <param name="cancelled"></param>
    /// <param name="userState"></param>
    public UpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
      base(exception, cancelled, userState)
    {
      this.results = results;
    }
    /// <summary>
    /// 
    /// </summary>
    public Csla.WcfPortal.WcfResponse Result
    {
      get
      {
        base.RaiseExceptionIfNecessary();
        return ((Csla.WcfPortal.WcfResponse)(this.results[0]));
      }
    }
  }
  /// <summary>
  /// 
  /// </summary>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
  public partial class DeleteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
  {

    private object[] results;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="results"></param>
    /// <param name="exception"></param>
    /// <param name="cancelled"></param>
    /// <param name="userState"></param>
    public DeleteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
      base(exception, cancelled, userState)
    {
      this.results = results;
    }
    /// <summary>
    /// 
    /// </summary>
    public Csla.WcfPortal.WcfResponse Result
    {
      get
      {
        base.RaiseExceptionIfNecessary();
        return ((Csla.WcfPortal.WcfResponse)(this.results[0]));
      }
    }
  }
  /// <summary>
  /// 
  /// </summary>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
  public partial class WcfPortalClient : System.ServiceModel.ClientBase<Csla.WcfPortal.IWcfPortal>, Csla.WcfPortal.IWcfPortal
  {

    private BeginOperationDelegate onBeginCreateDelegate;

    private EndOperationDelegate onEndCreateDelegate;

    private System.Threading.SendOrPostCallback onCreateCompletedDelegate;

    private BeginOperationDelegate onBeginFetchDelegate;

    private EndOperationDelegate onEndFetchDelegate;

    private System.Threading.SendOrPostCallback onFetchCompletedDelegate;

    private BeginOperationDelegate onBeginUpdateDelegate;

    private EndOperationDelegate onEndUpdateDelegate;

    private System.Threading.SendOrPostCallback onUpdateCompletedDelegate;

    private BeginOperationDelegate onBeginDeleteDelegate;

    private EndOperationDelegate onEndDeleteDelegate;

    private System.Threading.SendOrPostCallback onDeleteCompletedDelegate;

    private BeginOperationDelegate onBeginOpenDelegate;

    private EndOperationDelegate onEndOpenDelegate;

    private System.Threading.SendOrPostCallback onOpenCompletedDelegate;

    private BeginOperationDelegate onBeginCloseDelegate;

    private EndOperationDelegate onEndCloseDelegate;

    private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
    /// <summary>
    /// 
    /// </summary>
    public WcfPortalClient()
    {
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="endpointConfigurationName"></param>
    public WcfPortalClient(string endpointConfigurationName) :
      base(endpointConfigurationName)
    {
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="endpointConfigurationName"></param>
    /// <param name="remoteAddress"></param>
    public WcfPortalClient(string endpointConfigurationName, string remoteAddress) :
      base(endpointConfigurationName, remoteAddress)
    {
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="endpointConfigurationName"></param>
    /// <param name="remoteAddress"></param>
    public WcfPortalClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
      base(endpointConfigurationName, remoteAddress)
    {
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="binding"></param>
    /// <param name="remoteAddress"></param>
    public WcfPortalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
      base(binding, remoteAddress)
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public System.Net.CookieContainer CookieContainer
    {
      get
      {
        System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
        if ((httpCookieContainerManager != null))
        {
          return httpCookieContainerManager.CookieContainer;
        }
        else
        {
          return null;
        }
      }
      set
      {
        System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
        if ((httpCookieContainerManager != null))
        {
          httpCookieContainerManager.CookieContainer = value;
        }
        else
        {
          throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                  "ookieContainerBindingElement.");
        }
      }
    }
    /// <summary>
    /// 
    /// </summary>
    public event System.EventHandler<CreateCompletedEventArgs> CreateCompleted;
    /// <summary>
    /// 
    /// </summary>
    public event System.EventHandler<FetchCompletedEventArgs> FetchCompleted;
    /// <summary>
    /// 
    /// </summary>
    public event System.EventHandler<UpdateCompletedEventArgs> UpdateCompleted;
    /// <summary>
    /// 
    /// </summary>
    public event System.EventHandler<DeleteCompletedEventArgs> DeleteCompleted;
    /// <summary>
    /// 
    /// </summary>
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
    /// <summary>
    /// 
    /// </summary>
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="callback"></param>
    /// <param name="asyncState"></param>
    /// <returns></returns>
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult Csla.WcfPortal.IWcfPortal.BeginCreate(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState)
    {
      return base.Channel.BeginCreate(request, callback, asyncState);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="result"></param>
    /// <returns></returns>
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    Csla.WcfPortal.WcfResponse Csla.WcfPortal.IWcfPortal.EndCreate(System.IAsyncResult result)
    {
      return base.Channel.EndCreate(result);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="inValues"></param>
    /// <param name="callback"></param>
    /// <param name="asyncState"></param>
    /// <returns></returns>
    private System.IAsyncResult OnBeginCreate(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
      Csla.WcfPortal.CriteriaRequest request = ((Csla.WcfPortal.CriteriaRequest)(inValues[0]));
      return ((Csla.WcfPortal.IWcfPortal)(this)).BeginCreate(request, callback, asyncState);
    }

    private object[] OnEndCreate(System.IAsyncResult result)
    {
      Csla.WcfPortal.WcfResponse retVal = ((Csla.WcfPortal.IWcfPortal)(this)).EndCreate(result);
      return new object[] {
                    retVal};
    }

    private void OnCreateCompleted(object state)
    {
      if ((this.CreateCompleted != null))
      {
        InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
        this.CreateCompleted(this, new CreateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
      }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    public void CreateAsync(Csla.WcfPortal.CriteriaRequest request)
    {
      this.CreateAsync(request, null);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="userState"></param>
    public void CreateAsync(Csla.WcfPortal.CriteriaRequest request, object userState)
    {
      if ((this.onBeginCreateDelegate == null))
      {
        this.onBeginCreateDelegate = new BeginOperationDelegate(this.OnBeginCreate);
      }
      if ((this.onEndCreateDelegate == null))
      {
        this.onEndCreateDelegate = new EndOperationDelegate(this.OnEndCreate);
      }
      if ((this.onCreateCompletedDelegate == null))
      {
        this.onCreateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateCompleted);
      }
      base.InvokeAsync(this.onBeginCreateDelegate, new object[] {
                        request}, this.onEndCreateDelegate, this.onCreateCompletedDelegate, userState);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="callback"></param>
    /// <param name="asyncState"></param>
    /// <returns></returns>
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult Csla.WcfPortal.IWcfPortal.BeginFetch(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState)
    {
      return base.Channel.BeginFetch(request, callback, asyncState);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    Csla.WcfPortal.WcfResponse Csla.WcfPortal.IWcfPortal.EndFetch(System.IAsyncResult result)
    {
      return base.Channel.EndFetch(result);
    }

    private System.IAsyncResult OnBeginFetch(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
      Csla.WcfPortal.CriteriaRequest request = ((Csla.WcfPortal.CriteriaRequest)(inValues[0]));
      return ((Csla.WcfPortal.IWcfPortal)(this)).BeginFetch(request, callback, asyncState);
    }

    private object[] OnEndFetch(System.IAsyncResult result)
    {
      Csla.WcfPortal.WcfResponse retVal = ((Csla.WcfPortal.IWcfPortal)(this)).EndFetch(result);
      return new object[] {
                    retVal};
    }

    private void OnFetchCompleted(object state)
    {
      if ((this.FetchCompleted != null))
      {
        InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
        this.FetchCompleted(this, new FetchCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
      }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    public void FetchAsync(Csla.WcfPortal.CriteriaRequest request)
    {
      this.FetchAsync(request, null);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="userState"></param>
    public void FetchAsync(Csla.WcfPortal.CriteriaRequest request, object userState)
    {
      if ((this.onBeginFetchDelegate == null))
      {
        this.onBeginFetchDelegate = new BeginOperationDelegate(this.OnBeginFetch);
      }
      if ((this.onEndFetchDelegate == null))
      {
        this.onEndFetchDelegate = new EndOperationDelegate(this.OnEndFetch);
      }
      if ((this.onFetchCompletedDelegate == null))
      {
        this.onFetchCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnFetchCompleted);
      }
      base.InvokeAsync(this.onBeginFetchDelegate, new object[] {
                        request}, this.onEndFetchDelegate, this.onFetchCompletedDelegate, userState);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult Csla.WcfPortal.IWcfPortal.BeginUpdate(Csla.WcfPortal.UpdateRequest request, System.AsyncCallback callback, object asyncState)
    {
      return base.Channel.BeginUpdate(request, callback, asyncState);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    Csla.WcfPortal.WcfResponse Csla.WcfPortal.IWcfPortal.EndUpdate(System.IAsyncResult result)
    {
      return base.Channel.EndUpdate(result);
    }

    private System.IAsyncResult OnBeginUpdate(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
      Csla.WcfPortal.UpdateRequest request = ((Csla.WcfPortal.UpdateRequest)(inValues[0]));
      return ((Csla.WcfPortal.IWcfPortal)(this)).BeginUpdate(request, callback, asyncState);
    }

    private object[] OnEndUpdate(System.IAsyncResult result)
    {
      Csla.WcfPortal.WcfResponse retVal = ((Csla.WcfPortal.IWcfPortal)(this)).EndUpdate(result);
      return new object[] {
                    retVal};
    }

    private void OnUpdateCompleted(object state)
    {
      if ((this.UpdateCompleted != null))
      {
        InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
        this.UpdateCompleted(this, new UpdateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
      }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    public void UpdateAsync(Csla.WcfPortal.UpdateRequest request)
    {
      this.UpdateAsync(request, null);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="userState"></param>
    public void UpdateAsync(Csla.WcfPortal.UpdateRequest request, object userState)
    {
      if ((this.onBeginUpdateDelegate == null))
      {
        this.onBeginUpdateDelegate = new BeginOperationDelegate(this.OnBeginUpdate);
      }
      if ((this.onEndUpdateDelegate == null))
      {
        this.onEndUpdateDelegate = new EndOperationDelegate(this.OnEndUpdate);
      }
      if ((this.onUpdateCompletedDelegate == null))
      {
        this.onUpdateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateCompleted);
      }
      base.InvokeAsync(this.onBeginUpdateDelegate, new object[] {
                        request}, this.onEndUpdateDelegate, this.onUpdateCompletedDelegate, userState);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult Csla.WcfPortal.IWcfPortal.BeginDelete(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState)
    {
      return base.Channel.BeginDelete(request, callback, asyncState);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    Csla.WcfPortal.WcfResponse Csla.WcfPortal.IWcfPortal.EndDelete(System.IAsyncResult result)
    {
      return base.Channel.EndDelete(result);
    }

    private System.IAsyncResult OnBeginDelete(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
      Csla.WcfPortal.CriteriaRequest request = ((Csla.WcfPortal.CriteriaRequest)(inValues[0]));
      return ((Csla.WcfPortal.IWcfPortal)(this)).BeginDelete(request, callback, asyncState);
    }

    private object[] OnEndDelete(System.IAsyncResult result)
    {
      Csla.WcfPortal.WcfResponse retVal = ((Csla.WcfPortal.IWcfPortal)(this)).EndDelete(result);
      return new object[] {
                    retVal};
    }

    private void OnDeleteCompleted(object state)
    {
      if ((this.DeleteCompleted != null))
      {
        InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
        this.DeleteCompleted(this, new DeleteCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
      }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    public void DeleteAsync(Csla.WcfPortal.CriteriaRequest request)
    {
      this.DeleteAsync(request, null);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="userState"></param>
    public void DeleteAsync(Csla.WcfPortal.CriteriaRequest request, object userState)
    {
      if ((this.onBeginDeleteDelegate == null))
      {
        this.onBeginDeleteDelegate = new BeginOperationDelegate(this.OnBeginDelete);
      }
      if ((this.onEndDeleteDelegate == null))
      {
        this.onEndDeleteDelegate = new EndOperationDelegate(this.OnEndDelete);
      }
      if ((this.onDeleteCompletedDelegate == null))
      {
        this.onDeleteCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDeleteCompleted);
      }
      base.InvokeAsync(this.onBeginDeleteDelegate, new object[] {
                        request}, this.onEndDeleteDelegate, this.onDeleteCompletedDelegate, userState);
    }

    private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
      return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
    }

    private object[] OnEndOpen(System.IAsyncResult result)
    {
      ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
      return null;
    }

    private void OnOpenCompleted(object state)
    {
      if ((this.OpenCompleted != null))
      {
        InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
        this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
      }
    }
    /// <summary>
    /// 
    /// </summary>
    public void OpenAsync()
    {
      this.OpenAsync(null);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="userState"></param>
    public void OpenAsync(object userState)
    {
      if ((this.onBeginOpenDelegate == null))
      {
        this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
      }
      if ((this.onEndOpenDelegate == null))
      {
        this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
      }
      if ((this.onOpenCompletedDelegate == null))
      {
        this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
      }
      base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
    }

    private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
      return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
    }

    private object[] OnEndClose(System.IAsyncResult result)
    {
      ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
      return null;
    }

    private void OnCloseCompleted(object state)
    {
      if ((this.CloseCompleted != null))
      {
        InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
        this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
      }
    }
    /// <summary>
    /// 
    /// </summary>
    public void CloseAsync()
    {
      this.CloseAsync(null);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="userState"></param>
    public void CloseAsync(object userState)
    {
      if ((this.onBeginCloseDelegate == null))
      {
        this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
      }
      if ((this.onEndCloseDelegate == null))
      {
        this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
      }
      if ((this.onCloseCompletedDelegate == null))
      {
        this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
      }
      base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override Csla.WcfPortal.IWcfPortal CreateChannel()
    {
      return new WcfPortalClientChannel(this);
    }

    private class WcfPortalClientChannel : ChannelBase<Csla.WcfPortal.IWcfPortal>, Csla.WcfPortal.IWcfPortal
    {

      public WcfPortalClientChannel(System.ServiceModel.ClientBase<Csla.WcfPortal.IWcfPortal> client) :
        base(client)
      {
      }

      public System.IAsyncResult BeginCreate(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState)
      {
        object[] _args = new object[1];
        _args[0] = request;
        System.IAsyncResult _result = base.BeginInvoke("Create", _args, callback, asyncState);
        return _result;
      }

      public Csla.WcfPortal.WcfResponse EndCreate(System.IAsyncResult result)
      {
        object[] _args = new object[0];
        Csla.WcfPortal.WcfResponse _result = ((Csla.WcfPortal.WcfResponse)(base.EndInvoke("Create", _args, result)));
        return _result;
      }

      public System.IAsyncResult BeginFetch(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState)
      {
        object[] _args = new object[1];
        _args[0] = request;
        System.IAsyncResult _result = base.BeginInvoke("Fetch", _args, callback, asyncState);
        return _result;
      }

      public Csla.WcfPortal.WcfResponse EndFetch(System.IAsyncResult result)
      {
        object[] _args = new object[0];
        Csla.WcfPortal.WcfResponse _result = ((Csla.WcfPortal.WcfResponse)(base.EndInvoke("Fetch", _args, result)));
        return _result;
      }

      public System.IAsyncResult BeginUpdate(Csla.WcfPortal.UpdateRequest request, System.AsyncCallback callback, object asyncState)
      {
        object[] _args = new object[1];
        _args[0] = request;
        System.IAsyncResult _result = base.BeginInvoke("Update", _args, callback, asyncState);
        return _result;
      }

      public Csla.WcfPortal.WcfResponse EndUpdate(System.IAsyncResult result)
      {
        object[] _args = new object[0];
        Csla.WcfPortal.WcfResponse _result = ((Csla.WcfPortal.WcfResponse)(base.EndInvoke("Update", _args, result)));
        return _result;
      }

      public System.IAsyncResult BeginDelete(Csla.WcfPortal.CriteriaRequest request, System.AsyncCallback callback, object asyncState)
      {
        object[] _args = new object[1];
        _args[0] = request;
        System.IAsyncResult _result = base.BeginInvoke("Delete", _args, callback, asyncState);
        return _result;
      }

      public Csla.WcfPortal.WcfResponse EndDelete(System.IAsyncResult result)
      {
        object[] _args = new object[0];
        Csla.WcfPortal.WcfResponse _result = ((Csla.WcfPortal.WcfResponse)(base.EndInvoke("Delete", _args, result)));
        return _result;
      }
    }
  }
}