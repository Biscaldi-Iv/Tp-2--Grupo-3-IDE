﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioLogic(UsuarioAdapter userdata)
            {
            this.UsuarioData = userdata;
            }

        private Data.Database.UsuarioAdapter _UsuarioData;
        public Data.Database.UsuarioAdapter UsuarioData
        {
            get {return this._UsuarioData; }
            set { this._UsuarioData = value; }
        }

        private List<Usuario> usuarios;

        public List<Usuario> Usuarios
        {
            get
            {
                if (usuarios == null)
                {
                    usuarios = this.GetAll();
                }
                return usuarios;
            }
        }


        public List<Usuario> GetAll() 
        {
            return this.UsuarioData.GetAll();
        }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public void Delete(int id)
        {
            this.UsuarioData.Delete(id);
        }

        public void Save(Usuario usr)
        {
            this.UsuarioData.Save(usr);
        }

    }
}
