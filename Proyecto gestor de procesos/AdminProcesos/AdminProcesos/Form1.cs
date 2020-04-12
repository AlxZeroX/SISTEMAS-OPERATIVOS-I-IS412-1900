using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AdminProcesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActualizarProcesos();
        }

        //Funcion que va a limpiar y actualizar los procesos
        private void ActualizarProcesos()
        {
            lstprocesos.Items.Clear();
            lstid.Items.Clear();
            lstram.Items.Clear();
            lstvirtual.Items.Clear();
            lstcpu.Items.Clear();
            
            int id = 1;
            foreach (Process procesos in Process.GetProcesses())
            {
                lstprocesos.Items.Add(id + ":" + procesos.ProcessName);
                lstid.Items.Add(id + ":" + procesos.Id);
                lstram.Items.Add(id + ":" + procesos.WorkingSet64);
                lstvirtual.Items.Add(id + ":" + procesos.VirtualMemorySize64);
                lstcpu.Items.Add(id + ":" + procesos.SessionId);
                id = id + 1;
            }
            lbltotalprocesos.Text = "Total de procesos : " + lstprocesos.Items.Count.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea salir del programa?", "Salir" , MessageBoxButtons.YesNo) == DialogResult.Yes) {
                Close();
            }
        }


        private void btnactualizar_Click(object sender, EventArgs e)
        {
            ActualizarProcesos();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process programa in Process.GetProcesses())
                {
                    String seleccion = lstprocesos.SelectedItem.ToString();
                    String[] proceso = seleccion.Split(':');
                    if (programa.ProcessName == proceso[1])
                    {
                        programa.Kill(); //mata el proceso que seleccione
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
