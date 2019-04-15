using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programme_Vierge
{
    public partial class frmPoly2 : Form
    {
        public static string affichageTotal = "";
        public frmPoly2()
        {
            InitializeComponent();
        }

        private void btnExect_Click(object sender, EventArgs e)
        {
            //Creation d'une liste d'animals
            List<cAnimal> animals = new List<cAnimal>();

            cCat monChat = new cCat();
            //LE chat a un nom qui es envoiyer dans la classe animal dans name 
            monChat.Name = "Roger";
            //Ajouter dans la liste de forme
            animals.Add(monChat);

            cSnake monSerpent = new cSnake();
            //LE Serpant a un nom qui es envoiyer dans la classe animal dans name 
            monSerpent.Name = "Bob le serpent";
            //Ajouter dans la liste de forme
            animals.Add(monSerpent);

            cDog monChien = new cDog();
            //LE chien a un nom qui es envoiyer dans la classe animal dans name 
            monChien.Name = "Rex";
            //Console.WriteLine(monChien.CapitalizedName);


            cGermanShepard monChienPolicier = new cGermanShepard();
            //LE GermanSherperd a un nom qui es envoiyer dans la classe animal dans name 
            monChienPolicier.Name = "Constable Bruno";
            //Ajouter dans la liste de forme
            animals.Add(monChienPolicier);
            //Ajouter dans la liste de forme
            animals.Add(monChien);

            //For each pour resortire le resultat de tout les animaux dans la liste avec l action que nous desirons decouvrire 
            // dans ce cas ci c est juste eat et talk.
            foreach (var animal in animals)
            {
                animal.Eat();
                animal.Talk();
            }
            MessageBox.Show(affichageTotal);
           



        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            cCat monChat = new cCat();
            cSnake monSerpent = new cSnake();
            cDog monChien = new cDog();
            monChat.Name = "Roger";
            monSerpent.Name = "Bob le serpent";
            monChien.Name = "Rex";

            //Ici on appelle la void MakeAnimalEat pis on lui envoiye l animal en parametre pour resortire le resultat
            MakeAnimalEat(monChien);
            MessageBox.Show(affichageTotal);
            affichageTotal = "";
            MakeAnimalEat(monChat);
            MessageBox.Show(affichageTotal);
            affichageTotal = "";
            MakeAnimalEat(monSerpent);
            MessageBox.Show(affichageTotal);
            affichageTotal = "";

        }

        public void MakeAnimalEat(cAnimal animal)
        {
            //D'ici on ressort que ce qu on veux de animal dans ce cas ci c est eat 
            animal.Eat();
        }
    }
   
}
