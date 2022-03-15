using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCode_posts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// drobMenu

        //dropMenu
        Panel DropMenu = new Panel();
        Label[] options;

        private void Show_DropMenu(Point Dropmenu_location)
        {
            options = new Label[2];

            DropMenu.Name = "DropMenu";
            DropMenu.BackColor = Color.White;
            DropMenu.Size = new Size(50, 44);
            DropMenu.Location = Dropmenu_location;
            DropMenu.Visible = true;
            DropMenu.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(DropMenu);
            DropMenu.BringToFront();

            options[0] = new Label();
            options[0].Text = "A -> Z";
            options[0].Font = new Font("Microsoft Sans Serif", 10f);
            options[0].Size = new Size(DropMenu.Width, options[0].Height);
            options[0].Location = new Point(0, 20 * 0);
            options[0].MouseMove += ChangeColorLabel;
            options[0].Click += Low_High_Click;
            DropMenu.Controls.Add(options[0]);

            options[1] = new Label();
            options[1].Text = "Z -> A";
            options[1].Font = new Font("Microsoft Sans Serif", 10f);
            options[1].Size = new Size(DropMenu.Width, options[1].Height);
            options[1].Location = new Point(0, 20 * 1);
            options[1].MouseMove += ChangeColorLabel;
            DropMenu.Controls.Add(options[1]);
        }

        private void ChangeColorLabel(object sender, MouseEventArgs e)
        {
            (sender as Label).BackColor = SystemColors.Control;

            foreach (Control lbl in DropMenu.Controls)
            {
                if (lbl is Label)
                {
                    if ((lbl as Label).Text == (sender as Label).Text)
                    {
                        continue;
                    }
                    (lbl as Label).BackColor = Color.White;
                }
            }
        }

        Label[] labels;
        private void Low_High_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Working in progress");
        }

        private void High_Low_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Working in progress");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// variables

        int index = -1;
        public static string Post_Url = "";
        public static string  Prob_name = "";

        AddWindow add = new AddWindow();

        private void Form1_Load(object sender, EventArgs e)
        {
            AddCmd.BringToFront();
            ResetCmd.BringToFront();
            SaveCmd.BringToFront();

            if (System.IO.File.Exists("Posts"))
            {
                ListPanel.Controls.Clear();

                StreamReader file = new StreamReader("Posts");

                while (!file.EndOfStream)
                {
                    string txt = file.ReadLine();
                    string url = file.ReadLine();

                    index++;
                    Label Post = new Label();
                    Post.Font = new Font("Microsoft Sans Serif", 16);
                    Post.Text = txt;
                    Post.Name = url;
                    Post.AutoSize = true;
                    Post.Location = new Point(12, 9 + (25 * index));
                    Post.DoubleClick += OpenUrl;
                    Post.MouseClick += RightClick;
                    ListPanel.Controls.Add(Post);
                }

                file.Dispose();

            }
        }

        private void AddCmd_Click(object sender, EventArgs e)
        {
            ListPanel.VerticalScroll.Value = 0;
            add.ShowDialog();

            if (!AddWindow.Cancelled)
            {
                index++;
                Label Post = new Label();
                Post.Font = new Font("Microsoft Sans Serif", 16);
                Post.Text = Prob_name;
                Post.Name = Post_Url;
                Post.AutoSize = true;
                Post.Location = new Point(12, 9 + (25 * index));
                Post.DoubleClick += OpenUrl;
                Post.MouseClick += RightClick;
                ListPanel.Controls.Add(Post);
            }
        }

        private void RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Show_DropMenu(new Point (MousePosition.X - 8 - this.Location.X,MousePosition.Y - 30 - this.Location.Y));
            }
        }

        private void OpenUrl(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", (sender as Label).Name);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //move addcmd when the form is resized
            AddCmd.Location = new Point(this.Width - 146, this.Height - 83);
            SaveCmd.Location = new Point(AddCmd.Location.X, AddCmd.Location.Y - 38);
            ResetCmd.Location = new Point(AddCmd.Location.X, AddCmd.Location.Y - 76);

        }

        private void SaveCmd_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("Posts");

            foreach (Control c in ListPanel.Controls)
            {
                if (c is Label)
                {
                    file.WriteLine((c as Label).Text);
                    file.WriteLine((c as Label).Name);

                }

            }

            file.Dispose();
        }

        private void ResetCmd_Click(object sender, EventArgs e)
        {

            index = -1;
            ListPanel.Controls.Clear();

            if (System.IO.File.Exists("Posts"))
            {
                StreamReader file = new StreamReader("Posts");

                while (!file.EndOfStream)
                {
                    string txt = file.ReadLine();
                    string url = file.ReadLine();

                    index++;
                    Label Post = new Label();
                    Post.Font = new Font("Microsoft Sans Serif", 16);
                    Post.Text = txt;
                    Post.Name = url;
                    Post.AutoSize = true;
                    Post.Location = new Point(12, 9 + (25 * index));
                    Post.DoubleClick += OpenUrl;
                    Post.MouseClick += RightClick;
                    ListPanel.Controls.Add(Post);
                }

                file.Dispose();

            }
        }

       
    }
}
