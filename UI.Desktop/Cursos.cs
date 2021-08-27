﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Cursos : ApplicationForm
    {
        private CursosLogic cl;
        
        public Cursos()
        {
            InitializeComponent();
            this.cl = new CursosLogic();
            this.Listar();
        }

        public void Listar()
        {
            this.dgvCursos.AutoGenerateColumns = false;
            try
            {
                this.dgvCursos.DataSource = cl.getAll();
            }
            catch (Exception e)
            {
                Notificar("Error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursosDesktop frmCurso = new CursosDesktop(ModoForm.Alta);
            frmCurso.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int _id= ((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
            CursosDesktop frmCurso = new CursosDesktop(_id, ModoForm.Modificacion);
            frmCurso.ShowDialog();
            this.Listar();
        }

        private void tsbVer_Click(object sender, EventArgs e)
        {
            int _id = ((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
            CursosDesktop frmCurso = new CursosDesktop(_id, ModoForm.Consulta);
            frmCurso.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            Notificar("Advertencia", "No disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            switch (Program.tipo.Descripcion)
            {
                case "Alumno":
                    {
                        this.tsABMC.Hide();
                        break;
                    }                
            }
        }
    }
}
