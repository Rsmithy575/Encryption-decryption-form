using System;

using System.IO;

using System.Security.Cryptography;

using System.Text;

using System.Windows.Forms;



namespace PasswordEncryptionApp

{

    public partial class Form1 : Form

    {

        private string encryptedPassword = string.Empty;



        public Form1()

        {

            InitializeComponent();

        }



        // When the Encrypt button is clicked 

        private void buttonEncrypt_Click(object sender, EventArgs e)

        {

            string password = textBoxPassword.Text;

            string key = textBoxKey.Text;



            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(key))

            {

                MessageBox.Show("Please enter both a password and a key.");

                return;

            }



            encryptedPassword = EncryptPassword(password, key);

            MessageBox.Show($"Encrypted Password: {encryptedPassword}");

        }



        // AES encryption 

        private string EncryptPassword(string password, string key)

        {

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            byte[] keyBytes = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)); // Ensure 256-bit key 



            using (Aes aes = Aes.Create())

            {

                aes.Key = keyBytes;

                aes.Mode = CipherMode.CBC;

                aes.Padding = PaddingMode.PKCS7;

                aes.GenerateIV();



                using (ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV))

                {

                    byte[] encryptedBytes = encryptor.TransformFinalBlock(passwordBytes, 0, passwordBytes.Length);

                    byte[] combinedIvAndEncrypted = new byte[aes.IV.Length + encryptedBytes.Length];

                    Array.Copy(aes.IV, 0, combinedIvAndEncrypted, 0, aes.IV.Length);

                    Array.Copy(encryptedBytes, 0, combinedIvAndEncrypted, aes.IV.Length, encryptedBytes.Length);

                    return Convert.ToBase64String(combinedIvAndEncrypted);

                }

            }

        }



        // When the Decrypt button is clicked 

        private void buttonDecrypt_Click(object sender, EventArgs e)

        {

            string key = textBoxKey.Text;



            if (string.IsNullOrEmpty(encryptedPassword) || string.IsNullOrEmpty(key))

            {

                MessageBox.Show("Please encrypt the password and provide a key first.");

                return;

            }



            try

            {

                string decryptedPassword = DecryptPassword(encryptedPassword, key);

                MessageBox.Show($"Decrypted Password: {decryptedPassword}");

            }

            catch (Exception ex)

            {

                MessageBox.Show("Decryption failed. Ensure the correct key is used.");

            }

        }



        // AES decryption 

        private string DecryptPassword(string encryptedPassword, string key)

        {

            byte[] combinedIvAndEncrypted = Convert.FromBase64String(encryptedPassword);

            byte[] keyBytes = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32));



            using (Aes aes = Aes.Create())

            {

                aes.Key = keyBytes;

                aes.Mode = CipherMode.CBC;

                aes.Padding = PaddingMode.PKCS7;



                byte[] iv = new byte[aes.BlockSize / 8];

                byte[] encryptedBytes = new byte[combinedIvAndEncrypted.Length - iv.Length];



                Array.Copy(combinedIvAndEncrypted, 0, iv, 0, iv.Length);

                Array.Copy(combinedIvAndEncrypted, iv.Length, encryptedBytes, 0, encryptedBytes.Length);



                aes.IV = iv;



                using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))

                {

                    byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                    return Encoding.UTF8.GetString(decryptedBytes);

                }

            }

        }



        // Save the encrypted password to a text file 

        private void buttonSaveFile_Click(object sender, EventArgs e)

        {

            if (string.IsNullOrEmpty(encryptedPassword))

            {

                MessageBox.Show("Please encrypt the password first.");

                return;

            }



            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text File|*.txt";

            saveFileDialog.Title = "Save Encrypted Password";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)

            {

                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))

                {

                    writer.WriteLine($"Encrypted Password: {encryptedPassword}");

                }

                MessageBox.Show("File saved successfully!");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}