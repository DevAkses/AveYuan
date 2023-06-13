using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace autentik
{
    public partial class Ulasan : Form
    {
        public Ulasan()
        {
            InitializeComponent();
        }

        private void buttonKomentar_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=ternyatabeda;Database=token"))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO komentar (komentar) VALUES ('@komentar')";
                command.CommandType = CommandType.Text;
                command.Parameters.Add()

            }
        }
    }
}
