using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE101_Final_Prep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        const int GREATESTSUBSEQUENCE = 0;
        const int EDITDISTANCE = 1;
        const int SELECTION = 2;
        const int QUICKSORT = 3;
        private int[] getIntArrayFromString(String str)
        {
            String[] subStr = str.Split(',');
            int[] intArr = new int[subStr.Length];
            for (int i = 0; i < subStr.Length; i++)
            {
                subStr[i] = subStr[i].Trim();
                intArr[i] = int.Parse(subStr[i]);
            }
            return intArr;

        }
        private void hideInputField2()
        {
            stringBox2.Visible = false;
            label2.Visible = false;
        }
        private void showInputField2()
        {
            stringBox2.Visible = true;
            label2.Visible = true;
        }
        private void calculate1Button_Click(object sender, EventArgs e)
        {
            String newLabel = "";
            List<int> intList;
            switch (comboBox1.SelectedIndex)
            {
                case GREATESTSUBSEQUENCE:
                    newLabel = DynamicProgramming.FindGreatestSubsequence(stringBox1.Text, stringBox2.Text);
                    break;
                case EDITDISTANCE:
                    newLabel = DynamicProgramming.FindEditDistance(stringBox1.Text, stringBox2.Text).ToString();;
                    break;
                case SELECTION:
                    intList = getIntArrayFromString(stringBox1.Text).ToList();
                    int k = int.Parse(stringBox2.Text);
                    newLabel = DivideAndConquer.Selection(intList, k).ToString();
                    break;
                case QUICKSORT:
                    intList = getIntArrayFromString(stringBox1.Text).ToList();
                    DivideAndConquer.QuickSort(intList, false);
                    int i = 0;
                    foreach (int elem in intList)
                    {
                        if (i > 0)
                            newLabel += ", ";
                        newLabel += elem.ToString() ;
                        i++;
                    }
                    break;



            }
            resultValueLabel.Text = newLabel;
            Console.WriteLine(stringBox1.Text + " " + stringBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case GREATESTSUBSEQUENCE:
                    problem3Label.Text = "Find the greatest subsequence between the two strings";
                    resultLabel.Text = "Greatest Subsequence: ";
                    label1.Text = "String 1";
                    label2.Text = "String 2";
                    showInputField2();
                    break;
                case EDITDISTANCE:
                    problem3Label.Text = "Find the edit distance between the two strings";
                    resultLabel.Text = "Edit Distance: ";
                    label1.Text = "String 1";
                    label2.Text = "String 2";
                    showInputField2();
                    break;
                case SELECTION:
                    problem3Label.Text = "Find the kth element in an unsorted integer list";
                    resultLabel.Text = "kth Element: ";
                    label1.Text = "Unsorted Integer List";
                    label2.Text = "k";
                    showInputField2();
                    break;
                case QUICKSORT:
                    problem3Label.Text = "Run Quick Sort on an integer list";
                    resultLabel.Text = "Sorted List: ";
                    label1.Text = "Unsorted Integer List";
                    hideInputField2();
                    break;
            }
            resultValueLabel.Text = "";
        }

        private void dcLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
