using System;
using System.Collections.Generic;
using System.Text;
using MvvmGuia.Modelo;
using MvvmGuia.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Reactive.Linq;
using Firebase.Database;
using System.Collections.ObjectModel;

namespace MvvmGuia.Datos
{
    public class Dpokemon
    {
        public async Task Insertarpokemon(Mpokemon parametros) 
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .PostAsync(new Mpokemon()
                {
                    Colorfondo = parametros.Colorfondo,
                    Colorpoder = parametros.Colorpoder,
                    Icono = parametros.Icono,
                    Nombre = parametros.Nombre,
                    Nroorden = parametros.Nroorden,
                    Poder = parametros.Poder
                }
                );
        }
        public async Task<ObservableCollection<Mpokemon>> MostrarPokemones() 
        {
            //PARA QUE BORRAS ESTA MADRE??????????????????????????????????
            //NAMBRE PROFE ESTE VATO SI SE PASO DE LANZA 
            //return (await Cconexion.firebase
            //    .Child("Pokemon")
            //    .OnceAsync<Mpokemon>())
            //    .Select(item => new Mpokemon 
            //    {
            //        Idpokemon = item.Key,
            //        Nombre = item.Object.Nombre,
            //        Colorfondo = item.Object.Colorfondo,
            //        Colorpoder = item.Object.Colorpoder,
            //        Nroorden = item.Object.Nroorden,
            //        Poder = item.Object.Poder,
            //        Icono= item.Object.Icono
            //    }
            //    ).ToList();

            var data = await Task.Run(() => Cconexion.firebase
            .Child("Pokemon")
            .AsObservable<Mpokemon>()
            .AsObservableCollection()
            );
            return data;
        }
    }
}
