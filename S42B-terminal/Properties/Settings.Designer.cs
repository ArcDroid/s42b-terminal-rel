﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S42B_terminal.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SerialPortDriver {
            get {
                return ((string)(this["SerialPortDriver"]));
            }
            set {
                this["SerialPortDriver"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SerialPortMarlin {
            get {
                return ((string)(this["SerialPortMarlin"]));
            }
            set {
                this["SerialPortMarlin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250000")]
        public int SerialBaudDriver {
            get {
                return ((int)(this["SerialBaudDriver"]));
            }
            set {
                this["SerialBaudDriver"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250000")]
        public int SerialBaudMarlin {
            get {
                return ((int)(this["SerialBaudMarlin"]));
            }
            set {
                this["SerialBaudMarlin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public ushort PidDiviser {
            get {
                return ((ushort)(this["PidDiviser"]));
            }
            set {
                this["PidDiviser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("G28 O1 ; home if not homed\r\nM201 X36000.00 Y36000.00 ; max acceleration\r\nM203 X36" +
            "0000.00 Y360000.00 ; max feed\r\nM204 P36000.00 R36000.00 T36000.00 ; printing acc" +
            "el\r\nG0 X-100Y10 F100000 ; prep move\r\nG4 P100 ; dwell")]
        public string GcodePrep {
            get {
                return ((string)(this["GcodePrep"]));
            }
            set {
                this["GcodePrep"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("G0 X100 ; move\r\nG4 P100 ; dwell\r\nG0 X-100 ; move\r\nG4 P100 ; dwell")]
        public string GcodeTest {
            get {
                return ((string)(this["GcodeTest"]));
            }
            set {
                this["GcodeTest"] = value;
            }
        }
    }
}
