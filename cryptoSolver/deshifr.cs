using System;
using System.Text;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Generators;

namespace cryptoSolver
{
    class My_crypto
    {
        AesCryptoServiceProvider crypto_provider;
        RsaKeyParameters PublicKey;
        byte[] signature;

        public My_crypto()
        {
            crypto_provider = new AesCryptoServiceProvider();
            crypto_provider.BlockSize = 128;
            crypto_provider.KeySize = 256;
            crypto_provider.GenerateIV();
            crypto_provider.GenerateKey();
            crypto_provider.Mode = CipherMode.CBC;
            crypto_provider.Padding = PaddingMode.PKCS7;      
        }

        public String encrypt(String clear_text)
        {
            ICryptoTransform transform = crypto_provider.CreateEncryptor();
            byte[] encrypted_bytes = transform.TransformFinalBlock(UnicodeEncoding.Default.GetBytes(clear_text), 0, clear_text.Length);
            string str = Convert.ToBase64String(encrypted_bytes);
            return str;
        }

        public String decrypt(String chiper_text)
        {
            try
            {
                ICryptoTransform transform = crypto_provider.CreateDecryptor();
                byte[] enc_bytes = Convert.FromBase64String(chiper_text);
                byte[] decrypted_bytes = transform.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);
                string str = UnicodeEncoding.Default.GetString(decrypted_bytes);
                return str;
            }
            catch (FormatException)
            {
                return "";
            }
        }

        public void gen_sign(String SourceData)
        {
            byte[] tmpSource = UnicodeEncoding.Default.GetBytes(SourceData);
            RsaKeyPairGenerator rsaKeyPairGen = new RsaKeyPairGenerator();
            rsaKeyPairGen.Init(new KeyGenerationParameters(new SecureRandom(), 2048));
            AsymmetricCipherKeyPair keyPair = rsaKeyPairGen.GenerateKeyPair();

            RsaKeyParameters PrivateKey = (RsaKeyParameters)keyPair.Private;
            this.PublicKey = (RsaKeyParameters)keyPair.Public;

            ISigner sign = SignerUtilities.GetSigner(PkcsObjectIdentifiers.Sha1WithRsaEncryption.Id);
            sign.Init(true, PrivateKey);
            sign.BlockUpdate(tmpSource, 0, tmpSource.Length);
            this.signature = sign.GenerateSignature();
        }

        public bool ver_sign(String SourceData)
        {
            byte[] tmpSource = UnicodeEncoding.Default.GetBytes(SourceData);
            ISigner sign1 = SignerUtilities.GetSigner(PkcsObjectIdentifiers.Sha1WithRsaEncryption.Id);
            sign1.Init(false, this.PublicKey);
            sign1.BlockUpdate(tmpSource, 0, tmpSource.Length);
            bool status = sign1.VerifySignature(this.signature);
            return status;
        }

        //public string ByteArrayToString(byte[] arrInput)
        //{
        //    int i;
        //    StringBuilder sOutput = new StringBuilder(arrInput.Length);
        //    for (i = 0; i < arrInput.Length; i++)
        //    {
        //        sOutput.Append(arrInput[i].ToString("X").ToLower());
        //    }
        //    return sOutput.ToString();
        //}
    }

}
