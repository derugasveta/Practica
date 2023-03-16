using System;
using System.Collections;



class MusicCatalogue
{
    private Hashtable discs;

    public MusicCatalogue()
    {
        discs = new Hashtable();
    }

    public void AddDisc(string title)
    {
        discs[title] = new Hashtable();
    }

    public void RemoveDisc(string title)
    {
        discs.Remove(title);
    }

    public void AddSong( string songTitle, string artist)
    {
        Hashtable songs = new Hashtable();
        if (songs != null)
        {
            songs[songTitle] = artist;
        }
    }


   
    

    public void ViewCatalogue()
    {
        foreach (DictionaryEntry disc in discs)
        {
            Console.WriteLine(disc.Key);
            Hashtable songs = (Hashtable)disc.Value;
            if (songs != null)
            {
                foreach (DictionaryEntry song in songs)
                {
                    Console.WriteLine("  " + song.Key + " - " + song.Value);
                }
            }
        }
    }

    static void Main(string[] args)
    {
        MusicCatalogue catalogue = new MusicCatalogue();
        catalogue.AddDisc("Песни 80х");
        catalogue.AddDisc("Песни 90х");
        catalogue.AddDisc("Песни 0х");
        Console.WriteLine($"Каталог дисков");
        catalogue.ViewCatalogue();
        Console.WriteLine();
        Console.WriteLine("Выберите операцию");
        Console.WriteLine("1.Добавить диск \n2.Удалить диск");
        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                Console.WriteLine("Сколько дисков вы хотите добавить?");
                int n = int.Parse(Console.ReadLine());
                if (n >= 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("Введите название диска для добавления");
                        string disk = Console.ReadLine();
                        catalogue.AddDisc(disk);

                    }
                }
                else
                {
                    Console.WriteLine("Вы не хотите добавлять диски");
                }
                break;
            case 2:
                Console.WriteLine("Ведите диск, который хотите добавить");
                string disk2 = Console.ReadLine();
                catalogue.RemoveDisc(disk2);
               
                break;
            default:
                Console.WriteLine("Такого пункта нет");
                break;
        }

        Console.WriteLine();
                Console.WriteLine($"Каталог дисков");
                catalogue.ViewCatalogue();
        Console.WriteLine("Выберите номер диска, чтобы просмотреть информацию");
        int disk3 = int.Parse(Console.ReadLine());
        if (disk3 == 1)
        {
            Console.WriteLine("Песни на этом диске:");
            catalogue.AddSong("Ветер с моря дул","Татьяна Буланова");
            catalogue.AddSong("Чистый","Скриптонит");
            catalogue.AddSong("Половинка","Танцы минус");
        }
        else if (disk3==2)
        {
            Console.WriteLine("Песни на этом диске:");
            catalogue.AddSong("Ясный мой свет", "Татьяна Буланова");
            catalogue.AddSong("Танцуй", "Скриптонит");
            catalogue.AddSong("Паранойа", "Танцы минус");
        }
        else if (disk3==3)
        {

            Console.WriteLine("Песни на этом диске:");
            catalogue.AddSong("Ненаглядный", "Татьяна Буланова");
            catalogue.AddSong("Baby", "Скриптонит");
            catalogue.AddSong("Подожди", "Танцы минус");
        }
        catalogue.ViewCatalogue();

        


    }
}