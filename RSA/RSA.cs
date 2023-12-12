using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RSA
{
    public partial class RSA : Form
    {
        private int p, q, n, phi;
        
        public RSA()
        {
            InitializeComponent();
            p = InitialPrime();
            q = InitialPrime();
            while (!IsDistinct(p, q))
            {
                q = InitialPrime();
            }
            n = p * q;
            phi = (p - 1) * (q - 1);
        }

        private int GetPublicKey()
        {
            return new Random().Next(1, phi);
        }
        
        private string GetPrivateKey()
        {
            return null;
        }

        private static int InitialPrime()
        {
            var random = new Random();
            var num = random.Next(1, 100);
            
            while (!IsPrime(num))
            {
                num = random.Next(1, 100);
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

        private void btn_en_Click(object sender, EventArgs e)
        {
            var plainText = rtb_plain.Text;
            var data = Encoding.Unicode.GetBytes(plainText);
            tb_public.Text = GetPublicKey().ToString();
        }
    }
}
