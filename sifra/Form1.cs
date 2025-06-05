using System.Globalization;
using System.Text;

namespace sifra
{
    public partial class Form1 : Form
    {

        /*
        !!!!!POZN�MKA NA ZA��TEK!!!!!
        !!!!!MODULO JE 36 KV�LI P�ID�N� 0-9 DO ARRAYE S ABECEDOU!!!!!
        */

        public Form1()
        {
            InitializeComponent();
            Pozadi.SendToBack();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            char[] Abeceda = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            string inputText = EncryptText.Text.ToUpper();

            inputText = RemoveDiacritics(inputText);

            if (int.TryParse(ABox.Text, out int A) && int.TryParse(Bbox.Text, out int B))//Parse je p�evodn�k ze stringu na int
            {
                if (GCD(A, 36) != 1)
                {
                    WarningLabel.Text = "Do A jste zadal soud�lnou hodnotu s 36, zkuste pou��t jinou.";
                    return;
                }

                List<string> encryptedLetters = new List<string>();//sezn�mek co n�m vytvo�� list pro ka�d� ��slo zvl᚝

                foreach (char letter in inputText)
                {
                    if (letter == ' ') //N�hra�ka mezery za poml�ku "-"
                    {
                        encryptedLetters.Add("-");
                    }
                    else
                    {
                        int index = Array.IndexOf(Abeceda, letter);

                        if (index != -1)//vyhazov ��sel co nepat�� do abecedy
                        {
                            int result = (A * index + B) % Abeceda.Length;
                            encryptedLetters.Add(Abeceda[result].ToString());
                        }
                    }
                }

                string encryptedText = string.Join("", encryptedLetters);
                encryptedText = FormatOutput(encryptedText);

                EncryptFinishText.Text = "Za�ifrovan� text: " + encryptedText;
            }
            else //Pokud to najde blb� ��sla nebo ��dn�:
            {
                WarningLabel.Text = "Zadejte platn� ��sla pro A a B!";
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            char[] Abeceda = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            string inputText = DecryptText.Text.ToUpper();

            inputText = RemoveDiacritics(inputText);

            if (int.TryParse(ABox.Text, out int A) && int.TryParse(Bbox.Text, out int B))
            {
                if (GCD(A, 36) != 1)
                {
                    WarningLabel.Text = "Hodnota 'A' mus� b�t nesoud�ln� s 36! Zadejte jinou hodnotu.";
                    return;
                }

                int A_inv = InverzniHodnota(A, Abeceda.Length);
                if (A_inv == -1)
                {
                    WarningLabel.Text = "Nena�la se inverzn� hodnota v A, zkontrolujte vstupn� hodnotu.";
                    return;
                }

                List<string> decryptedLetters = new List<string>();

                foreach (char letter in inputText)
                {
                    if (letter == '-')
                    {
                        decryptedLetters.Add(" ");
                        continue;
                    }

                    int index = Array.IndexOf(Abeceda, letter);

                    if (index != -1)
                    {
                        int result = (A_inv * (index - B + Abeceda.Length)) % Abeceda.Length;

                        decryptedLetters.Add(Abeceda[result].ToString());
                    }
                }

                string decryptedText = string.Join("", decryptedLetters);

                DecryptFinishText.Text = "De�ifrovan� text: " + decryptedText.Trim();
            }
            else
            {
                WarningLabel.Text = "Zadejte platn� ��sla pro A a B!";
            }
        }

        private int GCD(int a, int b)//GCD neboli kontrola soud�lnosti
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Funkce pro v�po�et inverzn� hodnoty A modulo M=(abecedy)
        private int InverzniHodnota(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                    return x;
            }
            return -1; // Pokud inverzn� hodnota neexistuje
        }

        // K�d pro odstran�n� diakritiky
        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC)
                                .Replace('�', 'C')
                                .Replace('�', 'S')
                                .Replace('�', 'R')
                                .Replace('�', 'Z')
                                .Replace('�', 'Y')
                                .Replace('�', 'A')
                                .Replace('�', 'I')
                                .Replace('�', 'E');
        }

        // Funkce pro form�tov�n� na 5 znak�
        private string FormatOutput(string text)
        {
            StringBuilder formattedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (i > 0 && i % 5 == 0)
                {
                    formattedText.Append(" ");
                }
                formattedText.Append(text[i]);
            }
            return formattedText.ToString();
        }

        // Tla��tka pro kop�rov�n�
        private void CopyEncrypted_Click(object sender, EventArgs e)
        {
            string encryptedText = EncryptFinishText.Text.Replace("Za�ifrovan� text: ", "");
            Clipboard.SetText(encryptedText.Trim());
            WarningLabel.Text = "Za�ifrovan� text byl zkop�rov�n do schr�nky.";
        }

        private void CopyDecrypted_Click(object sender, EventArgs e)
        {
            string decryptedText = DecryptFinishText.Text.Replace("De�ifrovan� text: ", "");
            Clipboard.SetText(decryptedText.Trim());
            WarningLabel.Text = "De�ifrovan� text byl zkop�rov�n do schr�nky.";
        }

    }
}