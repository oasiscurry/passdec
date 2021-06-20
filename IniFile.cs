using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace passdec
{
    class IniFile
    {
        // iniファイルの文字列を読み込む
        [DllImport("KERNEL32.DLL")]
        public static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, uint nSize, string lpFileName);

        // iniファイルの指定したセクション
        [DllImport("KERNEL32.DLL", EntryPoint = "GetPrivateProfileStringA")]
        public static extern uint GetPrivateProfileStringByByteArray(string lpAppName, string lpKeyName, string lpDefault, byte[] lpReturnedString, uint nSize, string lpFileName);

        // iniファイルの整数値を読み込む
        [DllImport("KERNEL32.DLL")]
        public static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);

        // iniファイルのキーを書き換える
        [DllImport("KERNEL32.DLL")]
        public static extern uint WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
    }
}
