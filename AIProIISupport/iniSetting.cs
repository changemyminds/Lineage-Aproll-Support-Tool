using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AprollSupport
{
    public class IniSetting
    {
        private static IniSetting iniSetting = null;

        private string filePath = "";
        private StringBuilder buffer = null;
        private uint bufferSize = 1024;

        [DllImport("kernel32.dll")]
        private static extern bool WritePrivateProfileString(string lpSectionName, string lpKeyName, string lpValue, string lpFilePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string lpSectionName, string lpKeyName, string lpDefault, 
                                                          StringBuilder lpBuffer, uint bufferSize, string lpFilePath);

        private IniSetting()
        {
            buffer = new StringBuilder(1024);
        }

        private static IniSetting getInstance()
        {
            if(iniSetting == null)
            {
                iniSetting = new IniSetting();
            }

            return iniSetting;
        }

        public static void setFilePath(string filePath)
        {
            getInstance().setFilePath_(filePath);
        }

        public void setFilePath_(string filePath)
        {
            this.filePath = filePath;
        }

        public static void writeValue<T>(string section, string key, T value)
        {
            getInstance().writeValue_(section, key, value);
        }

        private void writeValue_<T>(string section, string key, T value)
        {
            WritePrivateProfileString(section, key, value.ToString(), filePath);
        }

        public static void readValue<T>(string section, string key, ref T value)
        {
            getInstance().readValue_(section, key, ref value);
        }

        private void readValue_<T>(string section, string key, ref T value)
        {
            /* clean buffer */
            buffer.Length = 0;
            buffer.Capacity = 0;

            GetPrivateProfileString(section, key, "", buffer, bufferSize, filePath);

            Object temp = null;
            if (value is int)
                temp = buffer.ToString().Equals("") ? 0 : Int32.Parse(buffer.ToString());
            else if (value is string)
                temp = buffer.ToString();
            else if (value is bool)
                temp = buffer.ToString().Equals("") ? false : bool.Parse(buffer.ToString());
            else if (value is double)
                temp = buffer.ToString().Equals("") ? 0 : double.Parse(buffer.ToString());
            else if (value is float)
                temp = buffer.ToString().Equals("") ? 0 : float.Parse(buffer.ToString());
            else
                return;

            value = (T)Convert.ChangeType(temp, typeof(T));
        }

    }
}
