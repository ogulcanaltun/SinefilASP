﻿using Microsoft.AspNetCore.Mvc;
using SinemaAppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinemaAppWeb.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null; //_movies isimli boş bir liste oluşturduk.
        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category(){Id=1, Name="Animasyon"},
                new Category(){Id=2, Name="Aksiyon"},
                new Category(){Id=3, Name="Bilim-Kurgu"},
                new Category(){Id=4, Name="Fantastik"},
                new Category(){Id=6, Name="Gerilim"},
                new Category(){Id=7, Name="Komedi"},
                new Category(){Id=8, Name="Korku"},
                new Category(){Id=9, Name="Macera"},
                new Category(){Id=10, Name="Romantik"},
            };
        }

        public static List<Category> Categories //Tüm filmleri geriye döndürecek
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category film) //gönderilen filmi repository'e ekleyecek
        {
            _categories.Add(film);
        }


        public static Category GetById(int id) //gelen id bilgisini karşılaştırıp o id'nin bulunduğu filmi geri gönderecek
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}
