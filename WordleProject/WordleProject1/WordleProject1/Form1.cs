namespace WordleProject1
{
    public partial class WordleForm : Form
    {
        private const string WordsTextFile = @"wordsForWordle.txt";
        private const int RowLength = 5;
        private const string PlayAgainMessage = "Play again?";

        private int previousRow = 0;
        private int hintsCount = 0;
        private string currentWord = string.Empty;
        private List<TextBox> currentBoxes = new List<TextBox>();

        public WordleForm()
        {
            InitializeComponent();

            //StartNewGame();

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.MouseClick += this.FocusTextBox;
                tb.KeyDown += this.MoveCursor;
            }
        }

        private void FocusTextBox(object sender, MouseEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Focus();
            }
        }

        private void MoveCursor(object sender, KeyEventArgs e)
        {
            var pressedKey = e.KeyCode;
            var senderTextBox = sender as TextBox;
            var currentTextBoxIndex = int.Parse(senderTextBox.Name.Replace("textBox", ""));

            if (ShouldGoToLeftTextBox(pressedKey, currentTextBoxIndex))
            {
                currentTextBoxIndex--;
            }
            else if (ShouldGoToRightTextBox(pressedKey, currentTextBoxIndex))
            {
                currentTextBoxIndex++;
            }

            var textBox = GetTextBox(currentTextBoxIndex);
            textBox.Focus();
        }

        private bool ShouldGoToLeftTextBox(Keys pressedKey, int currentTextBoxIndex)
            => pressedKey == Keys.Left && !IsFirstTextBox(currentTextBoxIndex);

        private bool IsFirstTextBox(int currentTextBoxIndex)
            => (currentTextBoxIndex + 4) % RowLength == 0;

        private bool ShouldGoToRightTextBox(Keys pressedKey, int currentTextBoxIndex)
           => (pressedKey == Keys.Right || IsAlphabetKeyPressed(pressedKey.ToString())) && !IsLastTextBox(currentTextBoxIndex);

        private bool IsLastTextBox(int currentTextBoxIndex)
            => currentTextBoxIndex % RowLength == 0;

        private bool IsAlphabetKeyPressed(string pressedKeyString)
            => pressedKeyString.Count() == 1 && char.IsLetter(pressedKeyString[0]);

        private TextBox GetTextBox(int index)
        {
            string textBoxName = string.Format("textBox{0}", index);
            return this.Controls[textBoxName] as TextBox;
        }
    }
}