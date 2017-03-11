using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace RBot.Player
{
    public partial class PlayerComp : Form
    {
        public PlayerComp()
        {
            InitializeComponent();
        }

        private void PlayerComp_Load(object sender, EventArgs e)
        {
            GenerateTable();
        }

        private void GenerateTable()
        {
            TableLayoutPanel table = tableLayoutPanel1;
            table.ColumnCount = 5;
            table.RowCount = 28;

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));

            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            table.Controls.Add(new Label() { Text = "Hello 1" }, 1, 0);
            table.Controls.Add(new Label() { Text = "Hello 2" }, 2, 0);
            table.Controls.Add(new Label() { Text = "Hello 3" }, 3, 0);

            // For Add New Row (Loop this code for add multiple rows)
            table.RowCount = table.RowCount + 1;
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            table.Controls.Add(new Label() { Text = "Street, City, State" }, 1, table.RowCount - 1);
            table.Controls.Add(new Label() { Text = "888888888888" }, 2, table.RowCount - 1);
            table.Controls.Add(new Label() { Text = "xxxxxxx@gmail.com" }, 3, table.RowCount - 1);
        }

        private int[] ComparePlayer(int[] player1, int[] player2)
        {
            return null;
        }

        private int[] StringToInt(String Text)
        {
            int[] List;

            String[] Array = Text.Split(','); //split data into array
            List = new int[Array.Length]; //init new int array

            for (int i = 0; i < Array.Length; i++)
            {
                // loop and convert each item into int
                List[i] = int.Parse(Array[i].ToString());
            }

            return List;
        }

        private void DatabaseInsert()
        {
            using (SqlCeConnection c = new SqlCeConnection(""))
            {
                c.Open();

                c.Close();
            }
        }
    }
}
