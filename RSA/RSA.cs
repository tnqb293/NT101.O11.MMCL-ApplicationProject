using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RSA
{
    public partial class RSA : Form
    {
        private int p, q, n, phi, ePublic, dPrivate;
        private const string CharacterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        
        public RSA()
        {
            InitializeComponent();
            InitialNum();
            ShowInfo();
        }

        private void InitialNum()
        {
            p = InitialPrime();
            q = InitialPrime();
            while (!IsDistinct(p, q))
            {
                q = InitialPrime();
            }
            n = p * q;
            phi = Lcm(p - 1,q - 1);
            ePublic = GetPublicKey();
            dPrivate = GetPrivateKey();
        }

        private void ShowInfo()
        {
            pNum.Text = p.ToString();
            qNum.Text = q.ToString();
            nNum.Text = n.ToString();
            phiNum.Text = phi.ToString();
            tb_public.Text = ePublic.ToString();
            tb_private.Text = dPrivate.ToString();
        }

        private int GetPublicKey()
        {
            return new Random().Next(2, phi);
        }
        
        private int GetPrivateKey()
        {
            return 0;
        }

        private static int InitialPrime()
        {
            var random = new Random();
            var num = random.Next(2, 30);
            
            while (!IsPrime(num))
            {
                num = random.Next(2, 30);
            }

            return num;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
          
            for (var i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
    
            return true;        
        }

        private static bool IsDistinct(int num1, int num2)
        {
            return num1 != num2;
        }
        
        static int Gcf(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int Lcm(int a, int b)
        {
            return (a / Gcf(a, b)) * b;
        }

        private static string Encrypt(byte[] data, int e, int n)
        {
            var base64String = Convert.ToBase64String(data);
            var base64CharArray = base64String.ToCharArray();
            var cipherCharArray = new char[base64CharArray.Length];

            try
            {
                for (var i = 0; i < base64CharArray.Length; i++)
                {
                    var index = CharacterSet.IndexOf(base64CharArray[i]);
                    var converted = (Math.Pow(index, e) % n) % CharacterSet.Length;
                    cipherCharArray[i] = CharacterSet[Math.Abs(Convert.ToInt32(converted))];
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            
            return new string(cipherCharArray);
        }
        
        private static string Decrypt(byte[] data, int d, int n)
        {
            return "foo";
        }
        
        private void btn_en_Click(object sender, EventArgs e)
        {
            var plainText = rtb_plain.Text;
            
            if (plainText == "")
            {
                MessageBox.Show("Not null");
            }
            
            var data = Encoding.Unicode.GetBytes(plainText);
            ePublic = Convert.ToInt32(tb_public.Text) ;
            rtb_cipher.Text = Encrypt(data, ePublic, n);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            InitialNum();
            ShowInfo();
        }

        private void btn_de_Click(object sender, EventArgs e)
        {
            var cipherText = rtb_plain.Text;

            if (cipherText == "")
            {
                MessageBox.Show("Not null");
            }
            
            var data = Encoding.Unicode.GetBytes(cipherText);
            dPrivate = Convert.ToInt32(tb_private.Text);
            rtb_cipher.Text = Decrypt(data, dPrivate, n);
        }
    }
}
