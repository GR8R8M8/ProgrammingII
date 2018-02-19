using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;

namespace Animals
{
    enum Gender { Male, Female, Neutered, Spayed, Unknown};

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            Random gen = new Random();

            if (radDog.Checked == true)
            {
                Gender random = (Gender)gen.Next((int)Gender.Male, (int)Gender.Unknown + 1);
                Animal doggo1 = new Dog();

                doggo1.name = Interaction.InputBox("Enter your dog's name");
                doggo1.color = Interaction.InputBox("Enter your dog's color");
                doggo1.weight = Convert.ToDouble(Interaction.InputBox("Enter your dog's weight"));
                doggo1.gender = random;

                lblOutput.Text += doggo1.ToString();
                doggo1.Noise();
            }
            else if (radCat.Checked == true)
            {
                Gender random = (Gender)gen.Next((int)Gender.Male, (int)Gender.Unknown + 1);
                Animal cato1 = new Cat();

                cato1.name = Interaction.InputBox("Enter your cat's name");
                cato1.color = Interaction.InputBox("Enter your cat's color");
                cato1.weight = Convert.ToDouble(Interaction.InputBox("Enter your cat's weight"));
                cato1.gender = random;

                lblOutput.Text += cato1.ToString();
                cato1.Noise();
            }
            else if (radBird.Checked == true)
            {
                Gender random = (Gender)gen.Next((int)Gender.Male, (int)Gender.Unknown + 1);
                Animal birb1 = new Bird();

                birb1.name = Interaction.InputBox("Enter your bird's name");
                birb1.color = Interaction.InputBox("Enter your bird's color");
                birb1.weight = Convert.ToDouble(Interaction.InputBox("Enter your bird's weight"));
                birb1.gender = random;

                lblOutput.Text += birb1.ToString();
                birb1.Noise();
            }


        }
    }

    #region Animal
    abstract class Animal
    {
        public string name { get; set; }
        public string color { get; set; }
        public double weight { get; set; }
        public Gender gender { get; set; }

        public Animal(string name = "", string color = "", double weight = 0, Gender gender = Gender.Unknown)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
            this.gender = gender;
        }

        public override string ToString()
        {
            return String.Format("\n\nName: {0} \nColor: {1}, \nWeight: {2} \nGender: {3}", name, color, weight, gender);
        }

        public abstract void Noise();
    }
    #endregion

    #region Dog : Animal
    class Dog : Animal
    {
        public Dog(string name = "", string color = "", double weight = 0, Gender gender = Gender.Unknown) : base(name, color, weight, gender) { }

        public override void Noise()
        {
            SoundPlayer bark = new SoundPlayer(@"res/DogBark.wav");
            bark.Play();
        }
    }
    #endregion

    #region Cat : Animal
    class Cat : Animal
    {
        public Cat(string name = "cato", string color = "orange", double weight = 0, Gender gender = Gender.Unknown) : base(name, color, weight, gender) { }

        public override void Noise()
        {
            SoundPlayer meow = new SoundPlayer(@"res/CatMeow.wav");
            meow.Play();
        }
    }
    #endregion 

    #region Bird : Animal
    class Bird : Animal
    {
        public Bird(string name = "borb", string color = "green", double weight = 0, Gender gender = Gender.Unknown) : base(name, color, weight, gender) { }

        public override void Noise()
        {
            SoundPlayer tweet = new SoundPlayer(@"res/Borb.wav");
            tweet.Play();
        }
    }
    #endregion 
}
