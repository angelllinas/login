using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;

namespace login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Panel_title_Paint(object sender, PaintEventArgs e)
        {
           
        }
  
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Connect.conn();
            MessageBox.Show("Conexión exitosa con la base de datos");
        }

        private void Panel_title_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pb_exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void pb_exit_MouseEnter(object sender, System.EventArgs e)
        {
            pb_exit.BackColor = Color.Red;
        }

        private void pb_exit_MouseLeave(object sender, System.EventArgs e)
        {
            pb_exit.BackColor = Color.RoyalBlue;
        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            Connect.conn();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM usuarios WHERE usuario='" + tb_nombre.Text
                + "' AND contraseña='" + tb_contraseña.Text + "'", Connect.conn());

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new Form2().Show();
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }
    }
}
