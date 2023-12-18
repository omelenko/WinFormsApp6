using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        ApplicationContext db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new ApplicationContext();
            Game gameA = new Game { Id = 1, Name = "Minecraft", Studio = new Studio { Name = "Mojang" }, Style = "Sandbox", ReleaseDate = "18/09/2011", Gamemode = "����-��������������������", Sells = 300000000 };
            Game gameB = new Game { Id = 2, Name = "The Binding of Isaac", Studio = new Studio { Name = "Nicalis" }, Style = "Rogue-like", ReleaseDate = "28/09/2011", Gamemode = "����-��������������������", Sells = 2000000 };
            Game gameC = new Game { Id = 3, Name = "Devil May Cry 3", Studio = new Studio { Name = "Capcom" }, Style = "Slasher", ReleaseDate = "17/02/2005", Gamemode = "������������������", Sells = 1300000 };
            db.Games.Add(gameA);
            db.Games.Add(gameB);
            db.Games.Add(gameC);
            db.SaveChanges();
            dataGridView1.DataSource = db.Games.ToList();
            comboBox1.DataSource = new List<string> { "�� ������ ���", "�� ������ ���䳿", "�� ������ ���䳿 �� ���", "�� ������", "�� ����� �������", "�������� ���" }; comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        dataGridView1.DataSource = db.Games.Where(g => g.Name == textBox1.Text).ToList();
                        break;
                    }
                case 1:
                    {
                        dataGridView1.DataSource = db.Games.Where(g => g.Studio!.ToString() == textBox1.Text).ToList();
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = db.Games.Where(g => g.Name + ", " + g.Studio == textBox1.Text).ToList();
                        break;
                    }
                case 3:
                    {
                        dataGridView1.DataSource = db.Games.Where(g => g.Style == textBox1.Text).ToList();
                        break;
                    }
                case 4:
                    {
                        dataGridView1.DataSource = db.Games.Where(g => g.ReleaseDate!.Contains(textBox1.Text)).ToList();
                        break;
                    }
                default:
                    {
                        dataGridView1.DataSource = db.Games.ToList();
                        break;
                    }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Games.Where(g => g.Gamemode!.Contains("����")).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Games.Where(g => g.Gamemode!.Contains("������")).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Games.Where(g => g.Sells == db.Games.Max(g => g.Sells)).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Games.Where(g => g.Sells == db.Games.Min(g => g.Sells)).ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Games.OrderByDescending(g => g.Sells).Take(3).ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Games.OrderBy(g => g.Sells).Take(3).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("������� �� �� ������ ������ ��� �� �����", "��� �����", "���", -1, -1);
            if (input == "���")
            {
                string input1 = Microsoft.VisualBasic.Interaction.InputBox("������ �����, �����, �����, ���� �����(��/��/����), ����� ���(����/��������������������), ������� �������� ���� ��� ����� ����. ���������: �����,�����,�����...", "��� �����", "", -1, -1);
                List<string> newobject = input1.Split(",").ToList<string>();
                int tempid = db.Games.ToList().IndexOf(db.Games.ToList().Last()) + 2;
                try
                {
                    db.Games.Add(new Game { Id = tempid, Name = newobject[0], Studio = new Studio { Name = newobject[1] }, Style = newobject[2], ReleaseDate = newobject[3], Gamemode = newobject[4], Sells = int.Parse(newobject[5]) });
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("�������. " + ex.Message); //Don't Starve,Studio,Sandbox,23/11/2006,����-��������������������,1
                }
            }
            else if(input == "�����")
            {
                string input2 = Microsoft.VisualBasic.Interaction.InputBox("������ ����� ���䳿, ����� �� � ����� ����� ����, ���� �� �������������� ��볿 ���䳿 ����� ���� ����� ����. ���������: �����,�����-�����-�����,̳���-̳���-̳���...", "��� �����", "", -1, -1);
                List<string> newobject = input2.Split(",").ToList<string>();
                List<string> countries = newobject[1].Split("-").ToList<string>();
                List<string> cities = newobject[2].Split("-").ToList<string>();
                int tempid = db.Studios.ToList().IndexOf(db.Studios.ToList().Last()) + 2;
                try
                {
                    db.Studios.Add(new Studio { Id = tempid, Name = newobject[0], Countries = countries, Filias = cities});
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("�������. " + ex.Message); 
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("������ id ��� ��� �����������.", "����������� �����", "1", -1, -1);
            int productid;
            bool success = int.TryParse(input, out productid);

            string input1 = Microsoft.VisualBasic.Interaction.InputBox("������� �� �� ������ ���������� ��� �� �����", "����������� �����", "���", -1, -1);
            if (input == "���")
            {
                string input2 = Microsoft.VisualBasic.Interaction.InputBox("������ �����, �����, �����, ���� �����(��/��/����), ����� ���(����/��������������������), ������� �������� ���� ��� ����� ����. ���������: �����,�����,�����...", "����������� �����", "", -1, -1);
                List<string> newobject = input2.Split(",").ToList<string>();
                var query = db.Games.Where(g => g.Id == productid).ToList();
                foreach (var a in query)
                {
                    db.Games.Remove(a);
                    db.SaveChanges();
                }
                db.Games.Add(new Game { Id = productid, Name = newobject[0], Studio = new Studio { Name = newobject[1] }, Style = newobject[2], ReleaseDate = newobject[3], Gamemode = newobject[4], Sells = int.Parse(newobject[5]) });
                db.SaveChanges();
            }
            else if (input == "�����")
            {
                string input2 = Microsoft.VisualBasic.Interaction.InputBox("������ ����� ���䳿, ����� �� � ����� ����� ����, ���� �� �������������� ��볿 ���䳿 ����� ���� ����� ����. ���������: �����,�����-�����-�����,̳���-̳���-̳���...", "����������� �����", "", -1, -1);
                List<string> newobject = input2.Split(",").ToList<string>();
                List<string> countries = newobject[1].Split("-").ToList<string>();
                List<string> cities = newobject[2].Split("-").ToList<string>();
                var query = db.Studios.Where(g => g.Id == productid).ToList();
                foreach (var a in query)
                {
                    db.Studios.Remove(a);
                    db.SaveChanges();
                }
                db.Studios.Add(new Studio { Id = productid, Name = newobject[0], Countries = countries, Filias = cities });
                db.SaveChanges();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("������� �� �� ������ �������� ��� �� �����", "��������� �����", "���", -1, -1);
            if (input == "���")
            {
                string input1 = Microsoft.VisualBasic.Interaction.InputBox("������ ����� �� ����� ��� ��� �� ������ �������� ����� ����. ���������: �����,�����", "��������� �����", "Minecraft,Mojang", -1, -1);
                var query = db.Games.Where(g => (g.Name + "," + g.Studio) == input1).ToList();
                var success = MessageBox.Show("�� ������� �� ������ �������� �� ���?", "�����", MessageBoxButtons.YesNo);
                if (success == DialogResult.Yes)
                {
                    foreach (var a in query)
                    {
                        db.Games.Remove(a);
                        db.SaveChanges();
                    }
                }
            }
            else if (input == "�����")
            {
                string input1 = Microsoft.VisualBasic.Interaction.InputBox("������ ����� ���䳿 ��� �� ������ ��������.", "��������� �����", "", -1, -1);
                var query = db.Studios.Where(g => g.Name == input1).ToList();
                var success = MessageBox.Show("�� ������� �� ������ �������� �� �����?", "�����", MessageBoxButtons.YesNo);
                if(success == DialogResult.Yes)
                {
                    foreach(var a in query)
                    {
                        db.Studios.Remove(a);
                        db.SaveChanges();
                    }
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Games.Select(s => new { Name = "����������������", Count = db.Games.Where(b => b.Gamemode!.Contains("����")).Count() }).ToList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Games.Select(s => new { Name = "������������������", Count = db.Games.Where(b => b.Gamemode!.Contains("������")).Count() }).ToList();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("������ ����� �����.", "��� �����", "", -1, -1);
            dataGridView1.DataSource = db.Studios.Where(b => b.Name == db.Games.Where(s => s.Style == input && s.Sells == db.Games.Max(d => d.Sells)).First().Studio!.Name).ToList();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("������ ����� �����.", "��� �����", "", -1, -1);
            dataGridView1.DataSource = db.Games.OrderByDescending(g => g.Sells).Where(g => g.Style == input).Take(5).ToList();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("������ ����� �����.", "��� �����", "", -1, -1);
            dataGridView1.DataSource = db.Games.OrderBy(g => g.Sells).Where(g => g.Style == input).Take(5).ToList();
        }
    }
}
