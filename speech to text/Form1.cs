using System;
using System.Windows.Forms;
using System.Speech.Recognition; 
using System.ComponentModel;

namespace speech_to_text
{
    public partial class Form1 : Form
    {
        
        private SpeechRecognitionEngine recognizer;
        private bool isRecognizing = false;

        public Form1()
        {
            InitializeComponent();
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
              
                recognizer = new SpeechRecognitionEngine();

                recognizer.SetInputToDefaultAudioDevice();

                Grammar grammar = new DictationGrammar();
                recognizer.LoadGrammar(grammar);

                recognizer.SpeechRecognized += recognizer_SpeechRecognized;

                this.FormClosing += Form1_FormClosing;

                richTextBox1.Text = "Konuşma Tanıma Motoru Hazır. Başlat'a tıklayın.\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Konuşma Tanıma Motoru Hazırlanırken Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                recognizer = null;
            }
        }

        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            richTextBox1.Text += e.Result.Text + "\r\n";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (recognizer != null && !isRecognizing)
            {
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                isRecognizing = true;

                richTextBox1.Text += "🎙️ Konuşma Başlatıldı...\r\n";

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (recognizer != null && isRecognizing)
            {
                recognizer.RecognizeAsyncStop();
                isRecognizing = false;

                richTextBox1.Text += "🛑 Konuşma Durduruldu.\r\n";

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (recognizer != null)
            {
                if (isRecognizing)
                {
                    recognizer.RecognizeAsyncStop();
                }

                recognizer.SpeechRecognized -= recognizer_SpeechRecognized;

                recognizer.Dispose();
            }
        }
    }
}