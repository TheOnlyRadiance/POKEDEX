﻿using MvvmGuia.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmGuia.VistaModelo.VMpokemon
{
    public class VMdetallepokemoncs : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public Mpokemon parametrosRecibe { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMdetallepokemoncs(INavigation navigation, Mpokemon parametrosTrae)
        {
            Navigation = navigation;
            parametrosRecibe = parametrosTrae;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
