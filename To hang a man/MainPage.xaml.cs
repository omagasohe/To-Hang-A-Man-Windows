using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace To_hang_a_man
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        String[,] words = {
            { "aberration", "(n.) something that differs from the norm." },
            {"abhor","(v.) to hate, detest."},
            {"acquiesce","(v.) to agree without protesting."},
            {"alacrity","(n.) eagerness, speed."},
            {"amiable","(adj.) friendly."},
            {"appease","(v.) to calm, satisfy"},
            {"arcane","(adj.) obscure, secret, known only by a few."},
            {"avarice","(n.) excessive greed."},
            {"brazen","(adj.) excessively bold, brash, clear and obvious."},
            {"brusque","(adj.) short, abrupt, dismissive."},
            {"cajole","(v.) to urge, coax."},
            {"callous","(adj.) harsh, cold, unfeeling."},
            {"candor","(n.) honesty, frankness"},
            {"chide","(v.) to voice disapproval"},
            {"circumspect","(adj.) cautious"},
            {"clandestine","(adj.) secret"},
            {"coerce","(v.) to make somebody do something by force or threat"},
            {"coherent","(adj.) logically consistent, intelligible"},
            {"complacency","(n.) self-satisfied ignorance of danger"},
            {"confidant","(n.) a person entrusted with secrets"},
            {"connive","(v.) to plot, scheme "},
            {"cumulative","(adj.) increasing, building upon itself"},
            {"debase","(v.) to lower the quality or esteem of something"},
            {"decry","(v.) to criticize openly"},
            {"deferential","(adj.) showing respect for another’s authority"},
            {"demure","(adj.) quiet, modest, reserved"},
            {"deride","(v.) to laugh at mockingly, scorn"},
            {"despot","(n.) one who has total power and rules brutally"},
            {"diligent","(adj.) showing care in doing one’s work"},
            {"elated","(adj.) overjoyed, thrilled"},
            {"eloquent","(adj.) expressive, articulate, moving"},
            {"embezzle","(v.) to steal money by falsifying records"},
            {"empathy","(n.) sensitivity to another’s feelings as if they were one’s own"},
            {"enmity","(n.) ill will, hatred, hostility "},
            {"erudite","(adj.) learned "},
            {"extol","(v.) to praise, revere"},
            {"fabricate","(v.) to make up, invent"},
            {"feral","(adj.) wild, savage"},
            {"flabbergasted","(adj.) astounded"},
            {"forsake","(v.) to give up, renounce"},
            {"fractious","(adj.) troublesome or irritable"},
            {"furtive","(adj.) secretive, sly"},
            {"gluttony","(n.) overindulgence in food or drink"},
            {"gratuitous","(adj.) uncalled for, unwarranted"},
            {"haughty","(adj.) disdainfully proud"},
            {"hypocrisy","(n.) pretending to believe what one does not"},
            {"impeccable","(adj.) exemplary, flawless"},
            {"impertinent","(adj.) rude, insolent"},
            {"implacable","(adj.) incapable of being appeased or mitigated"},
            {"impudent","(adj.) casually rude, insolent, impertinent "},
            {"incisive","(adj.) clear, sharp, direct"},
            {"indolent","(adj.) lazy"},
            {"inept","(adj.) not suitable or capable, unqualified"},
            {"infamy","(n.) notoriety, extreme ill repute"},
            {"inhibit","(v.) to prevent, restrain, stop"},
            {"innate","(adj.) inborn, native, inherent"},
            {"insatiable","(adj.) incapable of being satisfied"},
            {"insular","(adj.) separated and narrow-minded; tight-knit, closed off"},
            {"intrepid","(adj.) brave in the face of danger"},
            {"inveterate","(adj.) stubbornly established by habit"},
            {"jubilant","(adj.) extremely joyful, happy"},
            {"knell","(n.) the solemn sound of a bell, often indicating a death"},
            {"lithe","(adj.) graceful, flexible, supple "},
            {"lurid","(adj.) ghastly, sensational"},
            {"maverick","(n.) an independent, nonconformist person"},
            {"maxim","(n.) a common saying expressing a principle of conduct"},
            {"meticulous","(adj.) extremely careful with details "},
            {"modicum","(n.) a small amount of something "},
            {"morose","(adj.) gloomy or sullen "},
            {"myriad","(adj.) consisting of a very great number "},
            {"nadir","(n.) the lowest point of something "},
            {"nominal","(adj.) trifling, insignificant"},
            {"novice","(n.) a beginner, someone without training or experience"},
            {"nuance","(n.) a slight variation in meaning, tone, expression "},
            {"oblivious","(adj.) lacking consciousness or awareness of something "},
            {"obsequious","(adj.) excessively compliant or submissive "},
            {"obtuse","(adj.) lacking quickness of sensibility or intellect"},
            {"parody","(n.) a satirical imitation "},
            {"penchant","(n.) a tendency, partiality, preference "},
            {"perusal","(n.) a careful examination, review "},
            {"plethora","(n.) an abundance, excess"},
            {"predilection","(n.) a preference or inclination for something "},
            {"quaint","(adj.) charmingly old-fashioned "},
            {"rash","(adj.) hasty, incautious "},
            {"refurbish","(v.) to restore, clean up "},
            {"repudiate","(v.) to reject, refuse to accept "},
            {"rife","(adj.) abundant "},
            {"salient","(adj.) significant, conspicuous "},
            {"serendipity","(n.) luck, finding good things without looking for them "},
            {"staid","(adj.) sedate, serious, self-restrained"},
            {"superfluous","(adj.) exceeding what is necessary"},
            {"sycophant","(n.) one who flatters for self-gain "},
            {"taciturn","(adj.) not inclined to talk"},
            {"truculent","(adj.) ready to fight, cruel"},
            {"umbrage","(n.) resentment, offence "},
            {"venerable","(adj.) deserving of respect because of age or achievement"},
            {"vex","(v.) to confuse or annoy"},
            {"vociferous","(adj.) loud, boisterous "},
            {"wanton","(adj.) undisciplined, lewd, lustful "},
            {"zenith","(n.) the highest point, culminating point "}
        };

        Button[] BList;
        String Word;
        String Hint;
        bool[] showLetter;
        int failedAttempts;

        BitmapImage[] GallowsImage; 

        public MainPage()
        {
            this.InitializeComponent();
            GallowsImage = new BitmapImage[]{
                new BitmapImage(new Uri(this.BaseUri, "/Gallows/0.png")),
                new BitmapImage(new Uri(this.BaseUri, "/Gallows/1.png")),
                new BitmapImage(new Uri(this.BaseUri, "/Gallows/2.png")),
                new BitmapImage(new Uri(this.BaseUri, "/Gallows/3.png")),
                new BitmapImage(new Uri(this.BaseUri, "/Gallows/4.png")),
                new BitmapImage(new Uri(this.BaseUri, "/Gallows/5.png")),
                new BitmapImage(new Uri(this.BaseUri, "/Gallows/6.png")),

            };
            BList = new Button[]{ BtnA,BtnB,BtnC,BtnD,BtnE,BtnF,BtnG,BtnH,BtnI,BtnJ,BtnK,BtnL,BtnM,BtnN,BtnO,BtnP,BtnQ,BtnR,BtnS,BtnT,BtnU,BtnV,BtnW,BtnX,BtnY,BtnZ };
            gallows.Source = GallowsImage[0];
            StartGame();
        }

        private void StartGame()
        {
            Random rnd =new Random();

            int wordIdx = rnd.Next(0,(words.Length/2));
            failedAttempts = 0;
            Word = words[wordIdx, 0];
            Hint = words[wordIdx, 1];
            showLetter = new bool[Word.Length];
            textBox.Text= "";
            btnHint.Content = "Click for defination";
            underscoreWord();
            foreach (Button b in BList)
                b.IsEnabled = true;
        }


        private void underscoreWord()
        {
            StringWriter s = new StringWriter();

            for (int i =0; i< Word.Length;i++)
            {
                if (i != 0)
                    s.Write(" ");
                if (showLetter[i])
                    s.Write(Word.Substring(i, 1));
                else
                    s.Write("_");
            }
            //s.Write("    " + Word);
            textBox.Text = s.ToString();

            
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
 

            Button b = (Button)sender;
            b.IsEnabled = false;
            int i = 0;
            bool found = false;
            while( (i = Word.IndexOf(b.Content.ToString(),i)) != -1)
            {
                found = true;
                showLetter[i] = true;
                i += 1;
            }

            if(!found)
            {
                failedAttempts++;
            }

            underscoreWord();
            if (failedAttempts <= 6)
            {
                gallows.Source = GallowsImage[failedAttempts];
            }
            if (failedAttempts >= 6 || !textBox.Text.Contains("_"))
            {
                foreach (Button t in BList)
                    t.IsEnabled = false;
                this.Frame.Navigate(typeof(EndGame), new EndData(Word,Hint, failedAttempts < 6));
            }
        }

        private void btnHint_Click(object sender, RoutedEventArgs e)
        {

                Button b = (Button)sender;
                b.Content = Hint;

        }

     }
}
