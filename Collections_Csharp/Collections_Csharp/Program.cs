using System;
using System.Collections.Generic;
using Collections_Csharp.Src;
using Polimorfismo01.src;

namespace Polimorfismo01.src {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine(" Animals ");
            CList();

            Console.WriteLine("\n Peoples ");
            CQueue();

            Console.WriteLine("\n Books ");
            CStack();

            Console.WriteLine("\n\n Dictionary ");
            CDictionary();
        }

        static void CList() {
            List<Animal> animals = new List<Animal> {
                new Animal("Aguia", "Flyer"),
                new Animal("Tatu", "Land"),
                new Animal("Peixe", "Marine"),
                new Animal("Foca", "Marine")
            };

            animals.Insert(2, new Animal("Cat", "Land"));

            animals.RemoveAt(animals.Count - 1);
            animals.RemoveAt(1);

            foreach (var item in animals) {
                Console.WriteLine(item.ToString());
            }
        }

        static void CQueue() {
            Queue<People> Peoples = new Queue<People>();

            Peoples.Enqueue(new People("Johnny", 26, "São Paulo"));
            Peoples.Enqueue(new People("Italo", 20, "Taboão"));
            Peoples.Enqueue(new People("Alan", 22, "Vila Olimpia"));
            Peoples.Enqueue(new People("Cintia", 24, "Goiania"));
            Peoples.Enqueue(new People("Migiel", 30, "Curitiba"));

            Console.WriteLine($"First the line: {Peoples.Dequeue().Name}");
            Console.WriteLine($"{Peoples.Peek().Name} was removed.");

            Peoples.Peek();

            Console.WriteLine($"Only {Peoples.Count} Peoples in the line");

            foreach (var item in Peoples) {
                Console.WriteLine(item.ToString());
            }
        }

        static void CStack() {
            Stack<Livro> livros = new();

            livros.Push(new Livro("O Mundo Assombrado Pelos Demônios", " Carl Sagan", 509));
            livros.Push(new Livro("1984", " George Orwell", 416));
            livros.Push(new Livro("As aventuras de Sherlock Holmes", "Arthur Conan Doyle", 416));

            Console.WriteLine($"The first book of the stack is: {livros.Peek().Title}");
            Console.WriteLine($"{livros.Peek().Title} was removed of the stack");

            livros.Pop();

            Console.WriteLine($"Qauntity of book on the stack: {livros.Count}");

            foreach (var item in livros) {
                Console.WriteLine(item.ToString());
            }
        }

        static void CDictionary() {
            Dictionary<String, String> dic = new();

            dic.Add("Persistência", "É quando persistimos no nosso alvo/objetivo mesmo diante dos obstáculos e dificuldades.");
            dic.Add("Mentalidade de Crescimento", "Quando acreditamos que nossas qualidades podem sempre ser cultivadas, o que nos leva a usar críticas, dificuldades e desafios como o ponto de partida para o desenvolvimento.");
            dic.Add("Responsabilidade Peoplel", "Assumir a responsabilidade pelas próprias ações, trabalhar duro, manter os compromissos, e não dar desculpas.");
            dic.Add("Orientação ao Futuro", "Significa criar um roteiro para o seu futuro, compreender como as ações de hoje impactam seus objetivos e verificar seu progresso com frequência.");
            dic.Add("Comunicação", "Saber transmitir a mensagem, ser claro e objetivo");
            dic.Add("Orientação ao Detalhe", "Prestar atenção nas poucas coisas, nas mínimas e pequenas coisas que parecem irrelevantes, mas, que podem trazer graves consequências");
            dic.Add("Proatividade", "Significa assumir a liderança em seu emprego sem nenhum impulso de seu gerente ou de outras Peoples, antecipando situações e tomando as ações preventivas que forem necessárias.");
            dic.Add("Trabalho em Equipe", "Pode ser definido como a capacidade dos membros da equipe de trabalharem juntos, comunicarem-se efetivamente, anteciparem-se e atenderem às demandas uns dos outros, e inspirar confiança, resultando em uma ação coletiva coordenada.");

            foreach (KeyValuePair<String, String> kvp in dic) {
                Console.WriteLine(kvp.Key);
                Console.WriteLine("========================");
                Console.WriteLine(kvp.Value + "\n");

            }
        }
    }
}
