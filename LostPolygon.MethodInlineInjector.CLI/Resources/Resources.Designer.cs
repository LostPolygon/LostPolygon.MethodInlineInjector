﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LostPolygon.MethodInlineInjector.Cli {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LostPolygon.MethodInlineInjector.Cli.Resources.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;xs:schema elementFormDefault=&quot;qualified&quot; attributeFormDefault=&quot;unqualified&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;Configuration&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:all&gt;
        ///        &lt;xs:element name=&quot;InjecteeAssemblies&quot;&gt;
        ///          &lt;xs:complexType&gt;
        ///            &lt;xs:choice maxOccurs=&quot;unbounded&quot;&gt;
        ///              &lt;xs:element name=&quot;InjecteeAssembly&quot; type=&quot;InjecteeAssembly&quot; /&gt;
        ///            &lt;/xs:choice&gt;
        ///          &lt;/xs:complexType&gt;
        ///        &lt;/xs:element&gt;
        ///        &lt;xs:element name=&quot;InjectedMethods&quot;&gt;
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string injectorConfigurationSchema {
            get {
                return ResourceManager.GetString("injectorConfigurationSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;log4net&gt;
        ///  &lt;appender name=&quot;ColoredConsoleAppender&quot; type=&quot;log4net.Appender.ManagedColoredConsoleAppender&quot;&gt;
        ///    &lt;mapping&gt;
        ///      &lt;level value=&quot;DEBUG&quot; /&gt;
        ///      &lt;forecolor value=&quot;Magenta&quot; /&gt;
        ///    &lt;/mapping&gt;
        ///    &lt;mapping&gt;
        ///      &lt;level value=&quot;INFO&quot; /&gt;
        ///      &lt;forecolor value=&quot;Cyan&quot; /&gt;
        ///    &lt;/mapping&gt;
        ///    &lt;mapping&gt;
        ///      &lt;level value=&quot;WARN&quot; /&gt;
        ///      &lt;forecolor value=&quot;Yellow&quot; /&gt;
        ///    &lt;/mapping&gt;
        ///    &lt;mapping&gt;
        ///      &lt;level value=&quot;ERROR&quot; /&gt;
        ///      &lt;forecolor value=&quot;D [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string log4netConfiguration {
            get {
                return ResourceManager.GetString("log4netConfiguration", resourceCulture);
            }
        }
    }
}
