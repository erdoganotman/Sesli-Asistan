using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using SpeechLib;
namespace sesli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpVoice sp = new SpVoice();
            SpeechRecognitionEngine siri=new SpeechRecognitionEngine();
            Grammar g=new DictationGrammar();
            siri.LoadGrammar(g);
            button1.Text = "konuşun";
            siri.SetInputToDefaultAudioDevice();
            RecognitionResult rs=siri.Recognize();
            button1.Text = rs.Text;
            if(button1.Text == "how's the weather") {

                label1.Text = "the weather is rainy today";
                sp.Speak(label1.Text);


            }
            if (button1.Text == "how old are you")
            {
                button1.Text = "Machines don't age";
                sp.Speak(button1.Text);
            }
            if(button1.Text == "How are you ")
            {
                button1.Text = "It's a good day to go crazy";
                sp.Speak(button1.Text);
            }
            if(button1.Text== "calculator")
            {
                button1.Text = "calculator is open";
                sp.Speak(button1.Text);
                System.Diagnostics.Process.Start("calculator.exe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
