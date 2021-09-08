
namespace Project_Tax
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hpbar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.hpl = new System.Windows.Forms.Label();
            this.scorel = new System.Windows.Forms.Label();
            this.ammol = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testLabelSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testButtonSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testPBSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customWaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinl = new System.Windows.Forms.Label();
            this.wait = new System.Windows.Forms.Timer(this.components);
            this.cdl = new System.Windows.Forms.Label();
            this.sgtimer = new System.Windows.Forms.Timer(this.components);
            this.enemycounterl = new System.Windows.Forms.Label();
            this.wavecounterl = new System.Windows.Forms.Label();
            this.ready = new System.Windows.Forms.Label();
            this.testl = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.PictureBox();
            this.wavecounter = new System.Windows.Forms.PictureBox();
            this.enemycounter = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shopsmg = new System.Windows.Forms.PictureBox();
            this.shopsniper = new System.Windows.Forms.PictureBox();
            this.sgshot = new System.Windows.Forms.PictureBox();
            this.shopshotgun = new System.Windows.Forms.PictureBox();
            this.shopammo = new System.Windows.Forms.PictureBox();
            this.shopmedkit = new System.Windows.Forms.PictureBox();
            this.shopgoodpistol = new System.Windows.Forms.PictureBox();
            this.shoppistol = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.dr = new System.Windows.Forms.PictureBox();
            this.shop = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.river = new System.Windows.Forms.PictureBox();
            this.shopopener = new System.Windows.Forms.PictureBox();
            this.portald = new System.Windows.Forms.PictureBox();
            this.testll = new System.Windows.Forms.Label();
            this.testt = new System.Windows.Forms.PictureBox();
            this.tpb = new System.Windows.Forms.PictureBox();
            this.testlll = new System.Windows.Forms.Label();
            this.testtt = new System.Windows.Forms.PictureBox();
            this.bg = new System.Windows.Forms.PictureBox();
            this.startgame = new System.Windows.Forms.Label();
            this.exitgame = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavecounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsniper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopshotgun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopammo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopmedkit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopgoodpistol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppistol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.river)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopopener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portald)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            this.SuspendLayout();
            // 
            // hpbar
            // 
            this.hpbar.BackColor = System.Drawing.Color.Lime;
            this.hpbar.Location = new System.Drawing.Point(1126, 704);
            this.hpbar.Name = "hpbar";
            this.hpbar.Size = new System.Drawing.Size(194, 37);
            this.hpbar.TabIndex = 0;
            this.hpbar.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimer);
            // 
            // hpl
            // 
            this.hpl.AutoSize = true;
            this.hpl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hpl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpl.ForeColor = System.Drawing.Color.White;
            this.hpl.Location = new System.Drawing.Point(959, 709);
            this.hpl.Name = "hpl";
            this.hpl.Size = new System.Drawing.Size(111, 32);
            this.hpl.TabIndex = 2;
            this.hpl.Text = "Health: ";
            // 
            // scorel
            // 
            this.scorel.AutoSize = true;
            this.scorel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.scorel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scorel.ForeColor = System.Drawing.Color.White;
            this.scorel.Location = new System.Drawing.Point(765, 709);
            this.scorel.Name = "scorel";
            this.scorel.Size = new System.Drawing.Size(95, 32);
            this.scorel.TabIndex = 6;
            this.scorel.Text = "Score:";
            // 
            // ammol
            // 
            this.ammol.AutoSize = true;
            this.ammol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ammol.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ammol.ForeColor = System.Drawing.Color.White;
            this.ammol.Location = new System.Drawing.Point(12, 709);
            this.ammol.Name = "ammol";
            this.ammol.Size = new System.Drawing.Size(113, 33);
            this.ammol.TabIndex = 7;
            this.ammol.Text = "Ammo:";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.waveSelectToolStripMenuItem,
            this.customWaveToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1332, 28);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            this.menu.Visible = false;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testLabelSHToolStripMenuItem,
            this.testButtonSHToolStripMenuItem,
            this.testPBSHToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // testLabelSHToolStripMenuItem
            // 
            this.testLabelSHToolStripMenuItem.Name = "testLabelSHToolStripMenuItem";
            this.testLabelSHToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.testLabelSHToolStripMenuItem.Text = "Test Labels S/H";
            this.testLabelSHToolStripMenuItem.Click += new System.EventHandler(this.testLabelSHToolStripMenuItem_Click);
            // 
            // testButtonSHToolStripMenuItem
            // 
            this.testButtonSHToolStripMenuItem.Name = "testButtonSHToolStripMenuItem";
            this.testButtonSHToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.testButtonSHToolStripMenuItem.Text = "Test Buttons S/H";
            this.testButtonSHToolStripMenuItem.Click += new System.EventHandler(this.testButtonSHToolStripMenuItem_Click);
            // 
            // testPBSHToolStripMenuItem
            // 
            this.testPBSHToolStripMenuItem.Name = "testPBSHToolStripMenuItem";
            this.testPBSHToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.testPBSHToolStripMenuItem.Text = "Test PB S/H";
            this.testPBSHToolStripMenuItem.Click += new System.EventHandler(this.testPBSHToolStripMenuItem_Click);
            // 
            // waveSelectToolStripMenuItem
            // 
            this.waveSelectToolStripMenuItem.Name = "waveSelectToolStripMenuItem";
            this.waveSelectToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.waveSelectToolStripMenuItem.Text = "Wave select";
            this.waveSelectToolStripMenuItem.Click += new System.EventHandler(this.waveSelectToolStripMenuItem_Click);
            // 
            // customWaveToolStripMenuItem
            // 
            this.customWaveToolStripMenuItem.Name = "customWaveToolStripMenuItem";
            this.customWaveToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.customWaveToolStripMenuItem.Text = "Custom wave";
            this.customWaveToolStripMenuItem.Click += new System.EventHandler(this.customWaveToolStripMenuItem_Click);
            // 
            // coinl
            // 
            this.coinl.AutoSize = true;
            this.coinl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coinl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinl.ForeColor = System.Drawing.Color.White;
            this.coinl.Location = new System.Drawing.Point(563, 710);
            this.coinl.Name = "coinl";
            this.coinl.Size = new System.Drawing.Size(87, 33);
            this.coinl.TabIndex = 10;
            this.coinl.Text = "Coin:";
            // 
            // wait
            // 
            this.wait.Tick += new System.EventHandler(this.waiting_Tick);
            // 
            // cdl
            // 
            this.cdl.AutoSize = true;
            this.cdl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cdl.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cdl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cdl.Location = new System.Drawing.Point(237, 705);
            this.cdl.Name = "cdl";
            this.cdl.Size = new System.Drawing.Size(0, 40);
            this.cdl.TabIndex = 15;
            // 
            // sgtimer
            // 
            this.sgtimer.Tick += new System.EventHandler(this.sgtimer_Tick);
            // 
            // enemycounterl
            // 
            this.enemycounterl.AutoSize = true;
            this.enemycounterl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enemycounterl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemycounterl.ForeColor = System.Drawing.Color.White;
            this.enemycounterl.Location = new System.Drawing.Point(12, 16);
            this.enemycounterl.Name = "enemycounterl";
            this.enemycounterl.Size = new System.Drawing.Size(127, 33);
            this.enemycounterl.TabIndex = 26;
            this.enemycounterl.Text = "Enemy: ";
            // 
            // wavecounterl
            // 
            this.wavecounterl.AutoSize = true;
            this.wavecounterl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wavecounterl.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wavecounterl.ForeColor = System.Drawing.Color.White;
            this.wavecounterl.Location = new System.Drawing.Point(1215, 10);
            this.wavecounterl.Name = "wavecounterl";
            this.wavecounterl.Size = new System.Drawing.Size(35, 38);
            this.wavecounterl.TabIndex = 28;
            this.wavecounterl.Text = "0";
            this.wavecounterl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ready
            // 
            this.ready.AutoSize = true;
            this.ready.BackColor = System.Drawing.Color.Lime;
            this.ready.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ready.ForeColor = System.Drawing.Color.White;
            this.ready.Location = new System.Drawing.Point(1053, 9);
            this.ready.Name = "ready";
            this.ready.Padding = new System.Windows.Forms.Padding(10);
            this.ready.Size = new System.Drawing.Size(131, 53);
            this.ready.TabIndex = 37;
            this.ready.Tag = "0";
            this.ready.Text = "READY";
            this.ready.Click += new System.EventHandler(this.ready_Click);
            // 
            // testl
            // 
            this.testl.AutoSize = true;
            this.testl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testl.Location = new System.Drawing.Point(12, 382);
            this.testl.Name = "testl";
            this.testl.Size = new System.Drawing.Size(55, 25);
            this.testl.TabIndex = 39;
            this.testl.Text = "Test";
            this.testl.Visible = false;
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.test.Location = new System.Drawing.Point(1284, 626);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(36, 46);
            this.test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.test.TabIndex = 38;
            this.test.TabStop = false;
            this.test.Tag = "0";
            this.test.Visible = false;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // wavecounter
            // 
            this.wavecounter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wavecounter.BackgroundImage = global::Project_Tax.Properties.Resources.bg_city;
            this.wavecounter.Location = new System.Drawing.Point(1200, 0);
            this.wavecounter.Name = "wavecounter";
            this.wavecounter.Size = new System.Drawing.Size(133, 64);
            this.wavecounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wavecounter.TabIndex = 27;
            this.wavecounter.TabStop = false;
            // 
            // enemycounter
            // 
            this.enemycounter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enemycounter.BackgroundImage = global::Project_Tax.Properties.Resources.bg_city;
            this.enemycounter.Location = new System.Drawing.Point(-1, 0);
            this.enemycounter.Name = "enemycounter";
            this.enemycounter.Size = new System.Drawing.Size(194, 64);
            this.enemycounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemycounter.TabIndex = 25;
            this.enemycounter.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImage = global::Project_Tax.Properties.Resources.bg_city;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 687);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1336, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // shopsmg
            // 
            this.shopsmg.BackColor = System.Drawing.Color.Transparent;
            this.shopsmg.Image = ((System.Drawing.Image)(resources.GetObject("shopsmg.Image")));
            this.shopsmg.Location = new System.Drawing.Point(1096, 359);
            this.shopsmg.Name = "shopsmg";
            this.shopsmg.Size = new System.Drawing.Size(130, 130);
            this.shopsmg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shopsmg.TabIndex = 24;
            this.shopsmg.TabStop = false;
            this.shopsmg.Tag = "-1";
            this.shopsmg.Visible = false;
            this.shopsmg.Click += new System.EventHandler(this.shopsmg_Click);
            // 
            // shopsniper
            // 
            this.shopsniper.BackColor = System.Drawing.Color.Transparent;
            this.shopsniper.Image = ((System.Drawing.Image)(resources.GetObject("shopsniper.Image")));
            this.shopsniper.Location = new System.Drawing.Point(940, 516);
            this.shopsniper.Name = "shopsniper";
            this.shopsniper.Size = new System.Drawing.Size(286, 121);
            this.shopsniper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shopsniper.TabIndex = 23;
            this.shopsniper.TabStop = false;
            this.shopsniper.Tag = "-1";
            this.shopsniper.Visible = false;
            this.shopsniper.Click += new System.EventHandler(this.shopsniper_Click);
            // 
            // sgshot
            // 
            this.sgshot.BackColor = System.Drawing.Color.Transparent;
            this.sgshot.Image = global::Project_Tax.Properties.Resources.sgshot_up;
            this.sgshot.Location = new System.Drawing.Point(746, 311);
            this.sgshot.Name = "sgshot";
            this.sgshot.Size = new System.Drawing.Size(140, 140);
            this.sgshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sgshot.TabIndex = 22;
            this.sgshot.TabStop = false;
            this.sgshot.Visible = false;
            // 
            // shopshotgun
            // 
            this.shopshotgun.BackColor = System.Drawing.Color.Transparent;
            this.shopshotgun.Image = ((System.Drawing.Image)(resources.GetObject("shopshotgun.Image")));
            this.shopshotgun.Location = new System.Drawing.Point(940, 359);
            this.shopshotgun.Name = "shopshotgun";
            this.shopshotgun.Size = new System.Drawing.Size(130, 130);
            this.shopshotgun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shopshotgun.TabIndex = 21;
            this.shopshotgun.TabStop = false;
            this.shopshotgun.Tag = "-1";
            this.shopshotgun.Visible = false;
            this.shopshotgun.Click += new System.EventHandler(this.shopshotgun_Click);
            // 
            // shopammo
            // 
            this.shopammo.BackColor = System.Drawing.Color.Transparent;
            this.shopammo.Image = ((System.Drawing.Image)(resources.GetObject("shopammo.Image")));
            this.shopammo.Location = new System.Drawing.Point(1096, 50);
            this.shopammo.Name = "shopammo";
            this.shopammo.Size = new System.Drawing.Size(130, 130);
            this.shopammo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shopammo.TabIndex = 20;
            this.shopammo.TabStop = false;
            this.shopammo.Tag = "-1";
            this.shopammo.Visible = false;
            this.shopammo.Click += new System.EventHandler(this.shopammo_Click);
            // 
            // shopmedkit
            // 
            this.shopmedkit.BackColor = System.Drawing.Color.Transparent;
            this.shopmedkit.Image = ((System.Drawing.Image)(resources.GetObject("shopmedkit.Image")));
            this.shopmedkit.Location = new System.Drawing.Point(940, 50);
            this.shopmedkit.Name = "shopmedkit";
            this.shopmedkit.Size = new System.Drawing.Size(130, 130);
            this.shopmedkit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shopmedkit.TabIndex = 19;
            this.shopmedkit.TabStop = false;
            this.shopmedkit.Tag = "-1";
            this.shopmedkit.Visible = false;
            this.shopmedkit.Click += new System.EventHandler(this.shopmedkit_Click);
            // 
            // shopgoodpistol
            // 
            this.shopgoodpistol.BackColor = System.Drawing.Color.Transparent;
            this.shopgoodpistol.Image = ((System.Drawing.Image)(resources.GetObject("shopgoodpistol.Image")));
            this.shopgoodpistol.Location = new System.Drawing.Point(1096, 204);
            this.shopgoodpistol.Name = "shopgoodpistol";
            this.shopgoodpistol.Size = new System.Drawing.Size(130, 130);
            this.shopgoodpistol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shopgoodpistol.TabIndex = 17;
            this.shopgoodpistol.TabStop = false;
            this.shopgoodpistol.Tag = "-1";
            this.shopgoodpistol.Visible = false;
            this.shopgoodpistol.Click += new System.EventHandler(this.shopgoodpistol_Click);
            // 
            // shoppistol
            // 
            this.shoppistol.BackColor = System.Drawing.Color.Transparent;
            this.shoppistol.Image = ((System.Drawing.Image)(resources.GetObject("shoppistol.Image")));
            this.shoppistol.Location = new System.Drawing.Point(940, 204);
            this.shoppistol.Name = "shoppistol";
            this.shoppistol.Size = new System.Drawing.Size(130, 130);
            this.shoppistol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shoppistol.TabIndex = 16;
            this.shoppistol.TabStop = false;
            this.shoppistol.Tag = "-1";
            this.shoppistol.Visible = false;
            this.shoppistol.Click += new System.EventHandler(this.shoppistol_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Project_Tax.Properties.Resources.bpistol_up;
            this.player.Location = new System.Drawing.Point(1151, 326);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // dr
            // 
            this.dr.BackColor = System.Drawing.Color.Maroon;
            this.dr.Location = new System.Drawing.Point(1003, 326);
            this.dr.Name = "dr";
            this.dr.Size = new System.Drawing.Size(100, 100);
            this.dr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dr.TabIndex = 13;
            this.dr.TabStop = false;
            // 
            // shop
            // 
            this.shop.BackColor = System.Drawing.Color.Transparent;
            this.shop.Image = ((System.Drawing.Image)(resources.GetObject("shop.Image")));
            this.shop.Location = new System.Drawing.Point(228, -105);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(160, 101);
            this.shop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shop.TabIndex = 12;
            this.shop.TabStop = false;
            this.shop.Tag = "-1";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Maroon;
            this.door.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("door.BackgroundImage")));
            this.door.Image = ((System.Drawing.Image)(resources.GetObject("door.Image")));
            this.door.Location = new System.Drawing.Point(1313, 314);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(106, 112);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door.TabIndex = 9;
            this.door.TabStop = false;
            // 
            // river
            // 
            this.river.Image = ((System.Drawing.Image)(resources.GetObject("river.Image")));
            this.river.Location = new System.Drawing.Point(820, 1000);
            this.river.Name = "river";
            this.river.Size = new System.Drawing.Size(600, 711);
            this.river.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.river.TabIndex = 11;
            this.river.TabStop = false;
            this.river.Tag = "-1";
            // 
            // shopopener
            // 
            this.shopopener.BackColor = System.Drawing.Color.Transparent;
            this.shopopener.Location = new System.Drawing.Point(199, 0);
            this.shopopener.Name = "shopopener";
            this.shopopener.Size = new System.Drawing.Size(218, 143);
            this.shopopener.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shopopener.TabIndex = 18;
            this.shopopener.TabStop = false;
            this.shopopener.Tag = "-1";
            this.shopopener.Visible = false;
            // 
            // portald
            // 
            this.portald.BackColor = System.Drawing.Color.Transparent;
            this.portald.Location = new System.Drawing.Point(515, 0);
            this.portald.Name = "portald";
            this.portald.Size = new System.Drawing.Size(190, 49);
            this.portald.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.portald.TabIndex = 36;
            this.portald.TabStop = false;
            this.portald.Tag = "-1";
            this.portald.Visible = false;
            this.portald.DoubleClick += new System.EventHandler(this.portald_DoubleClick);
            // 
            // testll
            // 
            this.testll.AutoSize = true;
            this.testll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testll.Location = new System.Drawing.Point(693, 0);
            this.testll.Name = "testll";
            this.testll.Size = new System.Drawing.Size(55, 25);
            this.testll.TabIndex = 40;
            this.testll.Text = "Test";
            this.testll.Visible = false;
            // 
            // testt
            // 
            this.testt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.testt.Location = new System.Drawing.Point(1232, 626);
            this.testt.Name = "testt";
            this.testt.Size = new System.Drawing.Size(36, 46);
            this.testt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.testt.TabIndex = 41;
            this.testt.TabStop = false;
            this.testt.Tag = "0";
            this.testt.Visible = false;
            this.testt.Click += new System.EventHandler(this.testt_Click);
            // 
            // tpb
            // 
            this.tpb.BackColor = System.Drawing.Color.DodgerBlue;
            this.tpb.Location = new System.Drawing.Point(550, 434);
            this.tpb.Name = "tpb";
            this.tpb.Size = new System.Drawing.Size(100, 100);
            this.tpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tpb.TabIndex = 42;
            this.tpb.TabStop = false;
            this.tpb.Visible = false;
            // 
            // testlll
            // 
            this.testlll.AutoSize = true;
            this.testlll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testlll.Location = new System.Drawing.Point(661, 659);
            this.testlll.Name = "testlll";
            this.testlll.Size = new System.Drawing.Size(55, 25);
            this.testlll.TabIndex = 43;
            this.testlll.Text = "Test";
            this.testlll.Visible = false;
            // 
            // testtt
            // 
            this.testtt.BackColor = System.Drawing.Color.Blue;
            this.testtt.Location = new System.Drawing.Point(1179, 626);
            this.testtt.Name = "testtt";
            this.testtt.Size = new System.Drawing.Size(36, 46);
            this.testtt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.testtt.TabIndex = 44;
            this.testtt.TabStop = false;
            this.testtt.Tag = "0";
            this.testtt.Visible = false;
            this.testtt.Click += new System.EventHandler(this.testtt_Click);
            // 
            // bg
            // 
            this.bg.BackColor = System.Drawing.Color.White;
            this.bg.Image = ((System.Drawing.Image)(resources.GetObject("bg.Image")));
            this.bg.Location = new System.Drawing.Point(-1, 0);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(1336, 770);
            this.bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bg.TabIndex = 45;
            this.bg.TabStop = false;
            // 
            // startgame
            // 
            this.startgame.AutoSize = true;
            this.startgame.BackColor = System.Drawing.Color.Gainsboro;
            this.startgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startgame.Location = new System.Drawing.Point(102, 274);
            this.startgame.Margin = new System.Windows.Forms.Padding(0);
            this.startgame.Name = "startgame";
            this.startgame.Padding = new System.Windows.Forms.Padding(20);
            this.startgame.Size = new System.Drawing.Size(281, 78);
            this.startgame.TabIndex = 50;
            this.startgame.Text = "START GAME";
            this.startgame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startgame.Click += new System.EventHandler(this.startgame_Click_1);
            this.startgame.MouseEnter += new System.EventHandler(this.startgame_MouseHover);
            this.startgame.MouseLeave += new System.EventHandler(this.startgame_MouseLeave);
            // 
            // exitgame
            // 
            this.exitgame.AutoSize = true;
            this.exitgame.BackColor = System.Drawing.Color.Gainsboro;
            this.exitgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitgame.Location = new System.Drawing.Point(102, 416);
            this.exitgame.Margin = new System.Windows.Forms.Padding(0);
            this.exitgame.Name = "exitgame";
            this.exitgame.Padding = new System.Windows.Forms.Padding(101, 20, 101, 20);
            this.exitgame.Size = new System.Drawing.Size(295, 78);
            this.exitgame.TabIndex = 51;
            this.exitgame.Text = "EXIT";
            this.exitgame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitgame.Click += new System.EventHandler(this.exitgame_Click);
            this.exitgame.MouseEnter += new System.EventHandler(this.exitgame_MouseEnter);
            this.exitgame.MouseLeave += new System.EventHandler(this.exitgame_DragLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1332, 753);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.exitgame);
            this.Controls.Add(this.startgame);
            this.Controls.Add(this.bg);
            this.Controls.Add(this.testtt);
            this.Controls.Add(this.testlll);
            this.Controls.Add(this.tpb);
            this.Controls.Add(this.testt);
            this.Controls.Add(this.testll);
            this.Controls.Add(this.testl);
            this.Controls.Add(this.test);
            this.Controls.Add(this.ready);
            this.Controls.Add(this.wavecounterl);
            this.Controls.Add(this.wavecounter);
            this.Controls.Add(this.enemycounterl);
            this.Controls.Add(this.enemycounter);
            this.Controls.Add(this.cdl);
            this.Controls.Add(this.coinl);
            this.Controls.Add(this.ammol);
            this.Controls.Add(this.scorel);
            this.Controls.Add(this.hpl);
            this.Controls.Add(this.hpbar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shopsmg);
            this.Controls.Add(this.shopsniper);
            this.Controls.Add(this.sgshot);
            this.Controls.Add(this.shopshotgun);
            this.Controls.Add(this.shopammo);
            this.Controls.Add(this.shopmedkit);
            this.Controls.Add(this.shopgoodpistol);
            this.Controls.Add(this.shoppistol);
            this.Controls.Add(this.player);
            this.Controls.Add(this.dr);
            this.Controls.Add(this.shop);
            this.Controls.Add(this.door);
            this.Controls.Add(this.river);
            this.Controls.Add(this.shopopener);
            this.Controls.Add(this.portald);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "TAX";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyup);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavecounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsniper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopshotgun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopammo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopmedkit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopgoodpistol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppistol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.river)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopopener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portald)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar hpbar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label hpl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label scorel;
        private System.Windows.Forms.Label ammol;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.Label coinl;
        private System.Windows.Forms.PictureBox river;
        private System.Windows.Forms.PictureBox shop;
        private System.Windows.Forms.Timer wait;
        private System.Windows.Forms.PictureBox dr;
        private System.Windows.Forms.Label cdl;
        private System.Windows.Forms.PictureBox shoppistol;
        private System.Windows.Forms.PictureBox shopgoodpistol;
        private System.Windows.Forms.PictureBox shopopener;
        private System.Windows.Forms.PictureBox shopmedkit;
        private System.Windows.Forms.PictureBox shopammo;
        private System.Windows.Forms.PictureBox shopshotgun;
        private System.Windows.Forms.PictureBox sgshot;
        private System.Windows.Forms.Timer sgtimer;
        private System.Windows.Forms.PictureBox shopsniper;
        private System.Windows.Forms.PictureBox shopsmg;
        private System.Windows.Forms.PictureBox enemycounter;
        private System.Windows.Forms.Label enemycounterl;
        private System.Windows.Forms.Label wavecounterl;
        private System.Windows.Forms.PictureBox wavecounter;
        private System.Windows.Forms.PictureBox portald;
        private System.Windows.Forms.Label ready;
        private System.Windows.Forms.PictureBox test;
        private System.Windows.Forms.Label testl;
        private System.Windows.Forms.Label testll;
        private System.Windows.Forms.PictureBox testt;
        private System.Windows.Forms.PictureBox tpb;
        private System.Windows.Forms.Label testlll;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testLabelSHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testButtonSHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testPBSHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waveSelectToolStripMenuItem;
        private System.Windows.Forms.PictureBox testtt;
        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.Label startgame;
        private System.Windows.Forms.Label exitgame;
        private System.Windows.Forms.ToolStripMenuItem customWaveToolStripMenuItem;
    }
}

