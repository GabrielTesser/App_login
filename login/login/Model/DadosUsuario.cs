using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace login.Model
{
    public partial class DadosUsuario : Component
    {
        public DadosUsuario()
        {
            InitializeComponent();
        }

        public DadosUsuario(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
