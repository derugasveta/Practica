using _3;

//1
MyInfo info = new MyInfo("Света");
//Subscriber subscriberVasia = new Subscriber("Vasia");

//2 Подписаться на событие
info.NameСhange += Name_NameСhange;
//info.NameСhange += subscriberVasia.Show;


//3 Вызов метода вызывающий событие
while (true)
{
    Console.Write("Enter name: ");
    string name = Console.ReadLine();
    //name.Change(n);
    info.Name = name;
}


void Name_NameСhange(string message)
{
    Console.WriteLine(message);
}
