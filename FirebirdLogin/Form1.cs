using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FirebirdLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //*******************************IF YOU LOGIN WITH DATABASE CONVERT THE COMMENT CODE TO NORMAL CODE ***************************//


        //FbConnection fbCon = new FbConnection(ConfigurationManager.ConnectionStrings["FB"].ConnectionString);
        //FbDataReader dr;
        private void loginButton_Click(object sender, EventArgs e)
        {
            //-------------------------------------BASE DB USERNAME AND PASSWORD-----------------------------------//

            //FbCommand cmd = new FbCommand();
            //cmd.CommandText = "SELECT * FROM KULLANIC WHERE USER_NAME='"+usernameTextBox.Text+"' AND SIFRE='"+passwordTextBox.Text+"' "; //SQL Text
            //cmd.Connection = fbCon; //Command Connection Db
            //fbCon.Open();
            //dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    MessageBox.Show("Ok. Login Successful");
            //    label4.ForeColor = Color.Green;
            //    fbCon.Close();
            //    Process.Start(@"C:\Netsim.N4\Bin\NetsimApp.exe");
            //}
            //else
            //{
            //    fbCon.Close();
            //    label4.Text="Username and Password is Invalid";
            //    label4.ForeColor = Color.Red;
            //}
            //fbCon.Close();


            //----------------------------------STATIC USERNAME AND PASSWORD-----------------------------//
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                label4.Text = "You Must be input any character ";
                label4.ForeColor = Color.Red;

            }
            else
            {
                if (usernameTextBox.Text == "SYSDBA" && passwordTextBox.Text == "admin")
                {
                    label4.Text = "Ok. Login Successful";
                    label4.ForeColor = Color.Green;
                    Process.Start(@"C:\Netsim.N4\Bin\NetsimApp.exe");  //Open The App
                }
                else
                {

                    label4.Text = "Username and Password is Invalid";
                    label4.ForeColor = Color.Red;  //if get error Label Color Red
                    usernameTextBox.Clear();       //if get error TextBox Auto Clear
                    passwordTextBox.Clear();       //if get error TextBox Auto Clear
                }
            }
        }

        //Convert Username Upper Case
        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];

        }
    }
}
