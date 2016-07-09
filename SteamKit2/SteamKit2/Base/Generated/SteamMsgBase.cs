//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Option: light framework (CF/Silverlight) enabled
    
// Generated from: steammessages_base.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
namespace SteamKit2.Internal
{
  [global::ProtoBuf.ProtoContract(Name=@"CMsgProtoBufHeader")]
  public partial class CMsgProtoBufHeader : global::ProtoBuf.IExtensible
  {
    public CMsgProtoBufHeader() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private int _client_sessionid = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"client_sessionid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int client_sessionid
    {
      get { return _client_sessionid; }
      set { _client_sessionid = value; }
    }

    private uint _routing_appid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"routing_appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint routing_appid
    {
      get { return _routing_appid; }
      set { _routing_appid = value; }
    }

    private ulong _jobid_source = (ulong)18446744073709551615;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"jobid_source", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(@"18446744073709551615")]
    public ulong jobid_source
    {
      get { return _jobid_source; }
      set { _jobid_source = value; }
    }

    private ulong _jobid_target = (ulong)18446744073709551615;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"jobid_target", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(@"18446744073709551615")]
    public ulong jobid_target
    {
      get { return _jobid_target; }
      set { _jobid_target = value; }
    }

    private string _target_job_name = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"target_job_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string target_job_name
    {
      get { return _target_job_name; }
      set { _target_job_name = value; }
    }

    private int _seq_num = default(int);
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"seq_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int seq_num
    {
      get { return _seq_num; }
      set { _seq_num = value; }
    }

    private int _eresult = (int)2;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"eresult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)2)]
    public int eresult
    {
      get { return _eresult; }
      set { _eresult = value; }
    }

    private string _error_message = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"error_message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string error_message
    {
      get { return _error_message; }
      set { _error_message = value; }
    }

    private uint _ip = default(uint);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ip
    {
      get { return _ip; }
      set { _ip = value; }
    }

    private uint _auth_account_flags = default(uint);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"auth_account_flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint auth_account_flags
    {
      get { return _auth_account_flags; }
      set { _auth_account_flags = value; }
    }

    private uint _token_source = default(uint);
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"token_source", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint token_source
    {
      get { return _token_source; }
      set { _token_source = value; }
    }

    private bool _admin_spoofing_user = default(bool);
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"admin_spoofing_user", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool admin_spoofing_user
    {
      get { return _admin_spoofing_user; }
      set { _admin_spoofing_user = value; }
    }

    private int _transport_error = (int)1;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"transport_error", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int transport_error
    {
      get { return _transport_error; }
      set { _transport_error = value; }
    }

    private ulong _messageid = (ulong)18446744073709551615;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"messageid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(@"18446744073709551615")]
    public ulong messageid
    {
      get { return _messageid; }
      set { _messageid = value; }
    }

    private uint _publisher_group_id = default(uint);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"publisher_group_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint publisher_group_id
    {
      get { return _publisher_group_id; }
      set { _publisher_group_id = value; }
    }

    private uint _sysid = default(uint);
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"sysid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint sysid
    {
      get { return _sysid; }
      set { _sysid = value; }
    }

    private ulong _trace_tag = default(ulong);
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"trace_tag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong trace_tag
    {
      get { return _trace_tag; }
      set { _trace_tag = value; }
    }

    private uint _webapi_key_id = default(uint);
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"webapi_key_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint webapi_key_id
    {
      get { return _webapi_key_id; }
      set { _webapi_key_id = value; }
    }

    private bool _is_from_external_source = default(bool);
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"is_from_external_source", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_from_external_source
    {
      get { return _is_from_external_source; }
      set { _is_from_external_source = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CMsgMulti")]
  public partial class CMsgMulti : global::ProtoBuf.IExtensible
  {
    public CMsgMulti() {}
    

    private uint _size_unzipped = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"size_unzipped", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint size_unzipped
    {
      get { return _size_unzipped; }
      set { _size_unzipped = value; }
    }

    private byte[] _message_body = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"message_body", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] message_body
    {
      get { return _message_body; }
      set { _message_body = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CMsgProtobufWrapped")]
  public partial class CMsgProtobufWrapped : global::ProtoBuf.IExtensible
  {
    public CMsgProtobufWrapped() {}
    

    private byte[] _message_body = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"message_body", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] message_body
    {
      get { return _message_body; }
      set { _message_body = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CMsgAuthTicket")]
  public partial class CMsgAuthTicket : global::ProtoBuf.IExtensible
  {
    public CMsgAuthTicket() {}
    

    private uint _estate = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"estate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint estate
    {
      get { return _estate; }
      set { _estate = value; }
    }

    private uint _eresult = (uint)2;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"eresult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)2)]
    public uint eresult
    {
      get { return _eresult; }
      set { _eresult = value; }
    }

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private ulong _gameid = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"gameid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong gameid
    {
      get { return _gameid; }
      set { _gameid = value; }
    }

    private uint _h_steam_pipe = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"h_steam_pipe", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint h_steam_pipe
    {
      get { return _h_steam_pipe; }
      set { _h_steam_pipe = value; }
    }

    private uint _ticket_crc = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ticket_crc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ticket_crc
    {
      get { return _ticket_crc; }
      set { _ticket_crc = value; }
    }

    private byte[] _ticket = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ticket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] ticket
    {
      get { return _ticket; }
      set { _ticket = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CCDDBAppDetailCommon")]
  public partial class CCDDBAppDetailCommon : global::ProtoBuf.IExtensible
  {
    public CCDDBAppDetailCommon() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private string _icon = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }

    private string _logo = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"logo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string logo
    {
      get { return _logo; }
      set { _logo = value; }
    }

    private string _logo_small = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"logo_small", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string logo_small
    {
      get { return _logo_small; }
      set { _logo_small = value; }
    }

    private bool _tool = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"tool", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool tool
    {
      get { return _tool; }
      set { _tool = value; }
    }

    private bool _demo = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"demo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool demo
    {
      get { return _demo; }
      set { _demo = value; }
    }

    private bool _media = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"media", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool media
    {
      get { return _media; }
      set { _media = value; }
    }

    private bool _community_visible_stats = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"community_visible_stats", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool community_visible_stats
    {
      get { return _community_visible_stats; }
      set { _community_visible_stats = value; }
    }

    private string _friendly_name = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"friendly_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string friendly_name
    {
      get { return _friendly_name; }
      set { _friendly_name = value; }
    }

    private string _propagation = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"propagation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string propagation
    {
      get { return _propagation; }
      set { _propagation = value; }
    }

    private bool _has_adult_content = default(bool);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"has_adult_content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool has_adult_content
    {
      get { return _has_adult_content; }
      set { _has_adult_content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CMsgAppRights")]
  public partial class CMsgAppRights : global::ProtoBuf.IExtensible
  {
    public CMsgAppRights() {}
    

    private bool _edit_info = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"edit_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool edit_info
    {
      get { return _edit_info; }
      set { _edit_info = value; }
    }

    private bool _publish = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"publish", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool publish
    {
      get { return _publish; }
      set { _publish = value; }
    }

    private bool _view_error_data = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"view_error_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool view_error_data
    {
      get { return _view_error_data; }
      set { _view_error_data = value; }
    }

    private bool _download = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"download", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool download
    {
      get { return _download; }
      set { _download = value; }
    }

    private bool _upload_cdkeys = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"upload_cdkeys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool upload_cdkeys
    {
      get { return _upload_cdkeys; }
      set { _upload_cdkeys = value; }
    }

    private bool _generate_cdkeys = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"generate_cdkeys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool generate_cdkeys
    {
      get { return _generate_cdkeys; }
      set { _generate_cdkeys = value; }
    }

    private bool _view_financials = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"view_financials", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool view_financials
    {
      get { return _view_financials; }
      set { _view_financials = value; }
    }

    private bool _manage_ceg = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"manage_ceg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool manage_ceg
    {
      get { return _manage_ceg; }
      set { _manage_ceg = value; }
    }

    private bool _manage_signing = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"manage_signing", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool manage_signing
    {
      get { return _manage_signing; }
      set { _manage_signing = value; }
    }

    private bool _manage_cdkeys = default(bool);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"manage_cdkeys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool manage_cdkeys
    {
      get { return _manage_cdkeys; }
      set { _manage_cdkeys = value; }
    }

    private bool _edit_marketing = default(bool);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"edit_marketing", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool edit_marketing
    {
      get { return _edit_marketing; }
      set { _edit_marketing = value; }
    }

    private bool _economy_support = default(bool);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"economy_support", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool economy_support
    {
      get { return _economy_support; }
      set { _economy_support = value; }
    }

    private bool _economy_support_supervisor = default(bool);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"economy_support_supervisor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool economy_support_supervisor
    {
      get { return _economy_support_supervisor; }
      set { _economy_support_supervisor = value; }
    }

    private bool _manage_pricing = default(bool);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"manage_pricing", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool manage_pricing
    {
      get { return _manage_pricing; }
      set { _manage_pricing = value; }
    }

    private bool _broadcast_live = default(bool);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"broadcast_live", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool broadcast_live
    {
      get { return _broadcast_live; }
      set { _broadcast_live = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
#pragma warning restore 1591
