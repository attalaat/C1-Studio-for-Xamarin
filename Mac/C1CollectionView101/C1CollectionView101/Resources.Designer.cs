﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C1CollectionView101 {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("C1CollectionView101.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string gettingstarted {
            get {
                return ResourceManager.GetString("gettingstarted", resourceCulture);
            }
        }
        
        internal static string columndefinition {
            get {
                return ResourceManager.GetString("columndefinition", resourceCulture);
            }
        }
        
        internal static string filtering {
            get {
                return ResourceManager.GetString("filtering", resourceCulture);
            }
        }

        internal static string grouping {
            get
            {
                return ResourceManager.GetString("grouping", resourceCulture);
            }
        }

        internal static string ondemand {
            get
            {
                return ResourceManager.GetString("ondemand", resourceCulture);
            }
        }

        internal static string customcells {
            get
            {
                return ResourceManager.GetString("customcells", resourceCulture);
            }
        }
    }
}