using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaNetCore.Models;

namespace SistemaNetCore.Data
{
    public class DbInitializer
    {
        /// <summary>
        /// Método para inicializar la base de datos
        /// </summary>
        /// <param name="context">Contexto de la BD</param>
        public static void Initialize(SistemaNetCoreContext context)
        {
            //Crear la base de datos
            context.Database.EnsureCreated();
            //Registrar datos de prueba
            //Buscar si existen registros en la tabla categoria
            if (context.Categoria.Any())
            {
                return;
            }
            //Instacia de la clase del modelo
            var categorias = new Categoria[]
            {
                new Categoria{ Nombre = "Programación", Descripcion = "Cursos de programación", Estado = true },
                new Categoria{ Nombre = "Diseño gráfico", Descripcion = "Cursos de diseño gráfico", Estado = true }
            };
            //Recorre el arreglo para agregar los datos a la tabla de bd
            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            //Guarda los cambios realizados
            context.SaveChanges();
        }
    }
}
