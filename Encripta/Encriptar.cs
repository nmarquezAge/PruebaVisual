using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encripta
{
    public partial class Encriptar : Form
    {
        #region Constante Key - Encriptar Decriptar
        public const string Key_Encrypt_Decrypt = "web_novo_agesoft";
        #endregion

        #region Variables
        private string GStrError = "";
        #endregion

        #region Metodos
        /// <summary>
        /// Error message
        /// </summary>
        public string ErrorMessage
        {
            get
            {
                return this.GStrError;
            }
        }
        public Encriptar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string key= Encrypt(Key_Encrypt_Decrypt,textContraseña.Text);
            textResultado.Text = key;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key= Decrypt(Key_Encrypt_Decrypt, textContraseña.Text);

            textResultado.Text = key;
        }

        public string Encrypt(string Key, string StringToEncrypt)
        {
            string strCadena;
            string encrypted;
            string password;
            byte[] pwdhash, buff;
            password = Key;
            try
            {
                strCadena = StringToEncrypt;
                using (MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider())
                {
                    pwdhash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
                    using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
                    {
                        des.Key = pwdhash;
                        des.Mode = CipherMode.ECB; //CBC, CFB
                        buff = ASCIIEncoding.ASCII.GetBytes(strCadena);
                        encrypted = Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buff, 0, buff.Length));
                    }
                }
            }
            catch (CryptographicException ce)
            {
                this.GStrError = "[Encrypt]: No puede Encryptar err." + ce.Message;
                encrypted = "";
            }
            catch (Exception e)
            {
                this.GStrError = "[Encrypt]: No se puede Ecortr." + e.Message;
                encrypted = "";
            }
            return encrypted;
        }

        public string Decrypt(string Key, string StringToDecrypt)
        {
            string decrypted;
            string password;
            byte[] pwdhash, buff;
            password = Key;
            try
            {
                using (MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider())
                {
                    pwdhash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
                    using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
                    {
                        des.Key = pwdhash;
                        des.Mode = CipherMode.ECB; //CBC, CFB
                        buff = Convert.FromBase64String(StringToDecrypt);
                        decrypted = ASCIIEncoding.ASCII.GetString(des.CreateDecryptor().TransformFinalBlock(buff, 0, buff.Length));
                    }
                }
            }
            catch (CryptographicException ce)
            {
                this.GStrError = "[Decrypt]: No se puede Desencryptar." + ce.Message;
                decrypted = "";
            }
            catch (Exception e)
            {
                this.GStrError = "[Decrypt]: No se puede Desencryptar." + e.Message;
                decrypted = "";
            }
            return decrypted;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            textContraseña.Text = "";
        }
    }
}
#endregion