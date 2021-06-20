using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace passdec
{
    public partial class passdec : Form
    {
        string inifile_path = "";
 
        public passdec()
        {
            InitializeComponent();

            // iniファイルのパスをセット
            this.inifile_path = Application.StartupPath + "\\" + Application.ProductName + ".ini";

            // iniファイルからパラメータ取得

        }

        private void DecBtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(InputTxt.Text)) {
                DecEncTxt.Text = Decrypt(InputTxt.Text);
            }
        }

        private void EncBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(InputTxt.Text))
            {
                DecEncTxt.Text = Encrypt(InputTxt.Text);
            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(DecEncTxt.Text))
            {
                Clipboard.SetText(DecEncTxt.Text);
            }
        }

        private string Encrypt(string text)
        {
            // 初期化ベクトル
            StringBuilder init_vec = new StringBuilder(128);
            IniFile.GetPrivateProfileString("PASSDEC", "INIT_VEC", "default", init_vec, (uint)init_vec.Capacity, this.inifile_path);

            // 暗号鍵
            StringBuilder key = new StringBuilder(128);
            IniFile.GetPrivateProfileString("PASSDEC", "KEY", "default", key, (uint)key.Capacity, this.inifile_path);

            // AES
            AesManaged aes = new AesManaged();
            // 鍵の長さ
            aes.KeySize = 256;
            // ブロックサイズ(処理する文字単位)
            aes.BlockSize = 128;
            // 暗号モード
            aes.Mode = CipherMode.CBC;
            aes.IV = Encoding.UTF8.GetBytes(init_vec.ToString());
            aes.Key = Encoding.UTF8.GetBytes(key.ToString());
            // パディング
            aes.Padding = PaddingMode.PKCS7;

            // 暗号化するためにバイト配列に変換
            byte[] byteText = Encoding.UTF8.GetBytes(text);

            // 暗号化
            byte[] encryptText = aes.CreateEncryptor().TransformFinalBlock(byteText, 0, byteText.Length);

            // Base64形式(64種類の英数字で表現)で返す
            return Convert.ToBase64String(encryptText);
        }

        private string Decrypt(string text)
        {
            // 初期化ベクトル
            StringBuilder init_vec = new StringBuilder(128);
            IniFile.GetPrivateProfileString("PASSDEC", "INIT_VEC", "default", init_vec, (uint)init_vec.Capacity, this.inifile_path);

            // 暗号鍵
            StringBuilder key = new StringBuilder(128);
            IniFile.GetPrivateProfileString("PASSDEC", "KEY", "default", key, (uint)key.Capacity, this.inifile_path);

            // AES
            AesManaged aes = new AesManaged();
            // 鍵の長さ
            aes.KeySize = 256;
            // ブロックサイズ(処理する文字単位)
            aes.BlockSize = 128;
            // 暗号モード
            aes.Mode = CipherMode.CBC;
            aes.IV = Encoding.UTF8.GetBytes(init_vec.ToString());
            aes.Key = Encoding.UTF8.GetBytes(key.ToString());
            // パディング
            aes.Padding = PaddingMode.PKCS7;

            // バイト配列に変換
            byte[] byteText = Convert.FromBase64String(text);

            // 復号化
            byte[] decryptText = aes.CreateDecryptor().TransformFinalBlock(byteText, 0, byteText.Length);

            return Encoding.UTF8.GetString(decryptText);
        }


    }
}
