using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prac9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void surname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                button_left.Enabled = false;
                button_right.Enabled = false;
            }
            else
            {
                button_left.Enabled = true;
                button_right.Enabled = true;
            }
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex--;
            }
            else
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex++;
            }
            else
            {
                listBox1.SelectedIndex = 0;
            }
        }

        // // //

        private void savefile_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (var item in listBox1.Items)
            {
                list.Add(item.ToString());
            }
            File.WriteAllLines("1.txt", list);
            MessageBox.Show("Данные успешно сохранены в файл!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void loadfile_Click(object sender, EventArgs e)
        {
            string fileName = "1.txt";


            if (!File.Exists(fileName))
            {
                MessageBox.Show("Файл не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(fileName);
            listBox1.Items.Clear();
            listBox1.Items.Add(lines);
            MessageBox.Show("Данные успешно загружены из файла!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // // //

        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(surname.Text) || string.IsNullOrWhiteSpace(name.Text))
            {
                MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (listBox1.Items.Contains(surname.Text + " " + name.Text))
            {
                MessageBox.Show("Это имя уже имеется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool csurname = true;
                bool cname = true;

                for (int i = 0; i < surname.Text.Length; i++)
                {
                    if (!char.IsLetter(surname.Text[i]) && !char.IsWhiteSpace(surname.Text[i]))
                    {
                        csurname = false;
                        break;
                    }
                }

                for (int i = 0; i < name.Text.Length; i++)
                {
                    if (!char.IsLetter(name.Text[i]) && !char.IsWhiteSpace(name.Text[i]))
                    {
                        cname = false;
                        break;
                    }
                }

                if (!csurname || !cname)
                {
                    MessageBox.Show("Введите только слова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    listBox1.Items.Add(surname.Text + " " + name.Text);
                }
            }
        }


        private void button_edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (string.IsNullOrWhiteSpace(surname.Text) || string.IsNullOrWhiteSpace(name.Text))
                {
                    MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int selectedIndex = listBox1.SelectedIndex;

                    listBox1.Items.RemoveAt(selectedIndex);

                    listBox1.Items.Insert(selectedIndex, surname.Text + " " + name.Text);

                    listBox1.ClearSelected();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите поле!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_paste_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(surname.Text) || string.IsNullOrWhiteSpace(name.Text))
            {
                MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newitem = surname.Text + " " + name.Text;

            if (listBox1.Items.Contains(newitem))
            {
                MessageBox.Show("Это имя уже имеется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string item = listBox1.Items[i].ToString();
                if (string.Compare(newitem, item) < 0)
                {
                    listBox1.Items.Insert(i, newitem);
                    return;
                }
            }

            listBox1.Items.Add(newitem);
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        
        private void button_sort_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
