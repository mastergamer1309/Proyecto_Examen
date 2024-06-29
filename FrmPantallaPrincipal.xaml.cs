﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyecto_Examen
{
    /// <summary>
    /// Interaction logic for FrmPantallaPrincipal.xaml
    /// </summary>
    public partial class FrmPantallaPrincipal : Window
    {
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnPresupuestoMaestro_Click(object sender, RoutedEventArgs e)
        {
            FrmPantallaPrincipal frmPantallaPrincipal = new FrmPantallaPrincipal();
            FrmPresupuestoMaestro frmPresupuestoMaestro = new FrmPresupuestoMaestro();

            frmPresupuestoMaestro.Show();
            
            this.Close();

        }
    }
}
