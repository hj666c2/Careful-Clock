﻿using System;
using System.Collections;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Careful_Clock
{
    public partial class Form1 : Form
    {
        private string[] url = System.IO.File.ReadAllLines("url.txt");
        private JObject json = new JObject();
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string read = client.DownloadString(url[0]);
            json = JObject.Parse(read);
            try
            {
                textBox1.Text = json["0"].ToString();
            }
            catch { textBox1.Text = ""; }
            try
            {
                textBox2.Text = json["1"].ToString();
            }
            catch { textBox2.Text = ""; }
            try
            {
                textBox3.Text = json["2"].ToString();
            }
            catch { textBox3.Text = ""; }
            try
            {
                textBox4.Text = json["3"].ToString();
            }
            catch { textBox4.Text = ""; }
            try
            {
                textBox5.Text = json["4"].ToString();
            }
            catch { textBox5.Text = ""; }
            try
            {
                textBox6.Text = json["5"].ToString();
            }
            catch { textBox6.Text = ""; }
            try
            {
               textBox7.Text = json["6"].ToString();
            }
            catch { textBox7.Text = ""; }
            try
            {
                textBox8.Text = json["7"].ToString();
            }
            catch { textBox8.Text = ""; }
            try
            {
                textBox9.Text = json["8"].ToString();
            }
            catch { textBox9.Text = ""; }
            try
            {
                textBox12.Text = json["9"].ToString();
            }
            catch { textBox12.Text = ""; }
            try
            {
                textBox13.Text = json["10"].ToString();
            }
            catch { textBox13.Text = ""; }
            try
            {
                textBox10.Text = json["11"].ToString();
            }
            catch { textBox10.Text = ""; }
            try
            {
                textBox11.Text = json["12"].ToString();
            }
            catch { textBox11.Text = ""; }
            try
            {
                textBox14.Text = json["13"].ToString();
            }
            catch { textBox14.Text = ""; }
            try
            {
                textBox15.Text = json["14"].ToString();
            }
            catch { textBox15.Text = ""; }
            try
            {
                textBox16.Text = json["15"].ToString();
            }
            catch { textBox16.Text = ""; }
            button1.Enabled = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            json = new JObject();
            button1.Enabled = false;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                json.Add("0", textBox1.Text);
            }
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                json.Add("1", textBox2.Text);
            }
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                json.Add("2", textBox3.Text);
            }
            if (!String.IsNullOrEmpty(textBox4.Text))
            {
                json.Add("3", textBox4.Text);
            }
            if (!String.IsNullOrEmpty(textBox5.Text))
            {
                json.Add("4", textBox5.Text);
            }
            if (!String.IsNullOrEmpty(textBox6.Text))
            {
                json.Add("5", textBox6.Text);
            }
            if (!String.IsNullOrEmpty(textBox7.Text))
            {
                json.Add("6", textBox7.Text);
            }

            if (!String.IsNullOrEmpty(textBox8.Text))
            {
                json.Add("7", textBox8.Text);
            }
            if (!String.IsNullOrEmpty(textBox9.Text))
            {
                json.Add("8", textBox9.Text);
            }
            if (!String.IsNullOrEmpty(textBox10.Text))
            {
                json.Add("11", textBox10.Text);
            }
            if (!String.IsNullOrEmpty(textBox11.Text))
            {
                json.Add("12", textBox11.Text);
            }
            if (!String.IsNullOrEmpty(textBox12.Text))
            {
                json.Add("9", textBox12.Text);
            }
            if (!String.IsNullOrEmpty(textBox13.Text))
            {
                json.Add("10", textBox13.Text);
            }
            if (!String.IsNullOrEmpty(textBox14.Text))
            {
                json.Add("13", textBox14.Text);
            }
            if (!String.IsNullOrEmpty(textBox15.Text))
            {
                json.Add("14", textBox15.Text);
            }
            if (!String.IsNullOrEmpty(textBox16.Text))
            {
                json.Add("15", textBox16.Text);
            }
            WebClient upload = new WebClient();
            upload.Encoding = Encoding.UTF8;
            upload.Headers.Add("Content-Type", "application/json");
            upload.UploadString(url[0], "Put", json.ToString());
            MessageBox.Show("업로드가 완료되었습니다.","완료");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string read = client.DownloadString(url[0]);
            json = JObject.Parse(read);
            try
            {
                textBox1.Text = json["0"].ToString();
            }
            catch { textBox1.Text = ""; }
            try
            {
                textBox2.Text = json["1"].ToString();
            }
            catch { textBox2.Text = ""; }
            try
            {
                textBox3.Text = json["2"].ToString();
            }
            catch { textBox3.Text = ""; }
            try
            {
                textBox4.Text = json["3"].ToString();
            }
            catch { textBox4.Text = ""; }
            try
            {
                textBox5.Text = json["4"].ToString();
            }
            catch { textBox5.Text = ""; }
            try
            {
                textBox6.Text = json["5"].ToString();
            }
            catch { textBox6.Text = ""; }
            try
            {
                textBox7.Text = json["6"].ToString();
            }
            catch { textBox7.Text = ""; }
            try
            {
                textBox8.Text = json["7"].ToString();
            }
            catch { textBox8.Text = ""; }
            try
            {
                textBox9.Text = json["8"].ToString();
            }
            catch { textBox9.Text = ""; }
            try
            {
                textBox12.Text = json["9"].ToString();
            }
            catch { textBox12.Text = ""; }
            try
            {
                textBox13.Text = json["10"].ToString();
            }
            catch { textBox13.Text = ""; }
            try
            {
                textBox10.Text = json["11"].ToString();
            }
            catch { textBox10.Text = ""; }
            try
            {
                textBox11.Text = json["12"].ToString();
            }
            catch { textBox11.Text = ""; }
            try
            {
                textBox14.Text = json["13"].ToString();
            }
            catch { textBox14.Text = ""; }
            try
            {
                textBox15.Text = json["14"].ToString();
            }
            catch { textBox15.Text = ""; }
            try
            {
                textBox16.Text = json["15"].ToString();
            }
            catch { textBox16.Text = ""; }
            button1.Enabled = false;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Hashtable hashtable = new Hashtable();
            DateTime dateTime = DateTime.Now;
            string[] time = (textBox20.Text).Split(':');
            dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, int.Parse(time[0]), int.Parse(time[1]), dateTime.Second);
            int @class = int.Parse(textBox19.Text) * 2;
            int classtime = int.Parse(textBox17.Text);
            int resttime = int.Parse(textBox18.Text);
            JObject jObject = new JObject();
            int i = 0;
            if (checkBox1.Checked)
            {
                hashtable.Add("0", $"{dateTime.Hour}:{dateTime.Minute}");
                dateTime = dateTime.AddMinutes(20);
                hashtable.Add("1", $"{dateTime.Hour}:{dateTime.Minute}");
            }
            else
            {
                hashtable.Add("0", "00:00");
                dateTime = dateTime.AddMinutes(-10);
                hashtable.Add("1", $"{dateTime.Hour}:{dateTime.Minute}");
            }
            i = 2;
            for (; i <= @class; i += 2)
            {
                if (i == int.Parse(textBox21.Text) * 2 + 2)
                {
                    dateTime = dateTime.AddMinutes(70);
                }
                else
                {
                    dateTime = dateTime.AddMinutes(resttime);
                }
                hashtable.Add(i.ToString(), $"{dateTime.Hour}:{dateTime.Minute}");
                dateTime = dateTime.AddMinutes(classtime);
                hashtable.Add((i + 1).ToString(), $"{dateTime.Hour}:{dateTime.Minute}");
            }
            for (i = 0; i < hashtable.Count; i++ )
            {
                string json = hashtable[i.ToString()].ToString();
                jObject.Add(i.ToString(), hashtable[i.ToString()].ToString());
            }
            WebClient upload = new WebClient();
            upload.Encoding = Encoding.UTF8;
            upload.Headers.Add("Content-Type", "application/json");
            upload.UploadString(url[0], "Put", jObject.ToString());
            MessageBox.Show("업로드가 완료되었습니다.","완료");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            WebClient upload = new WebClient();
            upload.Encoding = Encoding.UTF8;
            JObject jObject = JObject.Parse(upload.DownloadString(url[1]));
            JObject up = new JObject();
            foreach (var token in jObject)
            {
                up.Add(token.Key, true);
            }
            upload.Headers.Add("Content-Type", "application/json");
            upload.UploadString(url[1], "Put", up.ToString());
            MessageBox.Show("업로드가 완료되었습니다.", "완료");
        }
    }
}
