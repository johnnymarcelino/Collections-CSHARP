using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Csharp.Src {
    public class Classes {
        string Name { get; set; }
        string Type { get; set; }

        public Animal(string name, string type) {
            Name = name;
            Type = type;
        }

        public override string ToString() {
            return $"Type: {Type} & Name: {Name}";
        }
    }

    public class People {
        public string Name { get; set; }
        int Age { get; set; }
        string Hometown { get; set; }

        public People(string name, int age, string hometown) {
            Name = name;
            Age = age;
            Hometown = hometown;
        }

        public override string ToString() {
            return $"Nome: {Name} || Idade: {Age} || Natalidade: {Hometown}";
        }
    }

    public class Livro {
        public string Title { get; set; }
        string Autor { get; set; }
        int NmbrPages { get; set; }

        public Livro(string title, string autor, int nmbrPages) {
            Title = title;
            Autor = autor;
            NmbrPages = nmbrPages;
        }

        public override string ToString() {
            return $"Título: {Title} || Autor: {Autor} || Páginas: {NmbrPages}";
        }
    }
}
