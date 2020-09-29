using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        HashTable hashTable;
        public Form1()
        {
            InitializeComponent();
            hashTable = new HashTable();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassportData passportData;
            PersonData personData;
            PassportDataForm passportDataForm = new PassportDataForm();
            PersonDataForm personDataForm = new PersonDataForm();
            passportDataForm.ShowDialog();
            if(passportDataForm.DialogResult == DialogResult.OK) 
            {
                personDataForm.ShowDialog();
                if (personDataForm.DialogResult == DialogResult.OK)
                {
                    if (passportDataForm.textBoxNumber.Text != "" && personDataForm.textBoxAdress.Text != "" && personDataForm.textBoxFIO.Text != "")
                    {
                        passportData = new PassportData(passportDataForm.textBoxNumber.Text, passportDataForm.dateTimePicker.Value);
                        personData = new PersonData(personDataForm.textBoxFIO.Text, personDataForm.textBoxAdress.Text);
                        hashTable.Insert(passportData, personData);
                        ShowHashTable(hashTable, "Passport data");
                    }
                }
                
            }
        }

        void ShowHashTable(HashTable hashTable, string title)
        {

            // Выводим все имеющие пары хеш-значение
            textBox1.Text= title + "\r\n";
            foreach (var item in hashTable.Items)
            {
                // Выводим хеш
                textBox1.Text+=item.Key + ":\r\n";

                // Выводим все значения хранимые под этим хешем.
                foreach (var value in item.Value)
                {
                    textBox1.Text+=($"\t{value.Key.ToString()} - {value.Value.ToString()}");
                    textBox1.Text += "\r\n";
                }
                textBox1.Text += "\r\n**********\r\n";
            }
            Console.WriteLine();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassportDataForm passportDataForm = new PassportDataForm();
            PassportData passportData;
            passportDataForm.ShowDialog();
            if (passportDataForm.DialogResult == DialogResult.OK)
            {
                if (passportDataForm.textBoxNumber.Text != "")
                {
                    passportData = new PassportData(passportDataForm.textBoxNumber.Text, passportDataForm.dateTimePicker.Value);
                    hashTable.Delete(passportData);
                    ShowHashTable(hashTable, "Passport data");
                }
            }
        }

        private void найтиПоПаспортуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassportDataForm passportDataForm = new PassportDataForm();
            PassportData passportData;
            passportDataForm.ShowDialog();
            if (passportDataForm.DialogResult == DialogResult.OK)
            {
                if (passportDataForm.textBoxNumber.Text != "")
                {
                    passportData = new PassportData(passportDataForm.textBoxNumber.Text, passportDataForm.dateTimePicker.Value);
                    MessageBox.Show( hashTable.Search(passportData));
                    ShowHashTable(hashTable, "Passport data");
                }
            }
        }
    }
}
