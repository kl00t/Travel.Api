﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travel.Api.Connector {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Example {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Example() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Travel.Api.Connector.Example", typeof(Example).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to {
        ///   &quot;destination_addresses&quot; : [],
        ///   &quot;error_message&quot; : &quot;The provided API key is invalid.&quot;,
        ///   &quot;origin_addresses&quot; : [],
        ///   &quot;rows&quot; : [],
        ///   &quot;status&quot; : &quot;REQUEST_DENIED&quot;
        ///}.
        /// </summary>
        public static string InvalidApiKey {
            get {
                return ResourceManager.GetString("InvalidApiKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///   &quot;destination_addresses&quot; : [ &quot;San Francisco, Californie, États-Unis&quot;, &quot;Victoria, BC, Canada&quot; ],
        ///   &quot;origin_addresses&quot; : [ &quot;Vancouver, BC, Canada&quot;, &quot;Seattle, Washington, États-Unis&quot; ],
        ///   &quot;rows&quot; : [
        ///      {
        ///         &quot;elements&quot; : [
        ///            {
        ///               &quot;distance&quot; : {
        ///                  &quot;text&quot; : &quot;1 706 km&quot;,
        ///                  &quot;value&quot; : 1706221
        ///               },
        ///               &quot;duration&quot; : {
        ///                  &quot;text&quot; : &quot;3 jours 19 heures&quot;,
        ///                  &quot;value&quot; : 327209
        ///               [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Test1 {
            get {
                return ResourceManager.GetString("Test1", resourceCulture);
            }
        }
    }
}
