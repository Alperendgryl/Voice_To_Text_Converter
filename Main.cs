using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Speech.Recognition;
namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSpeak_Click(object sender, EventArgs e)
        {
            


            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);
            

            try
            {
                BtnSpeak.Text = "Please Speak";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                richTextBox1.Text = res.Text;



            }
            catch (NullReferenceException)
            {
                BtnSpeak.Text = "ERROR";

            }


        }

        private void BtnListen_Click(object sender, EventArgs e)
        {
            SpVoice ses = new SpVoice();
            ses.Speak(richTextBox1.Text);
        }
    }
}
