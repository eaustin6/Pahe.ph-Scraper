﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaheScrapper.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Configuration : global::System.Configuration.ApplicationSettingsBase {
        
        private static Configuration defaultInstance = ((Configuration)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Configuration())));
        
        public static Configuration Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("manager_dump.json")]
        public string OutputJsonFilename {
            get {
                return ((string)(this["OutputJsonFilename"]));
            }
            set {
                this["OutputJsonFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int WebDriveRetryLimit {
            get {
                return ((int)(this["WebDriveRetryLimit"]));
            }
            set {
                this["WebDriveRetryLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int WebDriveTaskTimeout {
            get {
                return ((int)(this["WebDriveTaskTimeout"]));
            }
            set {
                this["WebDriveTaskTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool WebDriveHeadless {
            get {
                return ((bool)(this["WebDriveHeadless"]));
            }
            set {
                this["WebDriveHeadless"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int WebDriveInstances {
            get {
                return ((int)(this["WebDriveInstances"]));
            }
            set {
                this["WebDriveInstances"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int HTMLSaveStateThershold {
            get {
                return ((int)(this["HTMLSaveStateThershold"]));
            }
            set {
                this["HTMLSaveStateThershold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int WebDriveSaveStateThershold {
            get {
                return ((int)(this["WebDriveSaveStateThershold"]));
            }
            set {
                this["WebDriveSaveStateThershold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool WebDriveRestartOnError {
            get {
                return ((bool)(this["WebDriveRestartOnError"]));
            }
            set {
                this["WebDriveRestartOnError"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int HtmlRetryLimit {
            get {
                return ((int)(this["HtmlRetryLimit"]));
            }
            set {
                this["HtmlRetryLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int WebDriveRetryMaxLimit {
            get {
                return ((int)(this["WebDriveRetryMaxLimit"]));
            }
            set {
                this["WebDriveRetryMaxLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int HtmlRetryMaxLimit {
            get {
                return ((int)(this["HtmlRetryMaxLimit"]));
            }
            set {
                this["HtmlRetryMaxLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int FailsafeThershold {
            get {
                return ((int)(this["FailsafeThershold"]));
            }
            set {
                this["FailsafeThershold"] = value;
            }
        }
    }
}