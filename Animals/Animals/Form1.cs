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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (radDog.Checked == true)
            {
                //You say "Animal" then "new Dog" because you are saying that you are creating a new dog object that inherits the properties of Animal
                Animal doggo1 = new Dog();

                doggo1.name = Interaction.InputBox("Enter your dog's name");
                doggo1.color = Interaction.InputBox("Enter your dog's color");
                doggo1.weight = Convert.ToDouble(Interaction.InputBox("Enter your dog's weight"));
                
                //I overloaded the ".ToString()" function to make output of data cleaner
                lblOutput.Text += doggo1.ToString();
                doggo1.Noise();
            }
            else if (radCat.Checked == true)
            {
                Animal cato1 = new Cat();

                cato1.name = Interaction.InputBox("Enter your cat's name");
                cato1.color = Interaction.InputBox("Enter your cat's color");
                cato1.weight = Convert.ToDouble(Interaction.InputBox("Enter your cat's weight"));

                lblOutput.Text += cato1.ToString();
                cato1.Noise();
            }
            else if (radBird.Checked == true)
            {
                Animal birb1 = new Bird();

                birb1.name = Interaction.InputBox("Enter your bird's name");
                birb1.color = Interaction.InputBox("Enter your bird's color");
                birb1.weight = Convert.ToDouble(Interaction.InputBox("Enter your bird's weight"));

                lblOutput.Text += birb1.ToString();
                birb1.Noise();
            }
        }
    }

    //Start of objects
    //I used "#region" to make the code easier to read, it creates named collapsable areas

    #region Animal
    //MUST BE ABSTRACT - There is an abstract method inside of here, so the method needs to be abstract
    abstract class Animal
    {
        public string name { get; set; }
        public string color { get; set; }
        public double weight { get; set; }

        public Animal(string name = "Animal", string color = "Color", double weight = 0)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
        }

        public override string ToString()
        {
            return String.Format("\n\nName: {0} \nColor: {1}, \nWeight: {2}", name, color, weight);
        }

        //MUST BE ABSTRACT - Essentially says that all child classes require a method called "Noise"
        public abstract void Noise();
    }
    #endregion

    #region Dog : Animal
    //Must have the ":" to signify that the object inherits all properties of Animal
    class Dog : Animal
    {
        public Dog(string name = "Borb", string color = "Green", double weight = 0)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
        }

        //MUST BE OVERRIDE - Essentially says that this is the new functionality of the Noise() function
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
        public Cat(string name = "Borb", string color = "Green", double weight = 0)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
        }

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
        public Bird(string name = "Borb", string color = "Green", double weight = 0)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
        }

        public override void Noise()
        {
            SoundPlayer tweet = new SoundPlayer(@"res/Borb.wav");
            tweet.Play();
        }
    }
    #endregion 
}
