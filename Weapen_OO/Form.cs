﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Weapen_OO
{
    public partial class Form_Init : Form
    {
        public Form_Init()
        {
            Init();
        }

        void Init()
        {
            InitializeComponent();
            InitPanel();
            InitInput();
            InitLable();
            InitButton();
        }

        public void InitPanel()
        {
            PanelArray.panel_array[2] = PanelArray.getPanels("bottom_left", 150, 40);
            PanelArray.panel_array[2].Dock = DockStyle.Left;
            PanelArray.panel_array[3] = PanelArray.getPanels("bottom_right",150, 40);
            PanelArray.panel_array[3].Dock = DockStyle.Right;
            PanelArray.panel_array[0] = PanelArray.getPanels("top", 300, 50);
            PanelArray.panel_array[0].Dock = DockStyle.Top;
            PanelArray.panel_array[1] = PanelArray.getPanels("center", 300, 50);
            PanelArray.panel_array[1].Dock = DockStyle.Top;
            this.Controls.Add(PanelArray.panel_array[3]);
            this.Controls.Add(PanelArray.panel_array[2]);
            this.Controls.Add(PanelArray.panel_array[1]);
            this.Controls.Add(PanelArray.panel_array[0]);
        }

        void InitLable()
        {
            Label lab = new Label();
            Size ss_lab = new Size(300, 35);
            lab.Size = ss_lab;
            lab.Text = "请输入姓名";
            PanelArray.panel_array[0].Controls.Add(lab);
        }

        void InitInput()
        {
            TextBox tbx_input = new TextBox();
            tbx_input.Width=300;
            PanelArray.panel_array[1].Controls.Add(tbx_input);
        }

        void InitButton()
        {
            Button btn_confirm =new Button();
            btn_confirm.Text = "确认";
            btn_confirm.Click += new EventHandler(this.Go_Game_Start);
            PanelArray.panel_array[2].Controls.Add(btn_confirm);
            Button btn_reset = new Button();
            btn_reset.Text = "重置";
            btn_reset.Click += new EventHandler(this.ReSet);
            PanelArray.panel_array[3].Controls.Add(btn_reset);
           
        }

        void Go_Game_Start(Object sender,EventArgs e) 
        {
            User.username = PanelArray.panel_array[1].Controls[0].Text;
            Form_Game form_game = new Form_Game();
            this.Hide();
            form_game.Show();
        }

        void ReSet(Object sender, EventArgs e) {
            PanelArray.panel_array[1].Controls[0].Text = "";
        }
    }

    public partial class Form_Game : Form 
    {
        public Form_Game() {
            Init();
        }
        void Init()
        {
            this.ClientSize = new System.Drawing.Size(300, 300);
            InitUsers();
            InitPanel();
            InitLable();
            InitButton();
        }


        void InitUsers()
        {
            User.user = new Human (User.username);
            Thread.Sleep(50);
            User.opponent = new Human ("Npc");
        }
        void InitLable()
        {
            Label lab_user = new Label();
            Size ss_lab = new Size(100, 100);
            lab_user.Size = ss_lab;
            lab_user.Text = "姓名:" + User.user.Name + "\r\n攻击:" + User.user.Attack + "\r\n生命值:" + User.user.Life;
            PanelArray.panel_array[1].Controls.Add(lab_user);


            Label lab_opp = new Label();
            lab_opp.Size = ss_lab;
            lab_opp.Text = "姓名:" + User.opponent.Name + "\r\n攻击:" + User.opponent.Attack + "\r\n生命值:" + User.opponent.Life;
            PanelArray.panel_array[3].Controls.Add(lab_opp);


            Label lab_content = new Label();
            Size ss_content = new Size(300, 200);
            lab_content.Size = ss_content;
            PanelArray.panel_array[0].Controls.Add(lab_content);
        }
        void InitButton() 
        {
            Button btn_start = new Button();
            btn_start.Text = "开始PK";
            Size btn_size = new Size(100, 100);
            btn_start.Size = btn_size;
            btn_start.Click += new EventHandler(this.Game_Start);
            PanelArray.panel_array[2].Controls.Add(btn_start);
        }

        public void InitPanel()
        {
            PanelArray.panel_array[1] = PanelArray.getPanels("top_left", 100, 100);
            PanelArray.panel_array[1].Dock = DockStyle.Left;
            PanelArray.panel_array[2] = PanelArray.getPanels("top_center", 100, 100);
            PanelArray.panel_array[2].Dock = DockStyle.Right;
            PanelArray.panel_array[3] = PanelArray.getPanels("top_right", 100, 100);
            PanelArray.panel_array[3].Dock = DockStyle.Right;
            PanelArray.panel_array[0] = PanelArray.getPanels("bottom",300, 200);
            PanelArray.panel_array[0].Dock = DockStyle.Bottom;
            this.Controls.Add(PanelArray.panel_array[1]);
            this.Controls.Add(PanelArray.panel_array[2]);
            this.Controls.Add(PanelArray.panel_array[3]);
            this.Controls.Add(PanelArray.panel_array[0]);
        }

        void Game_Start(Object sender, EventArgs e)
        {
            User.isDead = false;
            User.timer1.Interval = 2000;
            User.timer1.Tick += new EventHandler(timer1_Tick);
            User.timer2.Interval = 2000;
            User.timer2.Tick += new EventHandler(timer2_Tick);
            User.timer1.Start();
            Thread.Sleep(1000);
            User.timer2.Start();
        }

        void timer1_Tick(object sender, EventArgs e) 
        {
            if (!User.isDead)
            {
                PanelArray.panel_array[0].Controls[0].Text += User.user.Heat(User.opponent) + "\r\n";
            }
            else {
                User.timer1.Stop();
                User.timer2.Stop();
            }
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            if (!User.isDead)
            {
                PanelArray.panel_array[0].Controls[0].Text += User.opponent.Heat(User.user) + "\r\n";
            }
            else
            {
                User.timer1.Stop();
                User.timer2.Stop();
            }
        }
    }

    public static class PanelArray
    {
        public static Panel[] panel_array = new Panel[4];
        public static Panel getPanels(string name, int x, int y)
        {
            Panel pan = new Panel();
            pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pan.Size = new Size(x, y);
            pan.Name = "pan_" + name;
            return pan;
        }
    }

    public static class User
    {
        public static string username;
        public static Person user;
        public static Person opponent;
        public static bool isDead;
        public static System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer(); 
    }

}
