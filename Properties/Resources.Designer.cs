﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenTrace.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenTrace.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 About... 的本地化字符串。
        /// </summary>
        public static string ABOUT {
            get {
                return ResourceManager.GetString("ABOUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Additional Arguments 的本地化字符串。
        /// </summary>
        public static string ADDITIONAL_ARGS {
            get {
                return ResourceManager.GetString("ADDITIONAL_ARGS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 OpenTrace 的本地化字符串。
        /// </summary>
        public static string APPTITLE {
            get {
                return ResourceManager.GetString("APPTITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 NextTrace needs certain types (11 and 3) of ICMP messages to fully trace routes. But Windows firewall blocks these ICMP by default, causing only the last hop to be displayed.
        ///Would you like to add a firewall rule to allow needed ICMP for NextTrace? 的本地化字符串。
        /// </summary>
        public static string ASK_ADD_ICMP_FIREWALL_RULE {
            get {
                return ResourceManager.GetString("ASK_ADD_ICMP_FIREWALL_RULE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (Auto Detect) 的本地化字符串。
        /// </summary>
        public static string AUTO_DETECT {
            get {
                return ResourceManager.GetString("AUTO_DETECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Avg. 的本地化字符串。
        /// </summary>
        public static string AVRG {
            get {
                return ResourceManager.GetString("AVRG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 window.opentrace = {
        ///	Hops: [],
        ///	reset: function (hideMapPopup = false) {
        ///		map.enableScrollWheelZoom(true); //滚轮
        ///		map.clearOverlays(); //清除覆盖物
        ///		this.Hops = [];
        ///		this.hideMapPopup = hideMapPopup;
        ///		if (document.getElementById(&quot;opentracePopup&quot;)) document.getElementById(&quot;opentracePopup&quot;).remove();
        ///	},
        ///
        ///	addHop: function (hop) {
        ///		hop = JSON.parse(hop);
        ///		console.log(hop);
        ///		this.Hops.push(hop);
        ///		// 重新计算中心点并画图
        ///		map.clearOverlays(); //清除覆盖物
        ///		var pointlygon_array = []; //折线需要的数组
        ///		for (var [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string baiduMap {
            get {
                return ResourceManager.GetString("baiduMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Best 的本地化字符串。
        /// </summary>
        public static string BEST {
            get {
                return ResourceManager.GetString("BEST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cancel 的本地化字符串。
        /// </summary>
        public static string CANCEL {
            get {
                return ResourceManager.GetString("CANCEL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 CHUNZHEN Endpoint 的本地化字符串。
        /// </summary>
        public static string CHUNZHEN_ENDPOINT {
            get {
                return ResourceManager.GetString("CHUNZHEN_ENDPOINT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Close 的本地化字符串。
        /// </summary>
        public static string CLOSE {
            get {
                return ResourceManager.GetString("CLOSE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Combine Geography and Organization into a single column 的本地化字符串。
        /// </summary>
        public static string COMBINE_GEO_ORG {
            get {
                return ResourceManager.GetString("COMBINE_GEO_ORG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Copy  的本地化字符串。
        /// </summary>
        public static string COPY {
            get {
                return ResourceManager.GetString("COPY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Custom DNS Resolvers
        ///(DNS / DoH Supported) 的本地化字符串。
        /// </summary>
        public static string CUSTOM_DNS_RESOLVERS {
            get {
                return ResourceManager.GetString("CUSTOM_DNS_RESOLVERS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Disabled 的本地化字符串。
        /// </summary>
        public static string DISABLE_IPGEO {
            get {
                return ResourceManager.GetString("DISABLE_IPGEO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Destination port / Initial seq 的本地化字符串。
        /// </summary>
        public static string DST_PORT_INIT_SEQ {
            get {
                return ResourceManager.GetString("DST_PORT_INIT_SEQ", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Host or IP cannot be empty 的本地化字符串。
        /// </summary>
        public static string EMPTY_HOSTNAME_MSGBOX {
            get {
                return ResourceManager.GetString("EMPTY_HOSTNAME_MSGBOX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Enable offline database Ip2region (ip2region.db) 的本地化字符串。
        /// </summary>
        public static string ENABLE_IP2REGION {
            get {
                return ResourceManager.GetString("ENABLE_IP2REGION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Enable offline database IPInfo (ipinfoLocal.mmdb) 的本地化字符串。
        /// </summary>
        public static string ENABLE_IPINFOLOCAL {
            get {
                return ResourceManager.GetString("ENABLE_IPINFOLOCAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Error Message 的本地化字符串。
        /// </summary>
        public static string ERR_MSG {
            get {
                return ResourceManager.GetString("ERR_MSG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Error writing app settings. 的本地化字符串。
        /// </summary>
        public static string ERR_WRITING_SETTINGS {
            get {
                return ResourceManager.GetString("ERR_WRITING_SETTINGS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 NextTrace generated one or more unexpected outputs during runtime. Please check the output below for troubleshooting. You can refer to the NextTrace Wiki to see if there is already an answer; if you cannot find the answer, please report it to us. 的本地化字符串。
        /// </summary>
        public static string EXC_OUTPUT_FORM_PROMPT {
            get {
                return ResourceManager.GetString("EXC_OUTPUT_FORM_PROMPT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Report this issue 的本地化字符串。
        /// </summary>
        public static string EXC_OUTPUT_FORM_REPORT {
            get {
                return ResourceManager.GetString("EXC_OUTPUT_FORM_REPORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unexpected Output 的本地化字符串。
        /// </summary>
        public static string EXC_OUTPUT_FORM_TITLE {
            get {
                return ResourceManager.GetString("EXC_OUTPUT_FORM_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 NextTrace process exited unexpectedly. Please refer to the error message to learn more and report this issue to us. Exit Code:  的本地化字符串。
        /// </summary>
        public static string EXCEPTIONAL_EXIT_MSG {
            get {
                return ResourceManager.GetString("EXCEPTIONAL_EXIT_MSG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Executable Path 的本地化字符串。
        /// </summary>
        public static string EXE_PATH {
            get {
                return ResourceManager.GetString("EXE_PATH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Export 的本地化字符串。
        /// </summary>
        public static string EXPORT {
            get {
                return ResourceManager.GetString("EXPORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Export To 的本地化字符串。
        /// </summary>
        public static string EXPORT_TO {
            get {
                return ResourceManager.GetString("EXPORT_TO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to add firewall rules. 的本地化字符串。
        /// </summary>
        public static string FAILED_TO_ADD_RULES {
            get {
                return ResourceManager.GetString("FAILED_TO_ADD_RULES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 File 的本地化字符串。
        /// </summary>
        public static string FILE {
            get {
                return ResourceManager.GetString("FILE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 First TTL Hop 的本地化字符串。
        /// </summary>
        public static string FIRST_TTL_HOP {
            get {
                return ResourceManager.GetString("FIRST_TTL_HOP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 General 的本地化字符串。
        /// </summary>
        public static string GENERAL {
            get {
                return ResourceManager.GetString("GENERAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Geolocation 的本地化字符串。
        /// </summary>
        public static string GEOLOCATION {
            get {
                return ResourceManager.GetString("GEOLOCATION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 window.opentrace = {
        ///	Hops: [],
        ///	reset: function (hideMapPopup = false) {
        ///		window.gmap = new google.maps.Map(document.getElementById(&quot;map&quot;), { center: { lat: 0, lng: 0 }, zoom: 2, disableDefaultUI: true });
        ///		gmap.overlayMapTypes.clear();
        ///		this.Hops = [];
        ///		this.hideMapPopup = hideMapPopup;
        ///		if (document.getElementById(&quot;opentracePopup&quot;)) document.getElementById(&quot;opentracePopup&quot;).remove();
        ///	},
        ///
        ///	addHop: function (hop) {
        ///
        ///		// Parse the JSON string into an object
        ///		const hopData = JSON.parse(h [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string googleMap {
            get {
                return ResourceManager.GetString("googleMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Grid Height Ratio 的本地化字符串。
        /// </summary>
        public static string GRID_SIZE_RATIO {
            get {
                return ResourceManager.GetString("GRID_SIZE_RATIO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Help 的本地化字符串。
        /// </summary>
        public static string HELP {
            get {
                return ResourceManager.GetString("HELP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Hide the prompt to add firewall rules 的本地化字符串。
        /// </summary>
        public static string HIDE_ADD_FIREWALL_PROMPT {
            get {
                return ResourceManager.GetString("HIDE_ADD_FIREWALL_PROMPT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Hide the map&apos;s info windows 的本地化字符串。
        /// </summary>
        public static string HIDE_MAP_POPUP {
            get {
                return ResourceManager.GetString("HIDE_MAP_POPUP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 History 的本地化字符串。
        /// </summary>
        public static string HISTORY {
            get {
                return ResourceManager.GetString("HISTORY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Homepage 的本地化字符串。
        /// </summary>
        public static string HOMEPAGE {
            get {
                return ResourceManager.GetString("HOMEPAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Hostname 的本地化字符串。
        /// </summary>
        public static string HOSTNAME {
            get {
                return ResourceManager.GetString("HOSTNAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 IP Geograph Data Provider 的本地化字符串。
        /// </summary>
        public static string IP_GEO_DATA_PROVIDER {
            get {
                return ResourceManager.GetString("IP_GEO_DATA_PROVIDER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 IPInfo Token (Optional) 的本地化字符串。
        /// </summary>
        public static string IPINFO_TOKEN {
            get {
                return ResourceManager.GetString("IPINFO_TOKEN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Language (语言) 的本地化字符串。
        /// </summary>
        public static string LANGUAGE {
            get {
                return ResourceManager.GetString("LANGUAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Last 的本地化字符串。
        /// </summary>
        public static string LAST {
            get {
                return ResourceManager.GetString("LAST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 LeoMoeAPI Reverse Proxy 的本地化字符串。
        /// </summary>
        public static string LEOMOEAPI_HOSTPORT {
            get {
                return ResourceManager.GetString("LEOMOEAPI_HOSTPORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Link-local Address 的本地化字符串。
        /// </summary>
        public static string LINKLOCAL_ADDR {
            get {
                return ResourceManager.GetString("LINKLOCAL_ADDR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Local MMDB Overwrite 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB {
            get {
                return ResourceManager.GetString("LOCAL_MMDB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Address Template 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_ADDR {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_ADDR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ASN Template 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_ASN {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_ASN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Hostname Template 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_HOSTNAME {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_HOSTNAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Latitude Template 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_LAT {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_LAT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Longitude Template 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_LON {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_LON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Organization Template 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_ORG {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_ORG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Local MMDB Path 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_PATH {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_PATH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Presets 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_PRESETS {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_PRESETS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Preview MMDB File 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_PREVIEW {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_PREVIEW", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Preview MMDB IP 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_PREVIEW_IP {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_PREVIEW_IP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Select MMDB File 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_SELECT {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use MMDB query result overwrite original result
        ///Leave empty to avoid overwrite field
        ///Template Example: {.country}-{.city} 的本地化字符串。
        /// </summary>
        public static string LOCAL_MMDB_TIPS {
            get {
                return ResourceManager.GetString("LOCAL_MMDB_TIPS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Loopback Address 的本地化字符串。
        /// </summary>
        public static string LOOPBACK_ADDR {
            get {
                return ResourceManager.GetString("LOOPBACK_ADDR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Loss% 的本地化字符串。
        /// </summary>
        public static string LOSS {
            get {
                return ResourceManager.GetString("LOSS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 OpenTrace is quarantined by macOS, something may be inoperative.
        ///Please release OpenTrace as follows:
        ///
        ///sudo xattr -r -d com.apple.quarantine &lt;drag and drop OpenTrace here&gt;
        ///
        ///And restart OpenTrace after execution. 的本地化字符串。
        /// </summary>
        public static string MACOS_QUARANTINE {
            get {
                return ResourceManager.GetString("MACOS_QUARANTINE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Map Provider 的本地化字符串。
        /// </summary>
        public static string MAP_PROVIDER {
            get {
                return ResourceManager.GetString("MAP_PROVIDER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Baidu Maps 的本地化字符串。
        /// </summary>
        public static string MAP_PROVIDER_BAIDU {
            get {
                return ResourceManager.GetString("MAP_PROVIDER_BAIDU", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Google Maps 的本地化字符串。
        /// </summary>
        public static string MAP_PROVIDER_GOOGLE {
            get {
                return ResourceManager.GetString("MAP_PROVIDER_GOOGLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 OpenStreetMap 的本地化字符串。
        /// </summary>
        public static string MAP_PROVIDER_OSM {
            get {
                return ResourceManager.GetString("MAP_PROVIDER_OSM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Max Hops 的本地化字符串。
        /// </summary>
        public static string MAX_HOPS {
            get {
                return ResourceManager.GetString("MAX_HOPS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Missing Component 的本地化字符串。
        /// </summary>
        public static string MISSING_COMP {
            get {
                return ResourceManager.GetString("MISSING_COMP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 OpenTrace requires privileges to perform TCP/UDP trace.
        ///Please set the permissions of NextTrace as follows:
        ///
        ///sudo xattr -r -d com.apple.quarantine /path/to/nexttrace
        ///sudo chown root:admin /path/to/nexttrace
        ///sudo chmod +sx /path/to/nexttrace 的本地化字符串。
        /// </summary>
        public static string MISSING_COMP_PRIV_MACOS {
            get {
                return ResourceManager.GetString("MISSING_COMP_PRIV_MACOS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 OpenTrace requires the NextTrace utility to function properly. This executable is currently missing.
        ///NextTrace can be placed in either:
        ///1. The same directory as the OpenTrace executable
        ///OR
        ///2. A directory included in your system&apos;s PATH environment variable
        ///
        ///Would you like to download the NextTrace utility now? 的本地化字符串。
        /// </summary>
        public static string MISSING_COMP_TEXT {
            get {
                return ResourceManager.GetString("MISSING_COMP_TEXT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 OpenTrace requires the NextTrace utility to function properly. This executable is currently missing.
        ///Please download NextTrace and set the permissions as follows:
        ///
        ///sudo xattr -r -d com.apple.quarantine /path/to/nexttrace
        ///sudo chown root:admin /path/to/nexttrace
        ///sudo chmod +sx /path/to/nexttrace
        ///
        ///And specify the path in the settings.
        ///
        ///Would you like to download the NextTrace utility now? 的本地化字符串。
        /// </summary>
        public static string MISSING_COMP_TEXT_MACOS {
            get {
                return ResourceManager.GetString("MISSING_COMP_TEXT_MACOS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 OpenTrace requires privileges to perform TCP/UDP trace 的本地化字符串。
        /// </summary>
        public static string MISSING_PRIV_MACOS {
            get {
                return ResourceManager.GetString("MISSING_PRIV_MACOS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 NextTrace could not be found in &quot;{0}&quot;. 的本地化字符串。
        /// </summary>
        public static string MISSING_SPECIFIED_COMP {
            get {
                return ResourceManager.GetString("MISSING_SPECIFIED_COMP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 MTR Mode 的本地化字符串。
        /// </summary>
        public static string MTR_MODE {
            get {
                return ResourceManager.GetString("MTR_MODE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Could not find host {0}. Please check the name and try again. 的本地化字符串。
        /// </summary>
        public static string NAME_NOT_RESOLVED {
            get {
                return ResourceManager.GetString("NAME_NOT_RESOLVED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 New 的本地化字符串。
        /// </summary>
        public static string NEW {
            get {
                return ResourceManager.GetString("NEW", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Create a new OpenTrace window. 的本地化字符串。
        /// </summary>
        public static string NEW_WINDOW_TEXT {
            get {
                return ResourceManager.GetString("NEW_WINDOW_TEXT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Proxy 的本地化字符串。
        /// </summary>
        public static string NEXTTRACE_PROXY {
            get {
                return ResourceManager.GetString("NEXTTRACE_PROXY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Organization 的本地化字符串。
        /// </summary>
        public static string ORGANIZATION {
            get {
                return ResourceManager.GetString("ORGANIZATION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Some data sources can only be selected after setting up an API endpoint/token.
        ///To use an offline database, please refer to the NextTrace documentation to set it up. 的本地化字符串。
        /// </summary>
        public static string OTHER_DATABASE_TIPS {
            get {
                return ResourceManager.GetString("OTHER_DATABASE_TIPS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Packet Group Interval 的本地化字符串。
        /// </summary>
        public static string PACKET_GROUP_INTERVAL {
            get {
                return ResourceManager.GetString("PACKET_GROUP_INTERVAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Packet Interval 的本地化字符串。
        /// </summary>
        public static string PACKET_INTERVAL {
            get {
                return ResourceManager.GetString("PACKET_INTERVAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Parallel Requests 的本地化字符串。
        /// </summary>
        public static string PARALLEL_REQ {
            get {
                return ResourceManager.GetString("PARALLEL_REQ", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 LeoMoeAPI PoW Provider 的本地化字符串。
        /// </summary>
        public static string POW_PROVIDER {
            get {
                return ResourceManager.GetString("POW_PROVIDER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 api.leo.moe (Default) 的本地化字符串。
        /// </summary>
        public static string POW_PROVIDER_LEOMOE {
            get {
                return ResourceManager.GetString("POW_PROVIDER_LEOMOE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Nya Labs (China Mainland Optimized) 的本地化字符串。
        /// </summary>
        public static string POW_PROVIDER_SAKURA {
            get {
                return ResourceManager.GetString("POW_PROVIDER_SAKURA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Preferences 的本地化字符串。
        /// </summary>
        public static string PREFERENCES {
            get {
                return ResourceManager.GetString("PREFERENCES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Private Address (LAN) 的本地化字符串。
        /// </summary>
        public static string PRIVATE_ADDR {
            get {
                return ResourceManager.GetString("PRIVATE_ADDR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Protocol for tracerouting 的本地化字符串。
        /// </summary>
        public static string PROTOCOL_FOR_TRACEROUTING {
            get {
                return ResourceManager.GetString("PROTOCOL_FOR_TRACEROUTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Queries (probes per each hop) 的本地化字符串。
        /// </summary>
        public static string QUERIES_SETTING {
            get {
                return ResourceManager.GetString("QUERIES_SETTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Quit 的本地化字符串。
        /// </summary>
        public static string QUIT {
            get {
                return ResourceManager.GetString("QUIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Reverse DNS Lookup Mode 的本地化字符串。
        /// </summary>
        public static string RDNS_MODE {
            get {
                return ResourceManager.GetString("RDNS_MODE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Attempt to Retrieve Full rDNS 的本地化字符串。
        /// </summary>
        public static string RDNS_MODE_ALWAYS {
            get {
                return ResourceManager.GetString("RDNS_MODE_ALWAYS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Fast rDNS (Default) 的本地化字符串。
        /// </summary>
        public static string RDNS_MODE_DEFAULT {
            get {
                return ResourceManager.GetString("RDNS_MODE_DEFAULT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Disable rDNS Query 的本地化字符串。
        /// </summary>
        public static string RDNS_MODE_DISABLE {
            get {
                return ResourceManager.GetString("RDNS_MODE_DISABLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Recv 的本地化字符串。
        /// </summary>
        public static string RECV {
            get {
                return ResourceManager.GetString("RECV", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Some settings will not be applied before the application is restarted 的本地化字符串。
        /// </summary>
        public static string RESTART_TO_APPLY {
            get {
                return ResourceManager.GetString("RESTART_TO_APPLY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Save 的本地化字符串。
        /// </summary>
        public static string SAVE {
            get {
                return ResourceManager.GetString("SAVE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Select an IP 的本地化字符串。
        /// </summary>
        public static string SELECT_IP_DROPDOWN {
            get {
                return ResourceManager.GetString("SELECT_IP_DROPDOWN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Please select an IP from the dropdown. 的本地化字符串。
        /// </summary>
        public static string SELECT_IP_MSGBOX {
            get {
                return ResourceManager.GetString("SELECT_IP_MSGBOX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Sent 的本地化字符串。
        /// </summary>
        public static string SENT {
            get {
                return ResourceManager.GetString("SENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Shared Address 的本地化字符串。
        /// </summary>
        public static string SHARED_ADDR {
            get {
                return ResourceManager.GetString("SHARED_ADDR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Source Address 的本地化字符串。
        /// </summary>
        public static string SRC_ADDR_SETTING {
            get {
                return ResourceManager.GetString("SRC_ADDR_SETTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Source Interface 的本地化字符串。
        /// </summary>
        public static string SRC_INTERFACE_SETTING {
            get {
                return ResourceManager.GetString("SRC_INTERFACE_SETTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Start 的本地化字符串。
        /// </summary>
        public static string START {
            get {
                return ResourceManager.GetString("START", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Std. Dev. 的本地化字符串。
        /// </summary>
        public static string STDEV {
            get {
                return ResourceManager.GetString("STDEV", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Stop 的本地化字符串。
        /// </summary>
        public static string STOP {
            get {
                return ResourceManager.GetString("STOP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 System DNS 的本地化字符串。
        /// </summary>
        public static string SYSTEM_DNS_RESOLVER {
            get {
                return ResourceManager.GetString("SYSTEM_DNS_RESOLVER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Time(ms) 的本地化字符串。
        /// </summary>
        public static string TIME_MS {
            get {
                return ResourceManager.GetString("TIME_MS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Round hop latency to whole number 的本地化字符串。
        /// </summary>
        public static string TIME_ROUNDING {
            get {
                return ResourceManager.GetString("TIME_ROUNDING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Tracerouting 的本地化字符串。
        /// </summary>
        public static string TRACEROUTING {
            get {
                return ResourceManager.GetString("TRACEROUTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 TCP/UDP Traceroute is not yet supported on Windows. 的本地化字符串。
        /// </summary>
        public static string WINDOWS_TCP_UDP_UNSUPPORTED {
            get {
                return ResourceManager.GetString("WINDOWS_TCP_UDP_UNSUPPORTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Worst 的本地化字符串。
        /// </summary>
        public static string WORST {
            get {
                return ResourceManager.GetString("WORST", resourceCulture);
            }
        }
    }
}
