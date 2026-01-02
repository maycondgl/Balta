using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma tag");
            Console.WriteLine("--------------------");

            Console.Write("Id: ");
            var idInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(idInput) || !int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Id inválido.");
                Console.ReadKey();
                MenuTagScreen.Load();
                return;
            }

            Console.Write("Nome: ");
            var name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("O nome não pode ser vazio.");
                Console.ReadKey();
                MenuTagScreen.Load();
                return;
            }

            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(slug))
            {
                Console.WriteLine("O slug não pode ser vazio.");
                Console.ReadKey();
                MenuTagScreen.Load();
                return;
            }

            Update(new Tag
            {
                Id = id,
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuTagScreen.Load();
        }


        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}