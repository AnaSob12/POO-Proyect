﻿using login.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        private conexion c;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void ingresar()
        {
            clases.usuarios U = new clases.usuarios(textBox1.Text, textBox2.Text);
            DataSet ds = new DataSet();
            c = new clases.conexion(U.CONSULTAR());
            ds = c.consultar();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                Form1 x = new Form1();
                x.Show(); this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña invalidos", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();

            }
        }
    }
}
