using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Tax
{
    public partial class Form1 : Form
    {
        bool peace = false; //PEACE
        int enemyspeed = 4;
        int shooterspeed = 7;
        bool testlabels = false;
        bool testbuttons = false;
        bool testpb = false;

        #region genereal variables
        int changewavestorage = -1;
        bool cw = false; //custom wave
        bool started = false;
        bool cleared = false;
        bool cantdie = false;
        string direction = "";
        bool goleft, goright, goup, godown;
        bool gameOver = false;
        string facing = "up";
        string lastmove = "";
        int php = 100;
        int score = 0;
        int coin = 0;

        int cgun = 0; //current gun 0-tól

        int roomax = 2; //szobák száma
        int room = 0;

        int db;

        bool sg = false;
        float sgtime = 0;

        int idd;

        bool walled = false; //is there a wall

        #endregion

        #region waves
        struct waves
        {
            public int wn; //wave's number

            public int onmap; //mennyi enemy lehet a pályán
            public int shooter;
            public int zombie;
        }
        int wavee = 0;
        waves[] wave = new waves[200];
        private void setwavesdata()
        {
            int n = 0;

            wave[n].wn = n; //0
            wave[n].zombie = 4;
            wave[n].shooter = 0;
            wave[n].onmap = 2;
            n++;

            wave[n].wn = n; //1
            wave[n].zombie = 9;
            wave[n].shooter = 2;
            wave[n].onmap = 2;
            n++;

            wave[n].wn = n; //2
            wave[n].zombie = 12;
            wave[n].shooter = 2;
            wave[n].onmap = 2;
            n++;

            wave[n].wn = n; //3
            wave[n].zombie = 12;
            wave[n].shooter = 2;
            wave[n].onmap = 3;
            n++;

            wave[n].wn = n; //4
            wave[n].zombie = 15;
            wave[n].shooter = 4;
            wave[n].onmap = 3;
            n++;

            wave[n].wn = n; //5
            wave[n].zombie = 5;
            wave[n].shooter = 8;
            wave[n].onmap = 2;
            n++;

            wave[n].wn = n; //6
            wave[n].zombie = 3;
            wave[n].shooter = 11;
            wave[n].onmap = 2;
            n++;

            wave[n].wn = n; //7
            wave[n].zombie = 0;
            wave[n].shooter = 15;
            wave[n].onmap = 2;
            n++;

            wave[n].wn = n; //8
            wave[n].zombie = 5;
            wave[n].shooter = 15;
            wave[n].onmap = 2;
            n++;

            wave[n].wn = n; //9
            wave[n].zombie = 10;
            wave[n].shooter = 12;
            wave[n].onmap = 3;
            n++;

            wave[n].wn = n; //10
            wave[n].zombie = 15;
            wave[n].shooter = 15;
            wave[n].onmap = 3;
            n++;

            for (int i = 1; i < 90; i++) //89
            {
                wave[n].wn = n; //10
                wave[n].zombie = 15 + i* 2;
                wave[n].shooter = 15 + i * 2;
                wave[n].onmap = 3;
                n++;
            }

        }
        #endregion

        #region guns
        struct guns
        {
            public int number;
            public bool piercing;
            public float cooldown;
            public int magazine;
            public float reloadingtime;
            public int power;
            public int killluck;
            public int lifesteal;
            public int movespeed;
            public int price;

            public int ammo;
            public int inammo;


            public int almin; //ammo loot minumum
            public int almax; //ammo loot maximum
        }
        private void setgunsdata()
        {
            gun[0].number = 1; // bad pistol
            gun[0].piercing = false;
            gun[0].cooldown = 1;
            gun[0].magazine = 5;
            gun[0].reloadingtime = 2;
            gun[0].power = 1;
            gun[0].killluck = 1;
            gun[0].lifesteal = 0;
            gun[0].almin = 4;
            gun[0].almax = 6;
            gun[0].movespeed = 10;
            gun[0].price = 5;
            gun[0].ammo = 0;
            gun[0].inammo = 0;



            gun[1].number = 2; // good pistol
            gun[1].piercing = false;
            gun[1].cooldown = 0.8f;
            gun[1].magazine = 7;
            gun[1].reloadingtime = 1.7f;
            gun[1].power = 2;
            gun[1].killluck = 1;
            gun[1].lifesteal = 0;
            gun[1].almin = 3;
            gun[1].almax = 7;
            gun[1].movespeed = 10;
            gun[1].price = 5;
            gun[1].ammo = 0;
            gun[1].inammo = 0;

            gun[2].number = 3; // shotgun
            gun[2].piercing = false;
            gun[2].cooldown = 1;
            gun[2].magazine = 3;
            gun[2].reloadingtime = 2;
            gun[2].power = 1;
            gun[2].killluck = 1;
            gun[2].lifesteal = 0;
            gun[2].almin = 2;
            gun[2].almax = 6;
            gun[2].movespeed = 9;
            gun[2].price = 10;
            gun[2].ammo = 0;
            gun[2].inammo = 0;

            gun[3].number = 3; // sniper
            gun[3].piercing = true;
            gun[3].cooldown = 1.4f;
            gun[3].magazine = 5;
            gun[3].reloadingtime = 2;
            gun[3].power = 1;
            gun[3].killluck = 1;
            gun[3].lifesteal = 1;
            gun[3].almin = 2;
            gun[3].almax = 4;
            gun[3].movespeed = 10;
            gun[3].price = 10;
            gun[3].ammo = 0;
            gun[3].inammo = 0;

            gun[4].number = 4; // smg
            gun[4].piercing = false;
            gun[4].cooldown = 0;
            gun[4].magazine = 20;
            gun[4].reloadingtime = 1;
            gun[4].power = 1;
            gun[4].killluck = 2;
            gun[4].lifesteal = 0;
            gun[4].almin = 15;
            gun[4].almax = 20;
            gun[4].movespeed = 13;
            gun[4].price = 2;
            gun[4].ammo = 0;
            gun[4].inammo = 0;
        }
        guns[] gun = new guns[5];

        float wtime;
        bool reloading = false;
        bool canshoot = true;
        #endregion

        Random rm = new Random();
        List<PictureBox> enemylist = new List<PictureBox>();
        List<PictureBox> walllist = new List<PictureBox>();

        class Bullet
        {
            public string direction;
            public int bulletLeft;
            public int bulletTop;

            public int speed = 20;
            private PictureBox bullet = new PictureBox();
            private Timer bt = new Timer(); //bullet timer

            bool sr = true;
            bool sh = false;

            public void makeb(Form form)
            {
                speed = 20;
                sr = false;
                sh = false;
                bullet.BackColor = System.Drawing.Color.Yellow;
                bullet.Size = new Size(7, 7);
                bullet.Tag = "bullet";
                bullet.Left = bulletLeft;
                bullet.Top = bulletTop;
                bullet.BringToFront();
                form.Controls.Add(bullet);

                bt.Interval = speed;
                bt.Tick += new EventHandler(bt_Tick);
                bt.Start();
            }
            public void makeRedb(Form form)
            {
                speed = 20;
                sr = false;
                sh = false;
                bullet.BackColor = System.Drawing.Color.Red;
                bullet.Size = new Size(7, 7);
                bullet.Tag = "bullet";
                bullet.Left = bulletLeft;
                bullet.Top = bulletTop;
                bullet.BringToFront();
                form.Controls.Add(bullet);

                bt.Interval = speed;
                bt.Tick += new EventHandler(bt_Tick);
                bt.Start();
            }

            public void makeSniperb(Form form)
            {
                speed = 30;
                sr = true;
                sh = false;
                bullet.BackColor = System.Drawing.Color.Blue;
                bullet.Size = new Size(7, 7);
                bullet.Tag = "bullet";
                bullet.Left = bulletLeft;
                bullet.Top = bulletTop;
                bullet.BringToFront();
                form.Controls.Add(bullet);

                bt.Interval = speed;
                bt.Tick += new EventHandler(bt_Tick);
                bt.Start();
            }

            public void makeSb(Form form)
            {
                speed = 30;
                sr = false;
                sh = true;
                bullet.BackColor = System.Drawing.Color.DarkGreen;
                bullet.Size = new Size(20, 10);
                bullet.Tag = "Sbullet";
                bullet.Left = bulletLeft;
                bullet.Top = bulletTop;
                bullet.BringToFront();
                form.Controls.Add(bullet);

                bt.Interval = speed;
                bt.Tick += new EventHandler(bt_Tick);
                bt.Start();
            }

            public void bt_Tick(object sender, EventArgs e)
            {
                if (sr)
                {
                    if (direction == "left")
                    {
                        bullet.Left -= speed;
                        bullet.Size = new Size(21, 7);
                    }
                    if (direction == "right")
                    {
                        bullet.Left += speed;
                        bullet.Size = new Size(21, 7);
                    }
                    if (direction == "up")
                    {
                        bullet.Top -= speed;
                        bullet.Size = new Size(7, 21);
                    }

                    if (direction == "down")
                    {
                        bullet.Top += speed;
                        bullet.Size = new Size(7, 21);
                    }
                }
                else if (sh)
                {
                    if (direction == "left")
                    {
                        bullet.Left -= speed;
                        bullet.Size = new Size(15, 8);
                    }
                    if (direction == "right")
                    {
                        bullet.Left += speed;
                        bullet.Size = new Size(15, 8);
                    }
                    if (direction == "up")
                    {
                        bullet.Top -= speed;
                        bullet.Size = new Size(8, 15);
                    }

                    if (direction == "down")
                    {
                        bullet.Top += speed;
                        bullet.Size = new Size(8, 15);
                    }
                }
                else
                {
                    if (direction == "left")
                    {
                        bullet.Left -= speed;
                    }
                    if (direction == "right")
                    {
                        bullet.Left += speed;
                    }
                    if (direction == "up")
                    {
                        bullet.Top -= speed;
                    }

                    if (direction == "down")
                    {
                        bullet.Top += speed;
                    }
                }
                bullet.BringToFront();


                if (bullet.Left < 0 || bullet.Left > 1000 || bullet.Top < 0 || bullet.Top > 660)
                {
                    bt.Stop(); // stop the timer
                    bt.Dispose(); // dispose the timer event and component from the program
                    bullet.Dispose(); // dispose the bullet
                    bt = null; // nullify the timer object
                    bullet = null; // nullify the bullet object
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            setgunsdata();
            setwavesdata();
            RoomRender();
            gun[0].inammo += 10;
            skinturn();
            dr.Top = player.Top;
            dr.Left = player.Left;

            player.Left = 500;
            dr.Top = player.Top;
            dr.Left = player.Left;

            walllist.Add(shop);
            walllist.Add(river);
            walllist.Add(enemycounter);
            walllist.Add(wavecounter);

            ready.Visible = true;
            ready.Enabled = true;

            player.Visible = false;

            bg.Top = 0;
            startgame.Top = 260;
            exitgame.Top = 390;
        }

        private void skinturn() //change skin when turning
        {
            if (cgun != 3)
            {
                dr.Height = 81;
                dr.Width = 75;
            }
            if (cgun == 0)
            {
                player.Height = 81;
                player.Width = 75;
                if (facing == "up")
                {
                    player.Image = Properties.Resources.bpistol_up;
                }
                else if (facing == "right")
                {
                    player.Image = Properties.Resources.bpistol_right;
                }
                else if (facing == "down")
                {
                    player.Image = Properties.Resources.bpistol_down;
                }
                else if (facing == "left")
                {
                    player.Image = Properties.Resources.bpistol_left;
                }
            }
            else if (cgun == 1)
            {
                player.Height = 81;
                player.Width = 75;
                if (facing == "up")
                {
                    player.Image = Properties.Resources.goodpistol_up;
                }
                else if (facing == "right")
                {
                    player.Image = Properties.Resources.goodpistol_right;
                }
                else if (facing == "down")
                {
                    player.Image = Properties.Resources.goodpistol_down;
                }
                else if (facing == "left")
                {
                    player.Image = Properties.Resources.goodpistol_left;
                }
            }
            else if (cgun == 2)
            {
                player.Height = 81;
                player.Width = 75;
                if (facing == "up")
                {
                    player.Image = Properties.Resources.shotgun_up;
                }
                else if (facing == "right")
                {
                    player.Image = Properties.Resources.shotgun_right;
                }
                else if (facing == "down")
                {
                    player.Image = Properties.Resources.shotgun_down;
                }
                else if (facing == "left")
                {
                    player.Image = Properties.Resources.shotgun_left;
                }
            }
            else if (cgun == 3)
            {
                if (facing == "up")
                {
                    player.Image = Properties.Resources.sniper_upp;
                    player.Height = 117;
                    player.Width = 81;
                    dr.Height = 117;
                    dr.Width = 81;
                }
                else if (facing == "right")
                {
                    player.Image = Properties.Resources.sniper__leftt;
                    player.Height = 81;
                    player.Width = 117;
                    dr.Height = 81;
                    dr.Width = 117;
                }
                else if (facing == "down")
                {
                    player.Image = Properties.Resources.sniper_donwnn;
                    player.Height = 117;
                    player.Width = 81;
                    dr.Height = 117;
                    dr.Width = 81;
                }
                else if (facing == "left")
                {
                    player.Image = Properties.Resources.sniper_rightt;
                    player.Height = 81;
                    player.Width = 117;
                    dr.Height = 81;
                    dr.Width = 117;
                }
            }
            else if (cgun == 4)
            {
                player.Height = 81;
                player.Width = 75;
                if (facing == "up")
                {
                    player.Image = Properties.Resources.smg_up;
                }
                else if (facing == "right")
                {
                    player.Image = Properties.Resources.smg_right;
                }
                else if (facing == "down")
                {
                    player.Image = Properties.Resources.smg_down;
                }
                else if (facing == "left")
                {
                    player.Image = Properties.Resources.smg_left;
                }
            }
        }
        private void Keydown(object sender, KeyEventArgs e)
        {

            if (!gameOver)
            {

                if (e.KeyCode == Keys.A)
                {
                    goleft = true;
                    lastmove = "left";
                }

                if (e.KeyCode == Keys.D)
                {
                    goright = true;
                    lastmove = "right";
                }

                if (e.KeyCode == Keys.W)
                {
                    goup = true;
                    lastmove = "up";
                }

                if (e.KeyCode == Keys.S)
                {
                    godown = true;
                    lastmove = "down";
                }


                //---------------------------------------------------

                if (e.KeyCode == Keys.Left)
                {
                    facing = "left";
                    skinturn();
                }

                if (e.KeyCode == Keys.Right)
                {
                    facing = "right";
                    skinturn();
                }

                if (e.KeyCode == Keys.Up)
                {
                    facing = "up";
                    skinturn();
                }

                if (e.KeyCode == Keys.Down)
                {
                    facing = "down";
                    skinturn();
                }


                //--------------

            }
            if (e.KeyCode == Keys.Enter)
            {
                RestartGame();
            }
        }

        private void Keyup(object sender, KeyEventArgs e)
        {
            if (gameOver && started) return; // if game is over then do nothing in this event

            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.W)
            {
                goup = false;
            }

            if (e.KeyCode == Keys.S)
            {
                godown = false;
            }

            if (e.KeyCode == Keys.T)
            {
                menu.Visible = true;
            }
            if (e.KeyCode == Keys.Z)
            {
                menu.Visible = false;
            }
            #region hack
            if (e.KeyCode == Keys.NumPad1)
            {
                cgun = 0;
                skinturn();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                cgun = 1;
                skinturn();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                cgun = 2;
                skinturn();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                cgun = 3;
                skinturn();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                cgun = 4;
                skinturn();
            }
            if (e.KeyCode == Keys.NumPad0 && !reloading)
            {
                autoreload();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                cantdie = !cantdie;
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                gun[cgun].inammo += 15;
            }
            #endregion
            if (e.KeyCode == Keys.Space && gameOver == false && canshoot && !reloading)
            {
                if (gun[cgun].ammo > 0)
                {
                    gun[cgun].ammo--;
                    for (int i = 0; i < gun[cgun].power; i++)
                    {
                        ShootBullet(facing);
                    }
                    if (gun[cgun].cooldown != 0)
                    {
                        Shootcd();
                    }
                    ammostat();
                    if (gun[cgun].ammo < 1 && gun[cgun].inammo == 0)
                    {
                        DropAmmo();
                    }
                }
                else
                {
                    Reloading();
                }

            }
            if (e.KeyCode == Keys.R && canshoot && gun[cgun].inammo > 0 && gun[cgun].ammo != gun[cgun].magazine)
            {
                Reloading();
            }







            if (e.KeyCode == Keys.F && gun[cgun].ammo + gun[cgun].inammo != 0 && cleared) //SZOBA MOZGÁS
            {
                if (player.Top < 10 && room == 0 && false) // 1-be
                {
                    int inf = player.Left;
                    room = 1;
                    RoomRender();
                    player.Top = 450;
                    dr.Top = 450;
                    player.Left = inf;
                    dr.Left = inf;

                    foreach (PictureBox i in enemylist)
                    {
                        this.Controls.Remove(i);
                    }
                }
                else if (player.Bounds.IntersectsWith(door.Bounds))
                {
                    if (room == 0)
                    {
                        room = -1;
                        RoomRender();
                    }
                    else if (room == -1)
                    {
                        room = 0;
                        RoomRender();
                        
                    }
                }
            }
        }

        private void MainTimer(object sender, EventArgs e)
        {
            #region alap
            MainMenuStrip.BringToFront();
            if (!started)
            {
                GameTimer.Stop();
                ready.Visible = true;
                ready.Enabled = true;
            }
            else
            {
                player.BringToFront();
                if (php < 30)
                {
                    hpbar.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    hpbar.BackColor = System.Drawing.Color.Green;
                }
                if (php > 1)
                {
                    if (cantdie)
                    {
                        hpl.Text = "Health: INF";
                    }
                    else
                    {
                        hpl.Text = "Health: " + php.ToString();
                    }
                    if (php > 100)
                    {
                        hpbar.Value = 100;
                    }
                    else
                    {
                        hpbar.Value = php;
                    }
                }
                else
                {
                    wait.Stop();
                    gameOver = true;
                    GameTimer.Stop();
                }

                ammos();
                scorel.Text = "Score: " + score.ToString();
                coinl.Text = "Coin: " + coin.ToString();
                if (wavee == 100)
                {
                    wavecounterl.Text = "Win!:)";
                }
                else if (cw)
                {
                    wavecounterl.Text = "Own";
                }
                else
                {
                    wavecounterl.Text = (wavee + 1).ToString() + ". w";
                }
                if (wave[wavee].zombie + wave[wavee].shooter > 0)
                {
                    enemycounterl.Text = "Enemy: " + (wave[wavee].zombie + wave[wavee].shooter).ToString();
                }
                else
                {
                    enemycounterl.Text = "Cleared";
                }


                if (wave[wavee].zombie + wave[wavee].shooter <= 0 && room == 0)
                {
                    ready.Visible = true;
                    ready.Enabled = true;
                }
                else
                {
                    ready.Visible = false;
                    ready.Enabled = false;
                }


                testll.Text = player.Top.ToString();
                testl.Text = player.Left.ToString();

                if (testlabels)
                {
                    testl.Visible = true;
                    testll.Visible = true;
                    testlll.Visible = true;
                    tpb.Visible = true;
                }
                else
                {
                    testl.Visible = false;
                    testll.Visible = false;
                    testlll.Visible = false;
                }
                if (testbuttons)
                {
                    test.Visible = true;
                    testt.Visible = true;
                    test.Enabled = true;
                    testt.Enabled = true;
                    testtt.Enabled = true;
                    testtt.Visible = true;
                }
                else
                {
                    test.Visible = false;
                    testt.Visible = false;
                    test.Enabled = false;
                    testt.Enabled = false;
                    testtt.Enabled = false;
                    testtt.Visible = false;
                }
                if (testpb)
                {
                    tpb.Visible = true;
                }
                else
                {
                    tpb.Visible = false;
                }
                if (cantdie)
                {
                    php = 100;
                }
                #endregion alap
                //-------------------------------------------------------------------------------------------------------------------
                #region move
                if (goleft && player.Left > 0)
                {
                    dr.Left -= gun[cgun].movespeed;
                    walldetect();
                    if (walled)
                    {
                        dr.Left += gun[cgun].movespeed;
                    }
                    else
                    {
                        player.Left -= gun[cgun].movespeed;
                    }
                }
                if (goright && player.Left + player.Width < 1000)
                {
                    dr.Left += gun[cgun].movespeed;
                    walldetect();
                    if (walled)
                    {
                        dr.Left -= gun[cgun].movespeed;
                    }
                    else
                    {
                        player.Left += gun[cgun].movespeed;
                    }
                }
                if (goup && player.Top > 0)
                {
                    dr.Top -= gun[cgun].movespeed;
                    walldetect();
                    if (walled)
                    {
                        dr.Top += gun[cgun].movespeed;
                    }
                    else
                    {
                        player.Top -= gun[cgun].movespeed;
                    }
                }

                if (godown && player.Top + player.Height < 550)
                {
                    dr.Top += gun[cgun].movespeed;
                    walldetect();
                    if (walled)
                    {
                        dr.Top -= gun[cgun].movespeed;
                    }
                    else
                    {
                        player.Top += gun[cgun].movespeed;
                    }
                }
                #endregion
                //---------------------------------------------------------------------------------------------------------------------
                #region egyéb
                if (sg)
                {
                    if (facing == "up")
                    {
                        sgshot.Image = Properties.Resources.sgshot_up;
                        sgshot.Top = player.Top - sgshot.Height;
                        sgshot.Left = player.Left - (sgshot.Width - player.Width) / 2;
                    }
                    else if (facing == "right")
                    {
                        sgshot.Image = Properties.Resources.sgshot_right;
                        sgshot.Left = player.Left + sgshot.Width;
                        sgshot.Top = player.Top - (sgshot.Height - player.Height) / 2;
                    }
                    else if (facing == "down")
                    {
                        sgshot.Image = Properties.Resources.sgshot_down;
                        sgshot.Top = player.Top + sgshot.Height;
                        sgshot.Left = player.Left - (sgshot.Width - player.Width) / 2;
                    }
                    else if (facing == "left")
                    {
                        sgshot.Image = Properties.Resources.sgshot_left;
                        sgshot.Left = player.Left - sgshot.Width;
                        sgshot.Top = player.Top - (sgshot.Height - player.Height) / 2;
                    }
                } //shotgun shot
                if (false)
                {
                    int c = 0;
                    foreach (PictureBox i in enemylist)
                    {
                        c++;
                    }
                    if (c > wave[wavee].onmap)
                    {
                        bool done = false;
                        foreach (PictureBox i in enemylist)
                        {
                            if (!done)
                            {
                                this.Controls.Remove(i);
                                ((PictureBox)i).Dispose();
                                enemylist.Remove(((PictureBox)i));
                                done = true;
                            }
                        }
                    }
                }
                
                #endregion
                //---------------------------------------------------------------------------------------------------------------------
                #region érzékelések
                foreach (Control x in this.Controls)
                {

                    if (x is PictureBox && (string)x.Tag == "ammo")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            gun[cgun].inammo += rm.Next(gun[cgun].almin, gun[cgun].almax + 1);
                            ammostat();
                        }
                    } //ammo felszedés


                    if (x is PictureBox && (string)x.Tag == "enemy") //ZOMBIE
                    {

                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            php -= 1;
                        }
                        else
                        {
                            if (x.Left > player.Left)
                            {
                                x.Left -= enemyspeed;
                                ((PictureBox)x).Image = Properties.Resources.blue_left;
                            }
                            if (x.Left < player.Left)
                            {
                                x.Left += enemyspeed;
                                ((PictureBox)x).Image = Properties.Resources.blue_right;
                            }
                            if (x.Top > player.Top)
                            {
                                x.Top -= enemyspeed;
                                ((PictureBox)x).Image = Properties.Resources.blue_up;
                            }
                            if (x.Top < player.Top)
                            {
                                x.Top += enemyspeed;
                                ((PictureBox)x).Image = Properties.Resources.blue_down;
                            }
                        }

                    } //Zombie


                    if (x is PictureBox && (string)x.Tag == "shooter") //SHOOTER
                    {
                        string lmove = "up"; //last move;
                        bool shooted = false;
                        foreach (Control s in this.Controls)
                        {
                            if (x is PictureBox && (string)s.Tag == "Sbullet")
                            {
                                shooted = true;
                            }
                        }
                        int topdiff = player.Top - x.Top;
                        if (topdiff < 0)
                        {
                            topdiff = topdiff * -1;
                        }
                        int leftdiff = player.Left - x.Left;
                        if (leftdiff < 0)
                        {
                            leftdiff = leftdiff * -1;
                        }

                        if (leftdiff > topdiff)
                        {
                            if (x.Left < player.Left)
                            {
                                direction = "right";
                                ((PictureBox)x).Image = Properties.Resources.shooter_left;
                            }
                            else
                            {
                                direction = "left";
                                ((PictureBox)x).Image = Properties.Resources.shooter_right;
                            }
                        }
                        else
                        {
                            if (x.Top < player.Top)
                            {
                                direction = "down";
                                ((PictureBox)x).Image = Properties.Resources.shooter_down;
                            }
                            else
                            {
                                direction = "up";
                                ((PictureBox)x).Image = Properties.Resources.shooter_up;
                            }
                        }



                        if (topdiff < leftdiff) //top
                        {
                            if (leftdiff < 300)
                            {
                                if (player.Left > x.Left)
                                {
                                    x.Left -= shooterspeed;
                                    lmove = "left";
                                }
                                else
                                {
                                    x.Left += shooterspeed;
                                    lmove = "right";
                                }
                            }
                            else if (leftdiff > 600)
                            {
                                if (leftdiff > 800)
                                {
                                    if (player.Left > x.Left)
                                    {
                                        x.Left -= shooterspeed;
                                        lmove = "left";
                                    }
                                    else
                                    {
                                        x.Left += shooterspeed;
                                        lmove = "right";
                                    }
                                }
                                else
                                {
                                    if (player.Left > x.Left)
                                    {
                                        x.Left += shooterspeed;
                                        lmove = "right";
                                    }
                                    else
                                    {
                                        x.Left -= shooterspeed;
                                        lmove = "left";
                                    }
                                }
                            }
                            if (topdiff > 20)
                            {
                                if (player.Top > x.Top)
                                {
                                    x.Top += shooterspeed;
                                    lmove = "down";
                                }
                                else
                                {
                                    x.Top -= shooterspeed;
                                    lmove = "up";
                                }
                            }
                            else if (!shooted)
                            {
                                Bullet shoot = new Bullet();
                                shoot.direction = direction;
                                shoot.bulletLeft = x.Left + (x.Width / 2);
                                shoot.bulletTop = x.Top + (x.Height / 2);
                                shoot.makeSb(this);
                            }
                        }





                        else //left
                        {
                            if (topdiff < 200)
                            {
                                if (player.Top > x.Top)
                                {
                                    x.Top -= shooterspeed;
                                    lmove = "up";
                                }
                                else
                                {
                                    x.Top += shooterspeed;
                                    lmove = "down";
                                }
                            }
                            else if (topdiff > 400)
                            {
                                if (topdiff > 600)
                                {
                                    if (player.Top > x.Top)
                                    {
                                        x.Top -= shooterspeed;
                                        lmove = "up";
                                    }
                                    else
                                    {
                                        x.Top += shooterspeed;
                                        lmove = "down";
                                    }
                                }
                                else
                                {
                                    if (player.Top > x.Top)
                                    {
                                        x.Top += shooterspeed;
                                        lmove = "right";
                                    }
                                    else
                                    {
                                        x.Top -= shooterspeed;
                                        lmove = "left";
                                    }
                                }

                            }
                            if (leftdiff > 20)
                            {
                                if (player.Left > x.Left)
                                {
                                    x.Left += shooterspeed;
                                    lmove = "right";
                                }
                                else
                                {
                                    x.Left -= shooterspeed;
                                    lmove = "left";
                                }
                            }
                            else if (!shooted)
                            {
                                Bullet shoot = new Bullet();
                                shoot.direction = direction;
                                shoot.bulletLeft = x.Left + (x.Width / 2);
                                shoot.bulletTop = x.Top + (x.Height / 2);
                                shoot.makeSb(this);
                            }

                        }

                        if (true) //inmap ellenőrzés 
                        {
                            if (x.Top < 0)
                            {
                                x.Top += shooterspeed + 2;
                            }
                            else if (x.Top > 450)
                            {
                                x.Top -= shooterspeed + 2;
                            }
                            else if (x.Left < 0)
                            {
                                x.Left += shooterspeed + 2;
                            }
                            else if (x.Left > 920)
                            {
                                x.Left -= shooterspeed + 2;
                            }
                        } //inmap ellenőrzés
                    } //Shooter


                    if ((string)x.Tag == "Sbullet")
                    {
                        if (x.Bounds.IntersectsWith(player.Bounds))
                        {
                            php -= 5;
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                        }
                    } //shooter lelő

                    if (cgun == 2)
                    {
                        if (x is PictureBox && (string)x.Tag == "enemy" && sg == true)
                        {
                            if (x.Bounds.IntersectsWith(sgshot.Bounds))
                            {
                                score++;
                                coin++;
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                enemylist.Remove(((PictureBox)x));
                                wave[wavee].zombie -= 1;
                                EnemySpawn();
                            }
                        }
                        if (x is PictureBox && (string)x.Tag == "shooter" && sg == true)
                        {
                            if (x.Bounds.IntersectsWith(sgshot.Bounds))
                            {
                                score++;
                                coin += 5;
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                enemylist.Remove(((PictureBox)x));
                                wave[wavee].shooter -= 1;
                                EnemySpawn();
                            }
                        }
                    } //shotgun


                    foreach (Control j in this.Controls)
                    {
                        if (cgun != 2)
                        {
                            if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "enemy")
                            {
                                if (x.Bounds.IntersectsWith(j.Bounds))
                                {
                                    idd = rm.Next(1, gun[cgun].killluck + 1);
                                    if (idd == 1)
                                    {
                                        score++;
                                        coin++;
                                        if (!gun[cgun].piercing)
                                        {
                                            this.Controls.Remove(j);
                                            ((PictureBox)j).Dispose();
                                        }
                                        if (true)
                                        {
                                            int help = rm.Next(1,6);
                                            int hpp = 0;
                                            if (help == 1 || help == 2)
                                            {
                                                hpp = gun[cgun].lifesteal;
                                            }
                                            else if (help == 3)
                                            {
                                                hpp = 0;
                                            }
                                            else if (help == 4 || help == 5)
                                            {
                                                hpp = gun[cgun].lifesteal * 2;
                                            }
                                            if (php + hpp > 100)
                                            {
                                                php = 100;
                                            }
                                            else
                                            {
                                                php += hpp;
                                            }
                                            testlll.Text = hpp.ToString();
                                        }
                                        this.Controls.Remove(x);
                                        ((PictureBox)x).Dispose();
                                        enemylist.Remove(((PictureBox)x));
                                        wave[wavee].zombie -= 1;
                                        EnemySpawn();
                                    }
                                    else
                                    {
                                        this.Controls.Remove(j);
                                        ((PictureBox)j).Dispose();
                                    }
                                }
                            }



                            else if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "shooter")
                            {
                                if (x.Bounds.IntersectsWith(j.Bounds))
                                {
                                    idd = rm.Next(1, gun[cgun].killluck + 1);
                                    if (idd == 1)
                                    {
                                        score++;
                                        coin += 5;
                                        if (!gun[cgun].piercing)
                                        {
                                            this.Controls.Remove(j);
                                            ((PictureBox)j).Dispose();
                                        }
                                        if (true)
                                        {
                                            int help = rm.Next(1, 4);
                                            int hpp = 0;
                                            if (help == 1 || help == 2)
                                            {
                                                hpp = gun[cgun].lifesteal;
                                            }
                                            else if (help == 3)
                                            {
                                                hpp = 0;
                                            }
                                            else if (help == 4)
                                            {
                                                hpp = gun[cgun].lifesteal * 2;
                                            }
                                            hpp = hpp * 2;
                                            if (php + hpp > 100)
                                            {
                                                php = 100;
                                            }
                                            else
                                            {
                                                php += 1;
                                            }
                                        }
                                        this.Controls.Remove(x);
                                        ((PictureBox)x).Dispose();
                                        enemylist.Remove(((PictureBox)x));
                                        wave[wavee].shooter -= 1;
                                        EnemySpawn();
                                    }
                                    else
                                    {
                                        this.Controls.Remove(j);
                                        ((PictureBox)j).Dispose();
                                    }
                                }
                            }
                        }
                    } // lövés eltalálja a zombiet, shootert
                }
                #endregion
                //----------------------------------------------------------------------------------------------------------------
                #region shop
                if (room == -1) //Shop
                {
                    if (player.Bounds.IntersectsWith(shopopener.Bounds))
                    {
                        shop.Image = Properties.Resources.Chestopened;
                        shoppistol.Visible = true;
                        shopgoodpistol.Visible = true;
                        shopmedkit.Visible = true;
                        shopammo.Visible = true;
                        shopshotgun.Visible = true;
                        shopsniper.Visible = true;
                        shopsmg.Visible = true;
                    }
                    else
                    {
                        shop.Image = Properties.Resources.chest;
                        shoppistol.Visible = false;
                        shopgoodpistol.Visible = false;
                        shopmedkit.Visible = false;
                        shopammo.Visible = false;
                        shopshotgun.Visible = false;
                        shopsniper.Visible = false;
                        shopsmg.Visible = false;
                    }
                }
                #endregion
            }
        }
        private void ammostat()
        {
            if (gun[cgun].ammo <= 0)
            {
                if (gun[cgun].inammo == 0)
                {
                    cdl.ForeColor = System.Drawing.Color.Red;
                    cdl.Text = "Out of ammo";
                }
                else
                {
                    cdl.ForeColor = System.Drawing.Color.Yellow;
                    cdl.Text = "Need to reload";
                }
            }
            else if (gun[cgun].ammo > 0)
            {
                cdl.Text = "Ready";
                cdl.ForeColor = System.Drawing.Color.Lime;
            }
        }
        private void ammos()
        {
            if (gun[cgun].ammo > gun[cgun].magazine)
            {
                gun[cgun].inammo += gun[cgun].ammo - gun[cgun].magazine;
                gun[cgun].ammo = gun[cgun].magazine;
            }
            ammol.Text = "Ammo: " + gun[cgun].ammo.ToString() + " " + gun[cgun].inammo.ToString();
        }
        private void Reloading()
        {
            if (canshoot && gun[cgun].inammo > 0 && gun[cgun].ammo != gun[cgun].magazine)
            {
                reloading = true;
                wtime = gun[cgun].reloadingtime;
                wait.Start();
            }

        }
        private void Shootcd()
        {
            if (gun[cgun].ammo > 0 && gameOver == false && canshoot && !reloading)
            {
                reloading = false;
                wtime = gun[cgun].cooldown;
                wait.Start();
            }
        }
        private void waiting_Tick(object sender, EventArgs e)
        {
            int test;
            if (reloading)
            {
                if (gun[cgun].ammo != gun[cgun].magazine)
                {
                    wtime -= 0.1f;
                    cdl.ForeColor = System.Drawing.Color.LightGreen;
                    cdl.Text = "Reloading... " + wtime.ToString().Substring(0, 3);
                    if (wtime <= 0)
                    {
                        wait.Stop();
                        reloading = false;
                        canshoot = true;
                        cdl.ForeColor = System.Drawing.Color.Lime;
                        cdl.Text = "Ready";
                        if (gun[cgun].inammo > gun[cgun].magazine - gun[cgun].ammo)
                        {
                            gun[cgun].inammo -= gun[cgun].magazine - gun[cgun].ammo;
                            gun[cgun].ammo = gun[cgun].magazine;
                        }
                        else
                        {
                            gun[cgun].ammo += gun[cgun].inammo;
                            gun[cgun].inammo = 0;
                        }
                    }

                }
            }
            else if (!reloading)//shoot cd
            {
                canshoot = false;
                wtime -= 0.1f;
                cdl.Text = wtime.ToString().Substring(0, 3);
                cdl.ForeColor = System.Drawing.Color.LightGreen;
                if (wtime <= 0)
                {
                    wait.Stop();
                    wtime = gun[cgun].cooldown;
                    canshoot = true;
                    ammostat();
                }
            }
        } //reload, shoot cooldown
        private void autoreload()
        {
            if (gun[cgun].ammo != gun[cgun].magazine || gun[cgun].ammo > gun[cgun].magazine)
            {
                if (gun[cgun].inammo > gun[cgun].magazine - gun[cgun].ammo)
                {
                    gun[cgun].inammo -= gun[cgun].magazine - gun[cgun].ammo;
                    gun[cgun].ammo = gun[cgun].magazine;
                }
                else
                {
                    gun[cgun].ammo += gun[cgun].inammo;
                    gun[cgun].inammo = 0;
                }
            }
        }
        private void walldetect()
        {
            bool done = false;
            foreach (PictureBox x in walllist)
            {
                if (dr.Bounds.IntersectsWith(x.Bounds))
                {

                    walled = true;
                    done = true;
                }
                else
                {
                    if (!done)
                    {
                        walled = false;
                    }
                }
            }
        }

        private void RoomRender()
        {
            foreach (Control x in Controls)
            {
                if (x is PictureBox)
                {
                    for (int i = -1; i < roomax - 1; i++)
                    {
                        if (room == i)
                        {
                            if (x is PictureBox && (string)x.Tag == i.ToString())
                            {
                                x.Enabled = true;
                            }
                            else
                            {
                                x.Enabled = false;
                            }
                        }
                    }
                }
            }
            #region rooms
            if (room == 0)
            {
                this.BackColor = System.Drawing.Color.DarkGray;
                door.Left = 990;
                player.Left = 950;
                dr.Left = 950;
                ready.Visible = true;
                EnemySpawn();
            }
            else if (room == -1)
            {
                foreach (PictureBox i in enemylist)
                {
                    this.Controls.Remove(i);
                }
                enemylist.Clear();
                this.BackColor = System.Drawing.Color.DimGray;
                door.Left = -70;
                player.Left = 0;
                dr.Left = 0;
                ready.Visible = false;
            }
            else if (room == 1)
            {
                foreach (PictureBox i in enemylist)
                {
                    this.Controls.Remove(i);
                }
                this.BackColor = System.Drawing.Color.Black;
                player.Top = 470;
                door.Left = -200;
                dr.Top = 470;
            }
            #endregion

            #region tárgyak
            if (shop.Enabled == true)
            {
                shop.Top = 0;
            }
            else
            {
                shop.Top = -300;
            }
            if (shopopener.Enabled == true)
            {
                shopopener.Top = 0;
            }
            else
            {
                shopopener.Top = -300;
            }
            if (river.Enabled == true)
            {
                river.Top = 0;
            }
            else
            {
                river.Top = -1000;
            }
            if (ready.Enabled == true)
            {
                ready.Visible = true;
            }
            else
            {
                ready.Visible = false;
            }

            #endregion tárgyak
        }

        private void sgtimer_Tick(object sender, EventArgs e)
        {
            sgtime += 0.1f;
            if (sgtime >= 0.2f)
            {
                sgtimer.Stop();
                sg = false;
                sgshot.Visible = false;
                sgtime = 0;
                sg = false;
            }
        }

        private void ShootBullet(string direction)
        {
            if (cgun == 2)
            {
                if (facing == "up")
                {
                    sgshot.Image = Properties.Resources.sgshot_up;
                    sgshot.Top = player.Top - sgshot.Height;
                    sgshot.Left = player.Left;
                }
                else if (facing == "right")
                {
                    sgshot.Image = Properties.Resources.sgshot_right;
                    sgshot.Left = player.Left + sgshot.Width;
                    sgshot.Top = player.Top;
                }
                else if (facing == "down")
                {
                    sgshot.Image = Properties.Resources.sgshot_down;
                    sgshot.Top = player.Top + sgshot.Height;
                    sgshot.Left = player.Left;
                }
                else if (facing == "left")
                {
                    sgshot.Image = Properties.Resources.sgshot_left;
                    sgshot.Left = player.Left - sgshot.Width;
                    sgshot.Top = player.Top;
                }
                sgshot.Visible = true;
                sg = true;
                sgtimer.Start();
            }
            else
            {
                Bullet shoot = new Bullet();
                shoot.direction = direction;
                if (cgun != 3)
                {
                    shoot.bulletLeft = player.Left + (player.Width / 2);
                    shoot.bulletTop = player.Top + (player.Height / 2);
                }
                else
                {
                    if (direction == "up")
                    {
                        shoot.bulletLeft = player.Left + (player.Width / 2);
                        shoot.bulletTop = player.Top;
                    }
                    else if (direction == "right")
                    {
                        shoot.bulletLeft = player.Left + player.Width;
                        shoot.bulletTop = player.Top + (player.Height / 2);
                    }
                    else if (direction == "down")
                    {
                        shoot.bulletLeft = player.Left + (player.Width / 2);
                        shoot.bulletTop = player.Top + player.Height;
                    }
                    else if (direction == "left")
                    {
                        shoot.bulletLeft = player.Left; ;
                        shoot.bulletTop = player.Top + (player.Height / 2);
                    }
                }

                if (cgun == 1)
                {
                    shoot.makeRedb(this);
                }
                else if (cgun == 0)
                {
                    shoot.makeb(this);
                }
                else if (cgun == 3)
                {
                    shoot.makeSniperb(this);
                }
                else
                {
                    shoot.makeb(this);
                }
            }
        }
        private void ready_Click(object sender, EventArgs e)
        {
            if (started)
            {
                if (cw)
                {
                    ready.Enabled = true;
                    cw = false;
                    wavee = 101;
                    EnemySpawn();
                }
                else
                {
                    if (changewavestorage == -1)
                    {
                        wavee += 1;
                        ready.Enabled = true;
                        EnemySpawn();
                    }
                    else
                    {
                        wavee = changewavestorage;
                        changewavestorage = -1;
                        ready.Enabled = true;
                        EnemySpawn();
                    }
                }
            }
            else
            {
                RestartGame();
                started = true;
                GameTimer.Start();
                gameOver = false;
            }
            
        }
        private void DropAmmo()
        {
            // this function will make a ammo image for this game

            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.bullets;
            ammo.SizeMode = PictureBoxSizeMode.Zoom;
            ammo.Width = ammo.Height;
            ammo.Left = rm.Next(0, 920);
            ammo.Top = rm.Next(0, 500);
            foreach (PictureBox x in walllist)
            {
                if (ammo.Bounds.IntersectsWith(x.Bounds))
                {
                    ammo.Dispose();
                    DropAmmo();
                }
                else
                {
                    ammo.Tag = "ammo";
                    this.Controls.Add(ammo);
                    ammo.BringToFront();
                    player.BringToFront();
                }
            }
        }

        #region enemy
        private void EnemySpawn()
        {
            bool can = true;
            int z = 0;
            int s = 0;
            int c = 0;
            int f = 0;
            foreach (PictureBox i in enemylist)
            {
                c++;
            }
            if (!peace)
            {
                if (wave[wavee].zombie + wave[wavee].shooter > 1)
                {
                    cleared = false;
                    can = true;
                    z = 0;
                    s = 0;
                    c = 0;
                    f = 0;
                    foreach (PictureBox i in enemylist)
                    {
                        c++;
                    }
                    if (c == 0)
                    {
                        f = wave[wavee].onmap;
                    }
                    else
                    {
                        f = 1;
                    }
                    for (int i = 0; i < f; i++)
                    {
                        z = 0;
                        s = 0;
                        foreach (PictureBox j in enemylist)
                        {
                            if ((string)j.Tag == "zombie")
                            {
                                z++;
                            }
                            else if ((string)j.Tag == "shooter")
                            {
                                s++;
                            }
                        }
                        if (z + s + 1 <= wave[wavee].onmap)
                        {
                            int rand = rm.Next(1, 3);
                            if (rand == 1)
                            {
                                if (wave[wavee].zombie - z > 0)
                                {
                                    zombieSpawn();
                                }
                                else
                                {
                                    can = false;
                                }

                            }
                            else if (rand == 2)
                            {
                                if (wave[wavee].shooter - s > 0)
                                {
                                    shooterSpawn();
                                }
                                else
                                {
                                    can = false;
                                }
                            }

                            if (!can)
                            {
                                if (wave[wavee].shooter - s > 0)
                                {
                                    shooterSpawn();
                                }
                                else if (wave[wavee].zombie - z > 0)
                                {
                                    zombieSpawn();
                                }
                            }
                        }
                    }
                }
                else
                {
                    cleared = true;
                }
            }

        }
        private void zombieSpawn()
        {
            int id = rm.Next(1, 3);
            PictureBox enemy = new PictureBox();
            enemy.Height = 70;
            enemy.BackColor = System.Drawing.Color.Transparent;
            enemy.Width = 70;
            enemy.Tag = "enemy";
            enemy.Image = Properties.Resources.blue_down;
            if (id == 1) //up
            {
                enemy.Left = rm.Next(0, 900);
                enemy.Top = 0 - enemy.Height + 1;
            }
            else if (id == 2) //down
            {
                enemy.Left = rm.Next(0, 900);
                enemy.Top = 475 + enemy.Height;
            }
            else if (id == 3) //left
            {
                enemy.Left = 0 - enemy.Width;
                enemy.Top = rm.Next(0, 500);
            }

            enemy.SizeMode = PictureBoxSizeMode.Zoom;
            enemylist.Add(enemy);
            this.Controls.Add(enemy);
            player.BringToFront();

        }
        private void shooterSpawn()
        {
            int id = rm.Next(1, 3);
            PictureBox shooter = new PictureBox();
            shooter.Height = 90;
            shooter.Width = 90;
            shooter.BackColor = System.Drawing.Color.Transparent;
            shooter.Tag = "shooter";
            shooter.Image = Properties.Resources.shooter_down;
            if (id == 1) //up
            {
                shooter.Left = rm.Next(0, 900);
                shooter.Top = 0 - shooter.Height + 1;
            }
            else if (id == 2) //down
            {
                shooter.Left = rm.Next(0, 900);
                shooter.Top = 475 + shooter.Height;
            }
            else if (id == 3) //left
            {
                shooter.Left = 0 - shooter.Width;
                shooter.Top = rm.Next(0, 500);
            }

            shooter.SizeMode = PictureBoxSizeMode.StretchImage;
            enemylist.Add(shooter);
            this.Controls.Add(shooter);
            player.BringToFront();
        }
        #endregion

        #region shop items
        private void shoppistol_Click(object sender, EventArgs e)
        {
            cgun = 0;
            skinturn();
        }

        private void shopgoodpistol_Click(object sender, EventArgs e)
        {
            cgun = 1;
            skinturn();
        }

        private void shopmedkit_Click(object sender, EventArgs e)
        {
            db = Convert.ToInt32(Interaction.InputBox
           ("How many health do you want to heal? 1 coin / 5 health", "Shop - Ammo", "", -1, -1));
            db = (db / 5) * 5;
            if (coin >= db / 5)
            {
                if (php + db <= 100)
                {
                    php += db;

                }
                else
                {
                    php = 100;
                }
                coin -= db / 5;
            }
            else
            {
                MessageBox.Show("You can't afford that", "You need more coin");
            }
        }

        private void shopammo_Click(object sender, EventArgs e)
        {
            int id = gun[cgun].price;
            db = Convert.ToInt32(Interaction.InputBox
            ("How many 10pcs pack do you want? \n10 ammo = " + id.ToString() + " coin", "Shop - Ammo", "", -1, -1));
            if (coin >= db * gun[cgun].price)
            {
                coin -= db * gun[cgun].price;
                gun[cgun].inammo += db * 10;
            }
            else
            {
                MessageBox.Show("You can't afford that", "You need more coin");
            }
        }

        private void shopshotgun_Click(object sender, EventArgs e)
        {
            cgun = 2;
            skinturn();
        }



        private void shopsniper_Click(object sender, EventArgs e)
        {
            cgun = 3;
            skinturn();
        }

        private void shopsmg_Click(object sender, EventArgs e)
        {
            cgun = 4;
            skinturn();
        }

        #endregion

        #region not important
        private void player_Click(object sender, EventArgs e)
        {
            EnemySpawn();
            php++;
            GameTimer.Stop();
        }

        private void portald_DoubleClick(object sender, EventArgs e)
        {
            coinl.Visible = false;
        }
        #endregion

        #region test buttons
        private void test_Click(object sender, EventArgs e)
        {
            shooterSpawn();
        }
        private void testt_Click(object sender, EventArgs e)
        {
            tpb.Top = Convert.ToInt32(Interaction.InputBox
            ("Top?", "Test", tpb.Top.ToString(), -1, -1));
            tpb.Left = Convert.ToInt32(Interaction.InputBox
            ("Left?", "Test", tpb.Left.ToString(), -1, -1));
        }
        #endregion

        #region menu strip
        private void testLabelSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testlabels = !testlabels;
        }

        private void waveSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cleared)
            {
                changewavestorage = Convert.ToInt32(Interaction.InputBox
            ("Which wave? 1-100", "Wave select ", "0", -1, -1));
                changewavestorage--;
            }
        }

        private void customWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(started){
                wave[101].wn = 101;
                wave[101].zombie = Convert.ToInt32(Interaction.InputBox
            ("How many zombie?", "Custom wave", "", -1, -1));
                wave[101].shooter = Convert.ToInt32(Interaction.InputBox
            ("How many shooter", "Custom wave", "", -1, -1));
                wave[101].onmap = Convert.ToInt32(Interaction.InputBox
            ("Max enemy on map?", "Custom wave ", "", -1, -1));
                cw = true;
            }
        }
        private void testtt_Click(object sender, EventArgs e)
        {
            RoomRender();
        }

        private void testButtonSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testbuttons = !testbuttons;
        }

        private void testPBSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testpb = !testpb;
        }

        #endregion

        #region intro
        private void startgame_Click_1(object sender, EventArgs e)
        {
            bg.Top = 1000;
            startgame.Top = 1000;
            exitgame.Top = 1000;
            player.Visible = true;
        }

        private void exitgame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitgame_MouseEnter(object sender, EventArgs e)
        {
            exitgame.BackColor = System.Drawing.Color.MediumPurple;
        }

        private void exitgame_DragLeave(object sender, EventArgs e)
        {
            exitgame.BackColor = System.Drawing.Color.Gainsboro;
        }

       
        private void startgame_MouseHover(object sender, EventArgs e)
        {
            startgame.BackColor = System.Drawing.Color.MediumPurple;
        }

        private void startgame_MouseLeave(object sender, EventArgs e)
        {
            startgame.BackColor = System.Drawing.Color.Gainsboro;
        }
        #endregion

        private void RestartGame()
        {
            GameTimer.Stop();
            setwavesdata();

            cgun = 0;
            wavee = 0;

            player.Image = Properties.Resources.bpistol_up;

            foreach (PictureBox i in enemylist)
            {
                this.Controls.Remove(i);
            }

            enemylist.Clear();

            EnemySpawn();

            goup = false;
            godown = false;
            goleft = false;
            goright = false;
            gameOver = false;
            facing = "up";
            coin = 0;

            php = 100;
            score = 0;

            for (int i = 0; i < 5; i++)
            {
                gun[i].inammo = gun[i].almax;
            }
            autoreload();


            reloading = false;
            canshoot = true;
            ammostat();

            skinturn();
            ready.Visible = true;
            ready.Enabled = true;
            started = false;

        }

    }
}
