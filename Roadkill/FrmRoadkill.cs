using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roadkill
{
    public partial class FrmRoadkill : Form
    {
        Graphics g; // declare the graphics object
        int x = 190, y = 480;// starting position of character
        int lives = 1;
        bool left, right, up, down;
        //Declare the objects
        Rectangle area1;
        Rectangle area2;
        Rectangle area3;
        Rectangle area4;
        Rectangle area5;
        Rectangle area6;
        Rectangle area7;
        Rectangle area8;
        Rectangle area9;
        Rectangle character1;
        int x2 = 50, y2 = 60; //starting position of car1
        int x3 = 75, y3 = 253; //starting position of car2
        int x4 = 250, y4 = 213; //starting position of car3
        int x5 = 125, y5 = 177; //starting position of car4
        int x6 = 150, y6 = 400; //starting position of car5
        int x7 = 305, y7 = 361; //starting position of car6
        int x10 = 0, y10 = 15; //starting position of block1
        int x8 = 250, y8 = 116; //starting position of train1
        int x9 = 305, y9 = 307; //starting position of train2
        //Load our images from the bin\debug folder
        Image character = Image.FromFile(Application.StartupPath + @"\Characterstanding.png");
        Image car1 = Image.FromFile(Application.StartupPath + @"\Yellow car.png");
        Image car2 = Image.FromFile(Application.StartupPath + @"\Red Car.png");

        private void TmrCar_Tick(object sender, EventArgs e)
        {
            area1.X -= 32;// move the area(car) across the panel
            area2.X += 30;// move the area(car) across the panel
            area3.X -= 32;// move the area(car) across the panel
            area4.X += 30;// move the area(car) across the panel
            area5.X -= 29;// move the area(car) across the panel
            area6.X += 26;// move the area(car) across the panel
            area7.X += 57;// move the area(train) across the panel
            area8.X -= 57;// move the area(train) across the panel
            if (area1.X < -25) //AREA 1,3 AND 5 ARE CARS GOING LEFT
            {
                area1.X = 500;
            }
            if (area3.X < -25)
            {
                area3.X = 500;
            }
            if (area5.X < -25)
            {
                area5.X = 500;
            }
            if (area8.X < -300) //TRAIN2 GOING LEFT
            {
                area8.X = 500;
            }
            if (area2.X > 500) //AREA 2,4 AND 6 ARE CARS GOING RIGHT
            {
                area2.X = -25;
            }
            if (area4.X > 500)
            {
                area4.X = -25;
            }
            if (area6.X > 500)
            {
                area6.X = -25;
            }
            if (area7.X > 500) //TRAIN1 GOING RIGHT
            {
                area7.X = -300;
            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            TmrCar.Enabled = true; //start the timer to move the cars
            TmrCharacter.Enabled = true; //start the timer to move the character
        }

        private void MnuQuit_Click(object sender, EventArgs e)
        {
            TmrCar.Enabled = false;
            TmrCharacter.Enabled = false;
            Application.Exit();//ends the program
        }

        Image car3 = Image.FromFile(Application.StartupPath + @"\Police Car.png");
        Image car4 = Image.FromFile(Application.StartupPath + @"\Blue Car.png");
        Image car5 = Image.FromFile(Application.StartupPath + @"\Silver Car.png");
        Image car6 = Image.FromFile(Application.StartupPath + @"\White Car.png");
        Image train1 = Image.FromFile(Application.StartupPath + @"\Train.png");
        Image train2 = Image.FromFile(Application.StartupPath + @"\Train2.png");
        Image block1 = Image.FromFile(Application.StartupPath + @"\something.png");

        //the CheckLives method will stop the planets and spaceship moving if there are no lives left
        // and a game over message will be displayed  
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrCharacter.Enabled = false;
                TmrCar.Enabled = false;
                MessageBox.Show("Game Over");
                Application.Exit();//ends the program
            }
        }

        private void FrmRoadkill_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyData == Keys.Left) { left = false; }
                if (e.KeyData == Keys.Right) { right = false; }
                if (e.KeyData == Keys.Up) { up = false; }
                if (e.KeyData == Keys.Down) { down = false; }
            }
        }

        private void FrmRoadkill_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyData == Keys.Left) { left = true; }
                if (e.KeyData == Keys.Right) { right = true; }
                if (e.KeyData == Keys.Up) { up = true; }
                if (e.KeyData == Keys.Down) { down = true; }
            }
        }

        private void TmrCharacter_Tick(object sender, EventArgs e)
        {
            //if Character collides with any Car or Train, Game Over!
            if (area1.IntersectsWith(character1))
            {
                lives -= 1; // reduce lives by 1
                            //display the number of lives on the form
                LblLives.Text = lives.ToString();

                CheckLives();
            }
            if (area2.IntersectsWith(character1))
            {
                lives -= 1; // reduce lives by 1
                            //display the number of lives on the form
                LblLives.Text = lives.ToString();

                CheckLives();
            }
            if (area3.IntersectsWith(character1))
            {
                lives -= 1; // reduce lives by 1
                            //display the number of lives on the form
                LblLives.Text = lives.ToString();

                CheckLives();
            }
            if (area4.IntersectsWith(character1))
            {
                lives -= 1; // reduce lives by 1
                            //display the number of lives on the form
                LblLives.Text = lives.ToString();

                CheckLives();
            }
            if (area5.IntersectsWith(character1))
            {
                lives -= 1; // reduce lives by 1
                            //display the number of lives on the form
                LblLives.Text = lives.ToString();

                CheckLives();
            }
            if (area6.IntersectsWith(character1))
            {
                lives -= 1; // reduce lives by 1
                            //display the number of lives on the form
                LblLives.Text = lives.ToString();

                CheckLives();
            }
            if (area7.IntersectsWith(character1))
            {
                lives -= 1; // reduce lives by 1
                            //display the number of lives on the form
                LblLives.Text = lives.ToString();

                CheckLives();
            }
            if (area8.IntersectsWith(character1))
            {
                lives -= 1; // reduce lives by 1
                            //display the number of lives on the form
                LblLives.Text = lives.ToString();

                CheckLives();
             
            }
            if (area9.IntersectsWith(character1))
            {
                character1.X = 190;
                character1.Y = 480;

            }
            // CHARACTER MOVEMENTS

            if (left) // if left arrow pressed
            {
                if (character1.X < 10) //check to see if character within 10 of left side
                {
                    character1.X = 10; //if it is < 10 away "bounce" it (set position at 10)
                }
                else
                {
                    character1.X -= 5; //else move 5 to the left
                }

            }
            //move character 5 to the left
            if (right) // if right arrow key pressed
            {
                if (character1.X > PnlGame.Width - 40)// is character within 40 of right side
                {
                    character1.X = PnlGame.Width - 40;
                }
                else
                {
                    character1.X += 5;
                }
            }
            if (up) // if up arrow key pressed
            {
                if (character1.Y < PnlGame.Height - 510)// is character within 40 of right side
                {
                    character1.Y = PnlGame.Height - 510;
                }
                else
                {
                    character1.Y -= 5;
                }
            }
            if (down) // if down arrow key pressed
            {
                if (character1.Y > PnlGame.Height - 40)// is character within 40 of right side
                {
                    character1.Y = PnlGame.Height - 40;
                }
                else
                {
                    character1.Y += 5;
                }
            }
            PnlGame.Invalidate();

        }
        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw cars on the panel
            g.DrawImage(car1, area1);
            g.DrawImage(car2, area2);
            g.DrawImage(car3, area3);
            g.DrawImage(car4, area4);
            g.DrawImage(car5, area5);
            g.DrawImage(car6, area6);
            //use the DrawImage method to draw the character on the panel
            g.DrawImage(character, character1);
            //use the DrawImage method to draw the train on the panel
            g.DrawImage(train1, area7);
            g.DrawImage(train2, area8);
            g.DrawImage(block1, area9);

        }

        public FrmRoadkill()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            area1 = new Rectangle(x2, y2, 43, 25);//car1's rectangle size	
            area2 = new Rectangle(x3, y3, 43, 23);//car2's rectangle size
            area3 = new Rectangle(x4, y4, 47, 27);//car3's rectangle size
            area4 = new Rectangle(x5, y5, 40, 25);//car4's rectangle size
            area5 = new Rectangle(x6, y6, 40, 25);//car5's rectangle size
            area6 = new Rectangle(x7, y7, 50, 27);//car6's rectangle size
            area7 = new Rectangle(x8, y8, 190, 25);//train1's rectangle size 
            area8 = new Rectangle(x9, y9, 190, 25);//train2's rectangle size
            area9 = new Rectangle(x10, y10, 490, 10);//block1's rectangle size
            character1 = new Rectangle(x, y, 20, 15); //character's rectangle size

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use the arrow keys to move the character. \n Watch out for cars and trains! \n You only have one life! \n If you get hit by a car or train, Game Over", "Game Instructions");

        }
    }
}
