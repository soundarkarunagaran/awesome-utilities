﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Properties {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Properties.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to The value must be between {0} and {1}..
        /// </summary>
        internal static string Validate_Between {
            get {
                return ResourceManager.GetString("Validate_Between", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be between {0} and {1} (inclusive)..
        /// </summary>
        internal static string Validate_BetweenInclusive {
            get {
                return ResourceManager.GetString("Validate_BetweenInclusive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be higher than {0}..
        /// </summary>
        internal static string Validate_HigherThan {
            get {
                return ResourceManager.GetString("Validate_HigherThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be higher than or equal to {0}..
        /// </summary>
        internal static string Validate_HigherThanOrEqualTo {
            get {
                return ResourceManager.GetString("Validate_HigherThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be lower than {0}..
        /// </summary>
        internal static string Validate_LowerThan {
            get {
                return ResourceManager.GetString("Validate_LowerThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be lower than or equal to {0}..
        /// </summary>
        internal static string Validate_LowerThanOrEqualTo {
            get {
                return ResourceManager.GetString("Validate_LowerThanOrEqualTo", resourceCulture);
            }
        }
    }
}
