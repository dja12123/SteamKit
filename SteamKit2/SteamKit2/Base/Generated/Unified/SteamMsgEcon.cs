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
    
// Generated from: steammessages_econ.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::ProtoBuf.ProtoContract(Name=@"CEcon_ClientGetItemShopOverlayAuthURL_Request")]
  public partial class CEcon_ClientGetItemShopOverlayAuthURL_Request : global::ProtoBuf.IExtensible
  {
    public CEcon_ClientGetItemShopOverlayAuthURL_Request() {}
    

    private string _return_url = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"return_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string return_url
    {
      get { return _return_url; }
      set { _return_url = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CEcon_ClientGetItemShopOverlayAuthURL_Response")]
  public partial class CEcon_ClientGetItemShopOverlayAuthURL_Response : global::ProtoBuf.IExtensible
  {
    public CEcon_ClientGetItemShopOverlayAuthURL_Response() {}
    

    private string _url = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string url
    {
      get { return _url; }
      set { _url = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IEcon
    {
      CEcon_ClientGetItemShopOverlayAuthURL_Response ClientGetItemShopOverlayAuthURL(CEcon_ClientGetItemShopOverlayAuthURL_Request request);
    
    }
    
    
}
#pragma warning restore 1591
