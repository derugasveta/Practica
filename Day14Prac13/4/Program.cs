using _4;

Blogger blogger = new Blogger("Pokrov");

Subscriber1 subscriber1 = new Subscriber1("Sveta");
Subscriber2 subscriber2 = new Subscriber2("Valya");
blogger.Pub(true);
if (false)
{
    blogger.Attach(subscriber1);
    blogger.Attach(subscriber2);
}
else
{
    blogger.Detach(subscriber1);
    blogger.Detach(subscriber2);
}


