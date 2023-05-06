using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ce_spun_romanii_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"Resources\am intrebat 100 de romani board.jpg");
            pictureBox2.Image = null;
            QuestionNumber.Text = Question_nr.ToString();




        }
        void Reset()
        {
            Option1.Text = "?";
            Option2.Text = "?";
            Option3.Text = "?";
            Option4.Text = "?";
            Option5.Text = "?";
            Option6.Text = "?";
            Option7.Text = "?";
            Option8.Text = "?";
        }

        int team = 1;
        int Question_nr = 1;
        int score_1 = 0;
        int score_2 = 0;



        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightGreen;
            label3.BackColor = Color.Transparent;

        }

        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (team==2)
            {

                label1.BackColor = Color.LightGreen;
                label3.BackColor = Color.Transparent;
                team = 1;

            }
            else
            {
                label3.BackColor = Color.LightGreen;
                label1.BackColor = Color.Transparent;
                team = 2;

            }
        }
        


        private void Button2_Click(object sender, EventArgs e)
        {
            if(Question_nr==1)
            {
                pictureBox2.Image = Image.FromFile(@"Resources\Care e materia ta preferata__.png");
            }
            if (Question_nr == 2)
            {
                pictureBox2.Image = Image.FromFile(@"Resources\Care sunt cele mai importante abilități pe care trebuie să le dobândești în timpul școlii pentru a avea succes în carieră_.png");
            }
            if (Question_nr == 3)
            {
                pictureBox2.Image = Image.FromFile(@"Resources\Ce credeți că ar trebui să fie prioritățile sistemului de învățământ din România__.png");

            }
            if (Question_nr == 4)
            {
                pictureBox2.Image = Image.FromFile(@"Resources\Care sunt cei mai importanți factori în decizia voastră de a urma o anumită carieră_.png");

            }
            if (Question_nr == 5)
            {
                pictureBox2.Image = Image.FromFile(@"Resources\Care sunt cele mai importante valori și principii pe care le-ați dobândit în timpul școlii__.png");

            }
            if (Question_nr == 6)
            {
                pictureBox2.Image = Image.FromFile(@"Resources\Ce speranțe aveți pentru viitorul vostru și al țării noastre în general__.png");

            }

        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            Question_nr = Question_nr + 1;
            QuestionNumber.Text = Question_nr.ToString();
            Reset();

            if (Question_nr == 1)
            {
                
                Question.Text = "Care e materia ta preferata?";
            }
            if (Question_nr == 2)
            {
                Question.Text = "Care sunt cele mai importante abilități pe care trebuie să le dobândești în timpul școlii pentru a avea succes în carieră?";
            }
            if (Question_nr == 3)
            {
                Question.Text = "Ce credeți că ar trebui să fie prioritățile sistemului de învățământ din România?";

            }
            if (Question_nr == 4)
            {
                Question.Text = "Care sunt cei mai importanți factori în decizia voastră de a urma o anumită carieră?";

            }
            if (Question_nr == 5)
            {
                Question.Text = "Care sunt cele mai importante valori și principii pe care le-ați dobândit în timpul școlii?";

            }
            if (Question_nr == 6)
            {
                Question.Text = "Ce speranțe aveți pentru viitorul vostru și al țării noastre în general?";

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Question_nr = Question_nr - 1;
            QuestionNumber.Text = Question_nr.ToString();
            Reset();
            if (Question_nr == 1)
            {

                Question.Text = "Care e materia ta preferata?";
            }
            if (Question_nr == 2)
            {
                Question.Text = "Care sunt cele mai importante abilități pe care trebuie să le dobândești în timpul școlii pentru a avea succes în carieră?";
            }
            if (Question_nr == 3)
            {
                Question.Text = "Ce credeți că ar trebui să fie prioritățile sistemului de învățământ din România?";

            }
            if (Question_nr == 4)
            {
                Question.Text = "Care sunt cei mai importanți factori în decizia voastră de a urma o anumită carieră?";

            }
            if (Question_nr == 5)
            {
                Question.Text = "Care sunt cele mai importante valori și principii pe care le-ați dobândit în timpul școlii?";

            }
            if (Question_nr == 6)
            {
                Question.Text = "Ce speranțe aveți pentru viitorul vostru și al țării noastre în general?";

            }
        }

        private void Option1_Click(object sender, EventArgs e)
        {
            if(Question_nr==1)
            {
                Option1.Text = "Informatica";
                if(team==1)
                {
                    score_1 = score_1 + 21;
                    label5.Text = score_1.ToString();
                    
                }
                else
                {
                    score_2 = score_2 + 21;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 2)
            {
                Option1.Text = "Comunicare";
                if (team == 1)
                {
                    score_1 = score_1 + 43;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 43;
                    label6.Text = score_2.ToString();
                }

            }
            if (Question_nr == 3)
            {
                Option1.Text = "Axarea pe pasiuni";
                if (team == 1)
                {
                    score_1 = score_1 + 50;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 50;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 4)
            {
                Option1.Text = "Pasiune";
                if (team == 1)
                {
                    score_1 = score_1 + 33;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 33;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 5)
            {
                Option1.Text = "Nimic";
                if (team == 1)
                {
                    score_1 = score_1 + 20;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 20;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 6)
            {
                Option1.Text = "Lucrurile se vor schimba in bine";
                if (team == 1)
                {
                    score_1 = score_1 + 42;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 42;
                    label6.Text = score_2.ToString();
                }
            }
        }





        private void Option2_Click(object sender, EventArgs e)
        {
            if (Question_nr == 1)
            {
                Option2.Text = "Fizica";
                if (team == 1)
                {
                    score_1 = score_1 + 14;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 14;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 2)
            {
                Option2.Text = "Time management";
                if (team == 1)
                {
                    score_1 = score_1 + 18;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 18;
                    label6.Text = score_2.ToString();
                }

            }
            if (Question_nr == 3)
            {
                Option2.Text = "Practica";
                if (team == 1)
                {
                    score_1 = score_1 + 21;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 21;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 4)
            {
                Option2.Text = "Bani";
                if (team == 1)
                {
                    score_1 = score_1 + 33;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 33;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 5)
            {
                Option2.Text = "Comunicare";
                if (team == 1)
                {
                    score_1 = score_1 + 20;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 20;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 6)
            {
                Option2.Text = "Nicio speranta";
                if (team == 1)
                {
                    score_1 = score_1 + 28;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 28;
                    label6.Text = score_2.ToString();
                }
            }
        }



        private void Option3_Click(object sender, EventArgs e)
        {
            if (Question_nr == 1)
            {
                Option3.Text = "Engleza";
                if (team == 1)
                {
                    score_1 = score_1 + 14;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 14;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 2)
            {
                Option3.Text = "Cariera/Experienta";
                if (team == 1)
                {
                    score_1 = score_1 + 18;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 18;
                    label6.Text = score_2.ToString();
                }

            }
            if (Question_nr == 3)
            {
                Option3.Text = "Ascultarea opiniilor elevilor";
                if (team == 1)
                {
                    score_1 = score_1 + 14;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 14;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 4)
            {
                Option3.Text = "Abilitati proprii";
                if (team == 1)
                {
                    score_1 = score_1 + 23;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 23;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 5)
            {
                Option3.Text = "Disciplina/Responsabilitatea";
                if (team == 1)
                {
                    score_1 = score_1 + 13;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 13;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 6)
            {
                Option3.Text = "Tinerii vor face schimbari";
                if (team == 1)
                {
                    score_1 = score_1 + 21;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 21;
                    label6.Text = score_2.ToString();
                }
            }

        }



        private void Option4_Click(object sender, EventArgs e)
        {
            if (Question_nr == 1)
            {
                Option4.Text = "Biologie";
                if (team == 1)
                {
                    score_1 = score_1 + 14;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 14;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 2)
            {
                Option4.Text = "Responsabilitate";
                if (team == 1)
                {
                    score_1 = score_1 + 12;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 12;
                    label6.Text = score_2.ToString();
                }

            }
            if (Question_nr == 3)
            {
                Option4.Text = "Reformarea sistemului";
                if (team == 1)
                {
                    score_1 = score_1 + 14;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 14;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 4)
            {
                Option4.Text = "Bonusuri";
                if (team == 1)
                {
                    score_1 = score_1 + 5;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 5;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 5)
            {
                Option4.Text = "Rabdare/Toleranta";
                if (team == 1)
                {
                    score_1 = score_1 + 13;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 13;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 6)
            {
                Option4.Text = "Imbunatatirea sistemului educational";
                if (team == 1)
                {
                    score_1 = score_1 + 7;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 7;
                    label6.Text = score_2.ToString();
                }
            }

        }
        private void Option5_Click(object sender, EventArgs e)
        {
            if (Question_nr == 1)
            {
                Option5.Text = "Chimie";
                if (team == 1)
                {
                    score_1 = score_1 + 14;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 14;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 2)
            {
                Option5.Text = "Flexibilitate";
                if (team == 1)
                {
                    score_1 = score_1 + 6;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 6;
                    label6.Text = score_2.ToString();
                }

            }
            if (Question_nr == 3)
            {
                Option5.Text = null;
                if (team == 1)
                {
                    score_1 = score_1 + 14;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 14;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 4)
            {
                Option5.Text = "Nevoia de deplasare";
                if (team == 1)
                {
                    score_1 = score_1 + 5;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 5;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 5)
            {
                Option5.Text = "Invatatul";
                if (team == 1)
                {
                    score_1 = score_1 + 13;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 13;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 6)
            {
                Option5.Text = null;
                if (team == 1)
                {
                    score_1 = score_1 + 21;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 21;
                    label6.Text = score_2.ToString();
                }
            }

        }


        private void Option6_Click(object sender, EventArgs e)
        {
            if (Question_nr == 1)
            {
                Option6.Text = "Romana";
                if (team == 1)
                {
                    score_1 = score_1 + 7;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 7;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 2)
            {
                Option6.Text = null;
                if (team == 1)
                {
                    score_1 = score_1 + 6;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 6;
                    label6.Text = score_2.ToString();
                }

            }
            if (Question_nr == 3)
            {
                Option6.Text = null;
                if (team == 1)
                {
                    score_1 = score_1 + 14;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 14;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 4)
            {
                Option6.Text = null;
                if (team == 1)
                {
                    score_1 = score_1 + 5;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 5;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 5)
            {
                Option6.Text = "Perseverenta/Ambitii";
                if (team == 1)
                {
                    score_1 = score_1 + 13;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 13;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 6)
            {
                Option6.Text = null;
                if (team == 1)
                {
                    score_1 = score_1 + 21;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 21;
                    label6.Text = score_2.ToString();
                }
            }

        }

        private void Option7_Click(object sender, EventArgs e)
        {
            if (Question_nr == 1)
            {
                Option7.Text = "Matematica";
                if (team == 1)
                {
                    score_1 = score_1 + 7;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 7;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 2)
            {
                Option7.Text = null;
                if (team == 1)
                {
                    score_1 = score_1 + 6;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 6;
                    label6.Text = score_2.ToString();
                }

            }
            if (Question_nr == 3)
            {
                Option7.Text = null;
                if (team == 1)
                {
                    score_1 = score_1 + 14;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 14;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 4)
            {
                Option7.Text = null;
                if (team == 1)
                {
                    score_1 = score_1 + 5;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 5;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 5)
            {
                Option7.Text = "Matematica";
                if (team == 1)
                {
                    score_1 = score_1 + 13;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 13;
                    label6.Text = score_2.ToString();
                }
            }
            if (Question_nr == 6)
            {
                Option7.Text = null;
                if (team == 1)
                {
                    score_1 = score_1 + 21;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 21;
                    label6.Text = score_2.ToString();
                }
            }

        }

        private void Option8_Click(object sender, EventArgs e)
        {
            if (Question_nr == 1)
            {
                Option8.Text = "Istorie";
                if (team == 1)
                {
                    score_1 = score_1 + 7;
                    label5.Text = score_1.ToString();

                }
                else
                {
                    score_2 = score_2 + 7;
                    label6.Text = score_2.ToString();
                }
            }
           
           

        }
    }
}
