using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentService.StudentServiceClient client = new StudentService.StudentServiceClient("NetTcpBinding_IStudentService");

            try
            {
                int id = Convert.ToInt32(textBox1.Text);

                StudentService.Student std = client.GetStudent(id);

                if(std != null)
                {
                    textBox2.Text = std.Name;
                    textBox3.Text = std.DateOfBirth.ToString();
                    textBox4.Text = std.Gpa.ToString();
                    lblShow.Text = "Get Data Student Succes.";
                } else
                {
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    lblShow.Text = "Data Student Not Found.";
                }
            }
            catch (Exception er)
            {
                clearText();
                lblShow.Text = "Error : " + er.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentService.StudentServiceClient client = new StudentService.StudentServiceClient("NetTcpBinding_IStudentService");

            try
            {
                StudentService.Student student = new StudentService.Student()
                {
                    Name = textBox2.Text,
                    DateOfBirth = Convert.ToDateTime(textBox3.Text),
                    Gpa = Convert.ToDouble(textBox4.Text)
                };

                if(client.AddStudent(student))
                {
                    lblShow.Text = "Add Student Success.";
                }
                else
                {
                    lblShow.Text = "Add Student Fail.";
                }
                clearText();
            }
            catch (Exception er)
            {
                clearText();
                lblShow.Text = "Error : " + er.ToString();
            }
        }


        private void clearText()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentService.StudentServiceClient client = new StudentService.StudentServiceClient("NetTcpBinding_IStudentService");

            try
            {
                int id = Convert.ToInt32(textBox1.Text);
                StudentService.Student std = client.GetStudent(id);
                if(std != null)
                {
                    std.Name = textBox2.Text;
                    std.DateOfBirth = Convert.ToDateTime(textBox3.Text);
                    std.Gpa = Convert.ToDouble(textBox4.Text);

                    if(client.UpdateStudent(std))
                    {
                        lblShow.Text = "Update Student Success.";
                    } 
                    else
                    {
                        lblShow.Text = "Update Student Fail.";
                    }
                }
                else
                {
                    lblShow.Text = "Data Student Not Found.";
                }
            }
            catch (Exception er)
            {
                clearText();
                lblShow.Text = "Error : " + er.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentService.StudentServiceClient client = new StudentService.StudentServiceClient("NetTcpBinding_IStudentService");

            try
            {
                int id = Convert.ToInt32(textBox1.Text);
                StudentService.Student std = client.GetStudent(id);
                if (std != null)
                {
                    if (client.DeleteStudent(std))
                    {
                        clearText();
                        lblShow.Text = "Delete Student Success.";
                    }
                    else
                    {
                        lblShow.Text = "Delete Student Fail.";
                    }
                }
                else
                {
                    clearText();
                    lblShow.Text = "Data Student Not Found.";
                }
            }
            catch (Exception er)
            {
                clearText();
                lblShow.Text = "Error : " + er.ToString();
            }
        }
    }
}
