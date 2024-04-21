using EFApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EFApp.FormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            EducationDbContext context = new EducationDbContext();
            List<Student> students = context.Students.ToList();

            dataGridViewStudentList.DataSource = students;


        }
    }
}


//Linq To Entities 