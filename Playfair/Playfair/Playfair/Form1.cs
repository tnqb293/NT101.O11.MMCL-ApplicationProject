using System.Text;

namespace Playfair
{
    public partial class Form1 : Form
    {
        private char[,] keyMatrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeUI();
        }
        private void InitializeUI()
        {
            btnGenerateKey.Click += btnGenerateKey_Click;
            btnEncrypt.Click += btnEncrypt_Click;
            btnDecrypt.Click += btnDecrypt_Click;
            btnSwitch.Click += btnSwitch_Click;

            GenerateKeyMatrix();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            GenerateKeyMatrix();

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text.ToUpper();
            string encryptedText = PlayfairEncrypt(inputText);
            txtOutput.Text = encryptedText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text.ToUpper();
            string decryptedText = PlayfairDecrypt(inputText);
            txtOutput.Text = decryptedText;
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string temp = txtInput.Text;
            txtInput.Text = txtOutput.Text;
            txtOutput.Text = temp;
        }
        private void GenerateKeyMatrix()
        {
            char[] alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ".ToCharArray();
            keyMatrix = new char[5, 5];

            Random random = new Random();
            var shuffledAlphabet = alphabet.OrderBy(x => random.Next()).ToArray();

            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    keyMatrix[i, j] = shuffledAlphabet[index];
                    index++;
                }
            }

            DisplayKeyMatrix();
        }

        private void DisplayKeyMatrix()
        {
            StringBuilder matrixText = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrixText.Append(keyMatrix[i, j] + " ");
                }
                matrixText.AppendLine();
            }

            txtKeyMatrix.Text = matrixText.ToString();
        }

        private string PlayfairEncrypt(string input)
        {
            StringBuilder encryptedText = new StringBuilder();
            input = input.Replace("J", "I");

            for (int k = 0; k < input.Length; k += 2)
            {
                char char1 = input[k];
                char char2 = (k + 1 < input.Length) ? input[k + 1] : 'X';

                Tuple<int, int> pos1 = FindPosition(char1);
                Tuple<int, int> pos2 = FindPosition(char2);

                if (pos1.Item1 == pos2.Item1)
                {
                    encryptedText.Append(keyMatrix[pos1.Item1, (pos1.Item2 + 1) % 5]);
                    encryptedText.Append(keyMatrix[pos2.Item1, (pos2.Item2 + 1) % 5]);
                }
                else if (pos1.Item2 == pos2.Item2)
                {
                    encryptedText.Append(keyMatrix[(pos1.Item1 + 1) % 5, pos1.Item2]);
                    encryptedText.Append(keyMatrix[(pos2.Item1 + 1) % 5, pos2.Item2]);
                }
                else
                {
                    encryptedText.Append(keyMatrix[pos1.Item1, pos2.Item2]);
                    encryptedText.Append(keyMatrix[pos2.Item1, pos1.Item2]);
                }
            }

            return encryptedText.ToString();
        }

        private string PlayfairDecrypt(string input)
        {
            StringBuilder decryptedText = new StringBuilder();

            for (int k = 0; k < input.Length; k += 2)
            {
                char char1 = input[k];
                char char2 = (k + 1 < input.Length) ? input[k + 1] : 'X';

                Tuple<int, int> pos1 = FindPosition(char1);
                Tuple<int, int> pos2 = FindPosition(char2);

                if (pos1.Item1 == pos2.Item1)
                {
                    decryptedText.Append(keyMatrix[pos1.Item1, (pos1.Item2 - 1 + 5) % 5]);
                    decryptedText.Append(keyMatrix[pos2.Item1, (pos2.Item2 - 1 + 5) % 5]);
                }
                else if (pos1.Item2 == pos2.Item2)
                {
                    decryptedText.Append(keyMatrix[(pos1.Item1 - 1 + 5) % 5, pos1.Item2]);
                    decryptedText.Append(keyMatrix[(pos2.Item1 - 1 + 5) % 5, pos2.Item2]);
                }
                else
                {
                    decryptedText.Append(keyMatrix[pos1.Item1, pos2.Item2]);
                    decryptedText.Append(keyMatrix[pos2.Item1, pos1.Item2]);
                }
            }

            return decryptedText.ToString();
        }

        private Tuple<int, int> FindPosition(char target)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (keyMatrix[i, j] == target)
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }
            return Tuple.Create(-1, -1);
        }
    }
}