using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;


namespace MetroHandCarWash.Common
{
    public class EncryptionHandler
    {
        #region Attributes
        const string password = "";
        const string saltValue = "";
        RijndaelManaged cryptoManager;
        #endregion Attributes

        #region Public Functions and Methods
        /// <summary>
        /// Encrypt a given string
        /// </summary>
        /// <remarks>
        /// Author: Phillip
        /// </remarks>
        /// <param name="dataToEncrypt">String for encryption</param>
        /// <returns>String with the result of the encryption</returns>
        public string EncryptData(string dataToEncrypt)
        {
            byte[] dataEncripted;
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(dataToEncrypt);
                ICryptoTransform encryptor = null;
                using (PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, Encoding.UTF8.GetBytes(saltValue)))
                {
                    cryptoManager.Padding = PaddingMode.ISO10126;
                    encryptor = cryptoManager.CreateEncryptor(pdb.GetBytes(32), pdb.GetBytes(16));
                }

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream encStream = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        encStream.Write(data, 0, data.Length);
                        encStream.FlushFinalBlock();
                        //Convert.ToBase64String(msEncrypt.ToArray());
                        dataEncripted = msEncrypt.ToArray();
                    }
                }
                return Convert.ToBase64String(dataEncripted);
            }
            finally
            {
                if (cryptoManager != null)
                    cryptoManager.Clear();
            }
        }

        /// <summary>
        /// Desencrypt a given string
        /// </summary>
        /// <remarks>
        /// Author: Phillip
        /// </remarks>
        /// <param name="textEncrypted">String for desencryption</param>
        /// <returns>String with the result of the desencryption</returns>
        public string DesEncryptData(string textEncrypted)
        {
            string plaintext = null;

            try
            {
                ICryptoTransform decryptor = null;
                using (PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, Encoding.UTF8.GetBytes(saltValue)))
                {
                    cryptoManager.Padding = PaddingMode.ISO10126;
                    decryptor = cryptoManager.CreateDecryptor(pdb.GetBytes(32), pdb.GetBytes(16));
                }
                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(textEncrypted)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
                return plaintext;
            }
            finally
            {
                if (cryptoManager != null)
                    cryptoManager.Clear();
            }
        }
        #endregion

        #region IDisposable Members
        /// <summary>
        ///Override of the Disposable Method.
        /// </summary>
        /// <remarks>
        /// Author: Phillip
        /// </remarks>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///Implementation of the Disposable Method.
        /// </summary>
        /// <remarks>
        /// Author: Phillip
        /// </remarks>
        /// <param name="disposing">Boolean for clear the cryptography object</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (cryptoManager != null)
                {
                    cryptoManager.Clear();
                    cryptoManager = null;
                }
            }
        }
        #endregion


    }
}
