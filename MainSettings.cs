using Spottyfy;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static MongoDB.Driver.WriteConcern;

public class MainSettings : Form
{
    private Button titleChange;
    private Button iconChange;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private TableLayoutPanel tableLayoutPanel2;
    public MainSettings(Panel p)
    {
        InitializeComponent();
        iconChange.Text = Program.GetLangInstance().Descendants("Icon").FirstOrDefault()?.Value;
        titleChange.Text = Program.GetLangInstance().Descendants("Title").FirstOrDefault()?.Value;
        if (iconChange.Text == "Change App Icon...") { 
            radioButton1.Checked = true;
        }
        else
        {
            radioButton2.Checked = true;
        }
        //this.Resize += new EventHandler(MainSettings_Resize);
    }
    private void InitializeComponent()
    {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.titleChange = new System.Windows.Forms.Button();
            this.iconChange = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.titleChange, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.iconChange, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButton1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.radioButton2, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(199, 214);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // titleChange
            // 
            this.titleChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.titleChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.titleChange.Location = new System.Drawing.Point(3, 69);
            this.titleChange.Name = "titleChange";
            this.titleChange.Size = new System.Drawing.Size(193, 39);
            this.titleChange.TabIndex = 2;
            this.titleChange.Text = "Change App Title...";
            this.titleChange.UseVisualStyleBackColor = false;
            this.titleChange.Click += new System.EventHandler(this.titleChange_Click);
            // 
            // iconChange
            // 
            this.iconChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(91)))));
            this.iconChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.iconChange.Location = new System.Drawing.Point(3, 10);
            this.iconChange.Name = "iconChange";
            this.iconChange.Size = new System.Drawing.Size(193, 39);
            this.iconChange.TabIndex = 1;
            this.iconChange.Text = "Change App Icon...";
            this.iconChange.UseVisualStyleBackColor = false;
            this.iconChange.Click += new System.EventHandler(this.iconChange_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 121);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "English";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 144);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Polski";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // MainSettings
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MainSettings";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.MainSettings_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

    }
    /*private void MainSettings_Resize(object sender, EventArgs e)
    {
        Console.WriteLine(pa.Width+" "+ pa.Height);
        flowLayoutPanel1.Size = new Size(pa.Width, pa.Height);
        tableLayoutPanel1.Size = flowLayoutPanel1.Size;
        int x = (flowLayoutPanel1.ClientSize.Width - tableLayoutPanel1.Width) / 2;
        int y = (flowLayoutPanel1.ClientSize.Height - tableLayoutPanel1.Height) / 2;
        tableLayoutPanel1.Location = new Point(x, y);
    }*/
    private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
    {

    }
    private void iconChange_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Title = "Wybierz .ico...";
            openFileDialog.Filter = ".ico|*.ico|All|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                WriteToConfigFile("settings.cfg", "logo", selectedFilePath);

                Program.SetApplicationIcon(selectedFilePath);
            }
        }
    }
    public static void WriteToConfigFile(string filePath, string key, string value)
    {
        bool found = false;
        try
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Find the line with the specified key and replace its value
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('=');

                if (parts.Length == 2 && parts[0].Trim() == key)
                {
                    found = true;
                    lines[i] = $"{key}={value}";
                    break; // Assuming each key is unique; stop after finding the first match
                }
            }

            // Write the modified content back to the file
            Console.WriteLine(lines);
            File.WriteAllLines(filePath, lines);
            if (!found)
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Write the key-value pair in the format "key=value"
                    writer.WriteLine($"{key}={value}");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not found: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating config file: {ex.Message}");
        }
    }
    private void titleChange_Click(object sender, EventArgs e)
    {
        TitleChange tcForm = new TitleChange();
        tcForm.FormBorderStyle = FormBorderStyle.FixedSingle;
        tcForm.MaximizeBox = false;
        tcForm.MinimizeBox = false;
        tcForm.BackColor = this.BackColor;
        tcForm.Show();
    }
        private void MainSettings_Load(object sender, EventArgs e)
    {

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton1.Checked == true)
        {
            WriteToConfigFile("settings.cfg", "lang", "langs/eng.xml");
            Program.SetApplicationLanguage("langs/eng.xml");
            Application.Restart();
            Environment.Exit(0);
        }
    }
    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton2.Checked == true)
        {
            WriteToConfigFile("settings.cfg", "lang", "langs/pl.xml");
            Program.SetApplicationLanguage("langs/pl.xml");
            Application.Restart();
            Environment.Exit(0);
        }
    }
}