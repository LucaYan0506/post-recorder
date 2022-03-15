using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace LeetCode_posts
{
    public partial class AddWindow : Form
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        public static bool Cancelled = false;
        bool UrlIsValid(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private void CancelCmd_Click(object sender, EventArgs e)
        {
            Cancelled = true; ;
            this.Close();
        }

        private void SubmitCmd_Click(object sender, EventArgs e)
        {
            //if one of the field is empty send a message
            if (UrlText.Text == "" || ProbNameText.Text == "")
            {
                //if urltext is empty set its title red, otherwise set the title black
                if (UrlText.Text == "") label2.ForeColor = Color.Red;
                else label2.ForeColor = Color.Black;
                    
                //if ProbNameText is empty set its title red, otherwise set the title black
                if (ProbNameText.Text == "") label1.ForeColor = Color.Red;
                else label1.ForeColor = Color.Black;

                //send the message
                MessageBox.Show("Pls complete the form");

                //stop to run code below
                return;
            }

            //if the url is not valid send the message
            if (UrlIsValid(UrlText.Text)== false) 
            {
                MessageBox.Show("Pls insert a valid url");
                UrlText.Text = "";

                //if urltext is empty set its title red, otherwise set the title black
                if (UrlText.Text == "") label2.ForeColor = Color.Red;
                else label2.ForeColor = Color.Black;

                //if ProbNameText is empty set its title red, otherwise set the title black
                if (ProbNameText.Text == "") label1.ForeColor = Color.Red;
                else label1.ForeColor = Color.Black;

                //stop to run code below
                return;
            }
         
            //send url and name to form1 (to create a new label)
            Form1.Post_Url = UrlText.Text;
            Form1.Prob_name = ProbNameText.Text;

            Cancelled = false;
            this.Close();
        }

        private void AddWindow_Load(object sender, EventArgs e)
        {
            //init urltext and probname
            UrlText.Text = "";
            ProbNameText.Text = "";
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;

            //add keydown event
            this.KeyDown += Esc_Submit;
            SubmitCmd.KeyDown += Esc_Submit;
            CancelCmd.KeyDown += Esc_Submit;
        }

        //submint of exit using keys
        private void Esc_Submit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SubmitCmd.PerformClick();

            if (e.KeyCode == Keys.Escape) CancelCmd.PerformClick();
        }
    }
}
