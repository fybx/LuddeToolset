﻿/*
 *         LuddeToolset.Cryptography
 * 
 *         LuddeToolset by fybalaban @ 2020
 *         https://www.github.com/fybalaban
 *         https://www.instagram.com/ferityigitbalaban/
 *         https://www.twitter.com/fybalaban/
 *         https://fybalaban.github.io/website/
 */

using System;
using System.IO;
using System.Security.Cryptography;

namespace LuddeToolset.Cryptography
{
    /// <summary>
    /// Provides methods for full file and string encryption/decryption with AES algorithm. Encapsulates System.Security.Cryptography.AesCryptoServiceProvider. Native code is faster with big loads.
    /// </summary>
    public class AESNative : IDisposable
    {
        #region Properties
        /// <summary>
        /// Specifies the type of padding to apply when the message data block is shorter than the full number of bytes needed for a cryptographic operation. (From Microsoft)
        /// </summary>
        public PaddingMode PaddingMode { get; private set; }
        /// <summary>
        /// Specifies the block cipher mode to use for encryption. (From Microsoft)
        /// </summary>
        public CipherMode CipherMode { get; private set; }
        /// <summary>
        /// The key for the symmetric algorithm. (From Microsoft)
        /// </summary>
        public byte[] Key { get; private set; }
        /// <summary>
        /// The size, in bits, of the key used by the symmetric algorithm. (From Microsoft)
        /// </summary>
        public int KeySize { get; private set; }
        /// <summary>
        /// The initialization vector to use for the symmetric algorithm. (From Microsoft)
        /// </summary>
        public byte[] IV { get; private set; }
        #endregion

        #region Fields
        private AesCryptoServiceProvider InnerAes;
        #endregion

        #region Object Creation
        /// <summary>
        /// Initializes AESNative with default parameters.
        /// </summary>
        public AESNative()
        {
            PaddingMode = PaddingMode.PKCS7;
            CipherMode = CipherMode.CBC;
            KeySize = 256;
            Key = AESResourceSupplier.GetKey(256);
            IV = AESResourceSupplier.GetIV();
            InnerAes = new AesCryptoServiceProvider()
            {
                Padding = PaddingMode,
                Mode = CipherMode,
                KeySize = KeySize,
                Key = Key,
                IV = IV
            };
        }

        /// <summary>
        /// Initializes AESNative with a Key.
        /// </summary>
        /// <param name="keySize">Size of key, must a be valid AES key size</param>
        /// <param name="key">The key</param>
        public AESNative(int keySize, byte[] key)
        {
            if (!AESResourceSupplier.IsValidKeySize(keySize))
            {
                throw new ArgumentException("Argument: 'keySize' is not a valid size for AES algorithm.");
            }
            if (key == null || key.Length == 0)
            {
                throw new ArgumentNullException(nameof(key));
            }
            PaddingMode = PaddingMode.PKCS7;
            CipherMode = CipherMode.CBC;
            KeySize = keySize;
            Key = key;
            IV = AESResourceSupplier.GetIV();
            InnerAes = new AesCryptoServiceProvider()
            {
                Padding = PaddingMode,
                Mode = CipherMode,
                KeySize = KeySize,
                Key = Key,
                IV = IV
            };
        }

        /// <summary>
        /// Initializes AESNative with a Key and an Initialization Vector.
        /// </summary>
        /// <param name="keySize">Size of key, must a be valid AES key size</param>
        /// <param name="key">The key</param>
        /// <param name="iv">The Initialization Vector</param>
        public AESNative(int keySize, byte[] key, byte[] iv)
        {
            if (!AESResourceSupplier.IsValidKeySize(keySize))
            {
                throw new ArgumentException("Argument: 'keySize' is not a valid size for AES algorithm.");
            }
            if (key == null || key.Length == 0)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (iv == null || iv.Length == 0)
            {
                throw new ArgumentNullException(nameof(iv));
            }
            PaddingMode = PaddingMode.PKCS7;
            CipherMode = CipherMode.CBC;
            KeySize = keySize;
            Key = key;
            IV = iv;
            InnerAes = new AesCryptoServiceProvider()
            {
                Padding = PaddingMode,
                Mode = CipherMode,
                KeySize = KeySize,
                Key = Key,
                IV = IV
            };
        }

        /// <summary>
        /// Initializes AESNative using a KeyStore object.
        /// </summary>
        /// <param name="keystore"></param>
        public AESNative(KeyStore keystore)
        {
            if (!AESResourceSupplier.IsValidKeySize(keystore.KeySize))
            {
                throw new ArgumentException("Argument: 'keySize' is not a valid size for AES algorithm.");
            }
            if (keystore.Key == null || keystore.Key.Length == 0)
            {
                throw new ArgumentNullException(nameof(keystore.Key));
            }
            if (keystore.IV == null || keystore.IV.Length == 0)
            {
                throw new ArgumentNullException(nameof(keystore.IV));
            }
            PaddingMode = PaddingMode.PKCS7;
            CipherMode = CipherMode.CBC;
            KeySize = keystore.KeySize;
            Key = keystore.Key;
            IV = keystore.IV;
            InnerAes = new AesCryptoServiceProvider()
            {
                Padding = PaddingMode,
                Mode = CipherMode,
                KeySize = KeySize,
                Key = Key,
                IV = IV
            };
        }

        /// <summary>
        /// Initializes AESNative with a Key, an Initialization Vector and a padding mode.
        /// </summary>
        /// <param name="keySize">Size of key, must a be valid AES key size</param>
        /// <param name="key">The key</param>
        /// <param name="iv">The Initialization Vector</param>
        /// <param name="paddingMode">The padding mode</param>
        public AESNative(int keySize, byte[] key, byte[] iv, PaddingMode paddingMode)
        {
            if (!AESResourceSupplier.IsValidKeySize(keySize))
            {
                throw new ArgumentException("Argument: 'keySize' is not a valid size for AES algorithm.");
            }
            if (key == null || key.Length == 0)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (iv == null || iv.Length == 0)
            {
                throw new ArgumentNullException(nameof(iv));
            }
            PaddingMode = paddingMode;
            CipherMode = CipherMode.CBC;
            KeySize = keySize;
            Key = key;
            IV = iv;
            InnerAes = new AesCryptoServiceProvider()
            {
                Padding = PaddingMode,
                Mode = CipherMode,
                KeySize = KeySize,
                Key = Key,
                IV = IV
            };
        }

        /// <summary>
        /// Initializes AESNative with a Key, an Initialization Vector and a cipher mode.
        /// </summary>
        /// <param name="keySize">Size of key, must a be valid AES key size</param>
        /// <param name="key">The key</param>
        /// <param name="iv">The Initialization Vector</param>
        /// <param name="cipherMode">The cipher mode</param>
        public AESNative(int keySize, byte[] key, byte[] iv, CipherMode cipherMode)
        {
            if (!AESResourceSupplier.IsValidKeySize(keySize))
            {
                throw new ArgumentException("Argument: 'keySize' is not a valid size for AES algorithm.");
            }
            if (key == null || key.Length == 0)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (iv == null || iv.Length == 0)
            {
                throw new ArgumentNullException(nameof(iv));
            }
            PaddingMode = PaddingMode.PKCS7;
            CipherMode = cipherMode;
            KeySize = keySize;
            Key = key;
            IV = iv;
            InnerAes = new AesCryptoServiceProvider()
            {
                Padding = PaddingMode,
                Mode = CipherMode,
                KeySize = KeySize,
                Key = Key,
                IV = IV
            };
        }

        /// <summary>
        /// Initializes AESNative with a Key, an Initialization Vector, a padding mode and cipher mode.
        /// </summary>
        /// <param name="keySize">Size of key, must a be valid AES key size</param>
        /// <param name="key">The key</param>
        /// <param name="iv">The Initialization Vector</param>
        /// <param name="paddingMode">The padding mode</param>
        /// <param name="cipherMode">The cipher mode</param>
        public AESNative(int keySize, byte[] key, byte[] iv, PaddingMode paddingMode, CipherMode cipherMode)
        {
            if (!AESResourceSupplier.IsValidKeySize(keySize))
            {
                throw new ArgumentException("Argument: 'keySize' is not a valid size for AES algorithm.");
            }
            if (key == null || key.Length == 0)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (iv == null || iv.Length == 0)
            {
                throw new ArgumentNullException(nameof(iv));
            }
            PaddingMode = paddingMode;
            CipherMode = cipherMode;
            KeySize = keySize;
            Key = key;
            IV = iv;
            InnerAes = new AesCryptoServiceProvider()
            {
                Padding = PaddingMode,
                Mode = CipherMode,
                KeySize = KeySize,
                Key = Key,
                IV = IV
            };
        }
        #endregion

        #region Methods
        /// <summary>
        /// Encrypts supplied string and returns encrypted output in byte array.
        /// </summary>
        /// <param name="plainText">Text to encrypt</param>
        /// <returns></returns>
        public byte[] EncryptStringToBytes(string plainText)
        {
            if (!plainText.Valid()) // Do validity check
            {
                throw new ArgumentNullException("plainText");
            }

            byte[] encrypted;
            ICryptoTransform encryptor = InnerAes.CreateEncryptor(InnerAes.Key, InnerAes.IV); // Create an encryptor to perform the stream transform.

            using (MemoryStream msEncrypt = new MemoryStream()) // Create the streams used for encryption.
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText); // Write all data to the stream.
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
            return encrypted; // Return the encrypted bytes from the memory stream.
        }

        /// <summary>
        /// Decrypts cipherText byte array to plain text.
        /// </summary>
        /// <param name="cipherText">Byte[] to decrypt</param>
        /// <returns></returns>
        public string DecryptStringFromBytes(byte[] cipherText)
        {
            if (cipherText == null || cipherText.Length <= 0) // Do null check.
            {
                throw new ArgumentNullException("cipherText");
            }
            string plaintext = string.Empty; // Declare the string used to hold the decrypted text.
            ICryptoTransform decryptor = InnerAes.CreateDecryptor(InnerAes.Key, InnerAes.IV); // Create a decryptor to perform the stream transform.
            using (MemoryStream msDecrypt = new MemoryStream(cipherText)) // Create the streams used for decryption.
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        plaintext = srDecrypt.ReadToEnd(); // Read the decrypted bytes from the decrypting stream and place them in a string.
                    }
                }
            }
            return plaintext;
        }

        /// <summary>
        /// Encrypts supplied text and writes encrypted bytes to a file at supplied filePath.
        /// </summary>
        /// <param name="fileContents">Text to encrypt</param>
        /// <param name="filePath">Path to file.</param>
        /// <returns></returns>
        public void EncryptFile(string fileContents, string filePath)
        {
            // Check the arguments.
            if (!fileContents.Valid())
            {
                throw new ArgumentNullException("fileContents");
            }
            if (!filePath.Valid())
            {
                throw new ArgumentNullException("filePath");
            }
            byte[] file = this.EncryptStringToBytes(fileContents);
            IO.WriteBytesToFile(file, filePath);
        }

        /// <summary>
        /// Reads from supplied file, decrypts file contents, outputs via decryptedFileContents.
        /// </summary>
        /// <param name="decryptedFileContents">Output</param>
        /// <param name="filePath">Path to file.</param>
        public void DecryptFile(out string decryptedFileContents, string filePath)
        {
            // Check the arguments.
            if (!filePath.Valid())
            {
                throw new ArgumentNullException("filePath");
            }

            decryptedFileContents = null;
            if (IO.ReadBytesFromFile(filePath, out byte[] encryptedFileContents)) // Read all bytes from file.
            {
                decryptedFileContents = this.DecryptStringFromBytes(encryptedFileContents); // Decrypt bytes to string.
            }
        }

        /// <summary>
        /// Encrypts given file and outputs to given path. Return true if encryption was successful.
        /// </summary>
        /// <param name="fileToEncrypt">Path of file to encrypt</param>
        /// <param name="outputFile">Path to output</param>
        /// <returns></returns>
        public bool Encrypt(string fileToEncrypt, string outputFile)
        {
            // Check the arguments.
            if (!fileToEncrypt.Valid())
            {
                throw new ArgumentNullException("fileToEncrypt");
            }
            if (!File.Exists(fileToEncrypt))
            {
                throw new FileNotFoundException($"'{fileToEncrypt}' is not a valid file.", fileToEncrypt);
            }
            if (!outputFile.Valid())
            {
                throw new ArgumentNullException("outputFile");
            }
            try
            {
                IO.WriteBytesToFile(this.EncryptStringToBytes(File.ReadAllText(fileToEncrypt)), outputFile);
                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion

        #region IDisposable Implementation
        private bool disposedValue = false; // To detect redundant calls

        /// <summary>
        /// Dispose and free any resource used by this class.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Key = null;
                    IV = null;
                }
                InnerAes.Dispose();

                disposedValue = true;
            }
        }

        /// <summary>
        /// Dispose and free any resource used by this class.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }
        #endregion
    }
}