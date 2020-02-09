using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Libreria de funciones absolutamente necesarias
/// para que todo el modelo funcione
/// </summary>
namespace Library
{
    /// <summary>
    /// En esta clase se utiliza para interactuar con el Modelo
    /// </summary>
    public class Modelo
    {
        /// <summary>
        /// Propiedad de solo lectura que devuelve el nombre del Objeto
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Construye un objeto pasándole como argumento el nombre
        /// </summary>
        /// <param name="name">Texto con el nombre</param>
        public Modelo (string name)
        {
            Name = "Bartolo";
        }
        

    }
}
