using System.Globalization;
using System.Text;

namespace sifra
{
    public partial class Form1 : Form
    {

        /*
        !!!!!POZN¡MKA NA ZA»¡TEK!!!!!
        !!!!!MODULO JE 36 KVŸLI PÿID¡NÕ 0-9 DO ARRAYE S ABECEDOU!!!!!
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

            if (int.TryParse(ABox.Text, out int A) && int.TryParse(Bbox.Text, out int B))//Parse je p¯evodnÌk ze stringu na int
            {
                if (GCD(A, 36) != 1)
                {
                    WarningLabel.Text = "Do A jste zadal soudÏlnou hodnotu s 36, zkuste pouûÌt jinou.";
                    return;
                }

                List<string> encryptedLetters = new List<string>();//sezn·mek co n·m vytvo¯Ì list pro kaûdÈ ËÌslo zvl·öù

                foreach (char letter in inputText)
                {
                    if (letter == ' ') //N·hraûka mezery za pomlËku "-"
                    {
                        encryptedLetters.Add("-");
                    }
                    else
                    {
                        int index = Array.IndexOf(Abeceda, letter);

                        if (index != -1)//vyhazov ËÌsel co nepat¯Ì do abecedy
                        {
                            int result = (A * index + B) % Abeceda.Length;
                            encryptedLetters.Add(Abeceda[result].ToString());
                        }
                    }
                }

                string encryptedText = string.Join("", encryptedLetters);
                encryptedText = FormatOutput(encryptedText);

                EncryptFinishText.Text = "Zaöifrovan˝ text: " + encryptedText;
            }
            else //Pokud to najde blbÈ ËÌsla nebo û·dnÈ:
            {
                WarningLabel.Text = "Zadejte platn· ËÌsla pro A a B!";
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
                    WarningLabel.Text = "Hodnota 'A' musÌ b˝t nesoudÏln· s 36! Zadejte jinou hodnotu.";
                    return;
                }

                int A_inv = InverzniHodnota(A, Abeceda.Length);
                if (A_inv == -1)
                {
                    WarningLabel.Text = "Nenaöla se inverznÌ hodnota v A, zkontrolujte vstupnÌ hodnotu.";
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

                DecryptFinishText.Text = "Deöifrovan˝ text: " + decryptedText.Trim();
            }
            else
            {
                WarningLabel.Text = "Zadejte platn· ËÌsla pro A a B!";
            }
        }

        private int GCD(int a, int b)//GCD neboli kontrola soudÏlnosti
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Funkce pro v˝poËet inverznÌ hodnoty A modulo M=(abecedy)
        private int InverzniHodnota(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                    return x;
            }
            return -1; // Pokud inverznÌ hodnota neexistuje
        }

        // KÛd pro odstranÏnÌ diakritiky
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
                                .Replace('»', 'C')
                                .Replace('ä', 'S')
                                .Replace('ÿ', 'R')
                                .Replace('é', 'Z')
                                .Replace('›', 'Y')
                                .Replace('¡', 'A')
                                .Replace('Õ', 'I')
                                .Replace('…', 'E');
        }

        // Funkce pro form·tov·nÌ na 5 znak˘
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

        // TlaËÌtka pro kopÌrov·nÌ
        private void CopyEncrypted_Click(object sender, EventArgs e)
        {
            string encryptedText = EncryptFinishText.Text.Replace("Zaöifrovan˝ text: ", "");
            Clipboard.SetText(encryptedText.Trim());
            WarningLabel.Text = "Zaöifrovan˝ text byl zkopÌrov·n do schr·nky.";
        }

        private void CopyDecrypted_Click(object sender, EventArgs e)
        {
            string decryptedText = DecryptFinishText.Text.Replace("Deöifrovan˝ text: ", "");
            Clipboard.SetText(decryptedText.Trim());
            WarningLabel.Text = "Deöifrovan˝ text byl zkopÌrov·n do schr·nky.";
        }

    }
}