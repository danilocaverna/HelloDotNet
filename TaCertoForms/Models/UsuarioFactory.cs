using System;
using System.Collections.Generic;
using TaCertoForms.Models;
using Util;
namespace TaCertoForms.Models{
    public class UsuarioFactory{
        public Usuario GetByEmailAndPassword(string email, string senha){
            Usuario usuario = null;
            if(email != "" && senha != "")
                usuario = new Usuario();
            return usuario;
        }
    }
}