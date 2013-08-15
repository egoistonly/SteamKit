//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_parental.steamclient.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ParentalApp")]
  public partial class ParentalApp : global::ProtoBuf.IExtensible
  {
    public ParentalApp() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private bool _is_allowed = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"is_allowed", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_allowed
    {
      get { return _is_allowed; }
      set { _is_allowed = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ParentalSettings")]
  public partial class ParentalSettings : global::ProtoBuf.IExtensible
  {
    public ParentalSettings() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private uint _applist_base_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"applist_base_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint applist_base_id
    {
      get { return _applist_base_id; }
      set { _applist_base_id = value; }
    }

    private string _applist_base_description = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"applist_base_description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string applist_base_description
    {
      get { return _applist_base_description; }
      set { _applist_base_description = value; }
    }
    private readonly global::System.Collections.Generic.List<ParentalApp> _applist_base = new global::System.Collections.Generic.List<ParentalApp>();
    [global::ProtoBuf.ProtoMember(4, Name=@"applist_base", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ParentalApp> applist_base
    {
      get { return _applist_base; }
    }
  
    private readonly global::System.Collections.Generic.List<ParentalApp> _applist_custom = new global::System.Collections.Generic.List<ParentalApp>();
    [global::ProtoBuf.ProtoMember(5, Name=@"applist_custom", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ParentalApp> applist_custom
    {
      get { return _applist_custom; }
    }
  

    private uint _passwordhashtype = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"passwordhashtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint passwordhashtype
    {
      get { return _passwordhashtype; }
      set { _passwordhashtype = value; }
    }

    private byte[] _salt = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"salt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] salt
    {
      get { return _salt; }
      set { _salt = value; }
    }

    private byte[] _passwordhash = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"passwordhash", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] passwordhash
    {
      get { return _passwordhash; }
      set { _passwordhash = value; }
    }

    private bool _is_enabled = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"is_enabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_enabled
    {
      get { return _is_enabled; }
      set { _is_enabled = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_EnableParentalSettings_Request")]
  public partial class CParental_EnableParentalSettings_Request : global::ProtoBuf.IExtensible
  {
    public CParental_EnableParentalSettings_Request() {}
    

    private string _password = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }

    private ParentalSettings _settings = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"settings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ParentalSettings settings
    {
      get { return _settings; }
      set { _settings = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_EnableParentalSettings_Response")]
  public partial class CParental_EnableParentalSettings_Response : global::ProtoBuf.IExtensible
  {
    public CParental_EnableParentalSettings_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_DisableParentalSettings_Request")]
  public partial class CParental_DisableParentalSettings_Request : global::ProtoBuf.IExtensible
  {
    public CParental_DisableParentalSettings_Request() {}
    

    private string _password = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_DisableParentalSettings_Response")]
  public partial class CParental_DisableParentalSettings_Response : global::ProtoBuf.IExtensible
  {
    public CParental_DisableParentalSettings_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_GetParentalSettings_Request")]
  public partial class CParental_GetParentalSettings_Request : global::ProtoBuf.IExtensible
  {
    public CParental_GetParentalSettings_Request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_GetParentalSettings_Response")]
  public partial class CParental_GetParentalSettings_Response : global::ProtoBuf.IExtensible
  {
    public CParental_GetParentalSettings_Response() {}
    

    private ParentalSettings _settings = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"settings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ParentalSettings settings
    {
      get { return _settings; }
      set { _settings = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_GetSignedParentalSettings_Request")]
  public partial class CParental_GetSignedParentalSettings_Request : global::ProtoBuf.IExtensible
  {
    public CParental_GetSignedParentalSettings_Request() {}
    

    private uint _priority = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint priority
    {
      get { return _priority; }
      set { _priority = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_GetSignedParentalSettings_Response")]
  public partial class CParental_GetSignedParentalSettings_Response : global::ProtoBuf.IExtensible
  {
    public CParental_GetSignedParentalSettings_Response() {}
    

    private byte[] _serialized_settings = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"serialized_settings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] serialized_settings
    {
      get { return _serialized_settings; }
      set { _serialized_settings = value; }
    }

    private byte[] _signature = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] signature
    {
      get { return _signature; }
      set { _signature = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_SetParentalSettings_Request")]
  public partial class CParental_SetParentalSettings_Request : global::ProtoBuf.IExtensible
  {
    public CParental_SetParentalSettings_Request() {}
    

    private string _password = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }

    private ParentalSettings _settings = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"settings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ParentalSettings settings
    {
      get { return _settings; }
      set { _settings = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_SetParentalSettings_Response")]
  public partial class CParental_SetParentalSettings_Response : global::ProtoBuf.IExtensible
  {
    public CParental_SetParentalSettings_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CParental_ParentalSettingsChange_Notification")]
  public partial class CParental_ParentalSettingsChange_Notification : global::ProtoBuf.IExtensible
  {
    public CParental_ParentalSettingsChange_Notification() {}
    

    private byte[] _serialized_settings = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"serialized_settings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] serialized_settings
    {
      get { return _serialized_settings; }
      set { _serialized_settings = value; }
    }

    private byte[] _signature = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] signature
    {
      get { return _signature; }
      set { _signature = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IParental
    {
      CParental_EnableParentalSettings_Response EnableParentalSettings(CParental_EnableParentalSettings_Request request);
    CParental_DisableParentalSettings_Response DisableParentalSettings(CParental_DisableParentalSettings_Request request);
    CParental_GetParentalSettings_Response GetParentalSettings(CParental_GetParentalSettings_Request request);
    CParental_GetSignedParentalSettings_Response GetSignedParentalSettings(CParental_GetSignedParentalSettings_Request request);
    CParental_SetParentalSettings_Response SetParentalSettings(CParental_SetParentalSettings_Request request);
    
    }
    
    
    public interface IParentalClient
    {
      NoResponse NotifySettingsChange(CParental_ParentalSettingsChange_Notification request);
    
    }
    
    
}
#pragma warning restore 1591
