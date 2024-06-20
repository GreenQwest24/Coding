using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Diagnostics;
using System.IO.Ports;

namespace VoiceBot
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer s = new SpeechSynthesizer();
        Boolean wake = true;
        SerialPort port = new SerialPort("COM3",9600, Parity.None,8, StopBits.One);


        Choices list = new Choices();
        public Form1()
        {

            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();


            list.Add(new String[] { "hello", "how are you", "what time is it", "what is today", "open pointclickcare", "wake", "sleep" , "restart" , "update" , "light on", "light off" , "thank you"});

            Grammar gr = new Grammar(new GrammarBuilder(list));

            try
            {
                rec.RequestRecognizerUpdate();
                rec.LoadGrammar(gr);
                rec.SpeechRecognized += rec_SpeechRecognized;
                rec.SetInputToDefaultAudioDevice();
                rec.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch { return; }


            s.SelectVoiceByHints(VoiceGender.Female);

            //s.Speak("Hello, My name is Voice Bot");

            /*int testInt = 1;
            {
                for (int i = 0; i < 10; i++)
                {
                    testInt += i;
                }
            }*/


            InitializeComponent();
        }
        public void restart()
        {
            Process.Start(@"Laurence-Personal\Desktop:\VBot\VBot.exe");
            Environment.Exit(0);
        }
        public void say(string h)
        {
            s.Speak(h);
            textBox2.AppendText(h + "\n");
        }
        private void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String r = e.Result.Text;

            if (r == "wake")
            {
                wake = true;
                label3.Text = "State Awake";
            }
            if (r == "sleep") { 
                wake = false;
                label3.Text = "State Sleep mode";

            }

            if (r == "light on")
            {
                port.Open();
                port.WriteLine("A");
                port.Close();
            }

            if (r == "light off")
            {
                port.Open();
                port.WriteLine("B");
                port.Close();
            }



            if (wake == true)
            {



                if (r == "restart" || r == "update")
                {
                    restart();
                }

                //What you say
                if (r == "hello")
                {
                    // what the AI response is
                    say("Hi,!");

                }

                if (r == "what time is it")
                {
                    say(DateTime.Now.ToString("H:mm tt"));
                }

                if (r == "what is today")
                {
                    say(DateTime.Now.ToString("M/d/yyyy"));
                }


                if (r == "hello, VoiceBot")
                {

                    say("Hello, Whom are documenting on... today?");

                }

                if (r == "thank you")
                {

                    say("You are welcome");

                }



                if ((r == "open pointclickcare"))
                {
                    Process.Start("https://login.pointclickcare.com/home/userLogin.xhtml?_gl=1*1a3g2py*_ga*NzIyNTQzMTQ4LjE3MTA4NzkyMjI.*_ga_NBXHRQDSJE*MTcxNzE0NjYwMC4yMS4wLjE3MTcxNDY2MDAuNjAuMC4w&_ga=2.84420953.1120398435.1717146601-722543148.1710879222");
                }
            }
            textBox1.AppendText(r + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

    
