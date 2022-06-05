using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheCapitalBurguer.Models;

namespace TheCapitalBurguer.Repository
{
    public class MenuRepository
    {
        public List<Menu> ObtenerMenu()
        {
            return new List<Menu>()
            {
                new Menu()
                {
                    Id = 1,
                    Nombre = "Hamburguesa Sencilla",
                    Precio = 35
                },
                new Menu()
                {
                    Id = 2,
                    Nombre = "Hamburguesa Hawaiana",
                    Precio = 40
                },
                new Menu()
                {
                    Id = 3,
                    Nombre = "Hamburguesa Especial",
                    Precio = 45
                },
                new Menu()
                {
                    Id = 4,
                    Nombre = "Hamburguesa Doble Carne con Tocino",
                    Precio = 50
                },
                new Menu()
                {
                    Id = 5,
                    Nombre = "Hamburguesa Doble Carne Rellena de Queso",
                    Precio = 55
                },
                new Menu()
                {
                    Id = 6,
                    Nombre = "Hamburguesa Doble Carne Rellena de Queso y Tocino",
                    Precio = 60
                },
                new Menu()
                {
                    Id = 7,
                    Nombre = "Hamburguesa Sencilla (Arrachera)",
                    Precio = 45
                },
                new Menu()
                {
                    Id = 8,
                    Nombre = "Hamburguesa Hawaiana (Arrachera)",
                    Precio = 50
                },
                new Menu()
                {
                    Id = 9,
                    Nombre = "Hamburguesa Especial (Arrachera)",
                    Precio = 55
                },
                new Menu()
                {
                    Id = 10,
                    Nombre = "Hamburguesa Doble Carne con Tocino (Arrachera)",
                    Precio = 60
                },
                new Menu()
                {
                    Id = 11,
                    Nombre = "Hamburguesa Doble Carne Rellena de Queso (Arrachera)",
                    Precio = 65
                },
                new Menu()
                {
                    Id = 12,
                    Nombre = "Hamburguesa Doble Carne Rellena de Queso y Tocino (Arrachera)",
                    Precio = 80
                },
                new Menu()
                {
                    Id = 13,
                    Nombre = "Hot Dog Sencillo",
                    Precio = 15
                },
                new Menu()
                {
                    Id = 14,
                    Nombre = "Hot Dog Choriqueso",
                    Precio = 20
                },
                new Menu()
                {
                    Id = 15,
                    Nombre = "Hot Dog Hawaiano",
                    Precio = 20
                },
                new Menu()
                {
                    Id = 16,
                    Nombre = "Hot Dog Pepperoni",
                    Precio = 20
                },
                new Menu()
                {
                    Id = 17,
                    Nombre = "Hot Dog Tocino con Queso",
                    Precio = 20
                },
                new Menu()
                {
                    Id = 18,
                    Nombre = "Hot Dog con Sabritas",
                    Precio = 20
                },
                new Menu()
                {
                    Id = 19,
                    Nombre = "Salchipapas",
                    Precio = 35
                },
                new Menu()
                {
                    Id = 20,
                    Nombre = "PizzaBurguer",
                    Precio = 70
                },
                new Menu()
                {
                    Id = 21,
                    Nombre = "Paspas a la Francesa",
                    Precio = 30
                },
            };
        }
    }
}
