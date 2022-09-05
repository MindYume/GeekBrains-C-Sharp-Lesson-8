using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Main : Form
    {
        private TrueFalseEngine engine;

        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void menuBtnNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                engine = new TrueFalseEngine(saveFileDialog.FileName);
                engine.Add("Question 1", true);
                engine.Save();
                numericQuestionNumber.Minimum = 1;
                numericQuestionNumber.Maximum = 1;
                numericQuestionNumber.Value = 1;
                labelFileName.Text = $"File: {saveFileDialog.FileName}";

                textFieldQuestion.Text = engine[(int)numericQuestionNumber.Value - 1].Text;
            }
        }

        private void menuBtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                engine = new TrueFalseEngine(openFileDialog.FileName);
                engine.Load();
                numericQuestionNumber.Minimum = 1;
                numericQuestionNumber.Maximum = engine.Count;
                numericQuestionNumber.Value = 1;
                labelFileName.Text = $"File: {openFileDialog.FileName}";

                textFieldQuestion.Text = engine[(int)numericQuestionNumber.Value - 1].Text;
                checkTrue.Checked = engine[(int)numericQuestionNumber.Value - 1].TrueFalse;

                //Console.WriteLine(engine[(int)numericQuestionNumber.Value - 1].TrueFalse);
            }
        }

        private void menuBtnSave_Click(object sender, EventArgs e)
        {
            if (!(engine is null))
            {
                engine.Save();
            }
            else
            {
                MessageBox.Show(
                    "Вы не окрыли файл.",
                    "Questions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
             );
            }
        }

        private void numericQuestionNumber_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericQuestionNumber.Value > 0)
            {
                textFieldQuestion.Text = engine[(int)numericQuestionNumber.Value - 1].Text;
                checkTrue.Checked = engine[(int)numericQuestionNumber.Value - 1].TrueFalse;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(engine is null))
            {
                engine.Add($"Question {numericQuestionNumber.Maximum + 1}", checkTrue.Checked);
                numericQuestionNumber.Maximum = engine.Count;
                numericQuestionNumber.Value = engine.Count;

                if (numericQuestionNumber.Minimum == 0)
                    numericQuestionNumber.Minimum = 1;
            }
            else
            {
                MessageBox.Show(
                    "Вы не окрыли файл.",
                    "Questions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
             );
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(engine is null))
            {
                engine[(int)numericQuestionNumber.Value - 1].Text = textFieldQuestion.Text;
                engine[(int)numericQuestionNumber.Value - 1].TrueFalse = checkTrue.Checked;
            }
            else
            {
                MessageBox.Show(
                    "Вы не окрыли файл.",
                    "Questions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
             );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(engine is null))
            {
                if (engine.Count == 1)
                {
                    engine.Delete((int)numericQuestionNumber.Value - 1);
                    numericQuestionNumber.Minimum = 0;
                    numericQuestionNumber.Maximum = 0;
                    numericQuestionNumber.Value = 0;

                    textFieldQuestion.Text = "";
                    checkTrue.Checked = false;
                }
                else if (engine.Count > 1)
                {
                    engine.Delete((int)numericQuestionNumber.Value - 1);
                    numericQuestionNumber.Maximum--;
                    if(numericQuestionNumber.Value > numericQuestionNumber.Maximum)
                        numericQuestionNumber.Value = numericQuestionNumber.Maximum;

                    textFieldQuestion.Text = engine[(int)numericQuestionNumber.Value-1].Text;
                    checkTrue.Checked = engine[(int)numericQuestionNumber.Value - 1].TrueFalse;
                }
            }
            else
            {
                MessageBox.Show(
                    "Вы не окрыли файл.",
                    "Questions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void textFieldQuestion_TextChanged(object sender, EventArgs e)
        {
            if (!(engine is null) && engine.Count > 0)
            {
                engine[(int)numericQuestionNumber.Value - 1].Text = textFieldQuestion.Text;
                engine[(int)numericQuestionNumber.Value - 1].TrueFalse = checkTrue.Checked;
            }
            else
            {
                textFieldQuestion.Text = "";
                checkTrue.Checked = false;
            }
        }

        private void checkTrue_CheckedChanged(object sender, EventArgs e)
        {
            //engine[(int)numericQuestionNumber.Value - 1].TrueFalse = checkTrue.Checked;
        }

        private void checkTrue_Click(object sender, EventArgs e)
        {
            if (!(engine is null) && engine.Count > 0)
            {
                engine[(int)numericQuestionNumber.Value - 1].TrueFalse = checkTrue.Checked;
            }
            else
            {
                textFieldQuestion.Text = "";
                checkTrue.Checked = false;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Домашняя работа к 8 уроку по c#\n" +
               "" +
               "Студент: Грачёв Виктор Алексеевич",
               "Questions",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
            );
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Type dateTimeType = typeof(DateTime);
            string properties = "Все свойства DateTime:\n";

            foreach (PropertyInfo prop in dateTimeType.GetProperties())
            {
                properties += prop.Name + "\n";
            }

            MessageBox.Show(
               properties,
               "Questions",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
            );
        }
    }
}
