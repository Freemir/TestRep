//Single Resp. - Единственная обязанность

//abstract class Tech
//{
//    public abstract void sms();
//    public abstract void call();
//    public abstract void photo();
//}

class Hello
{
    public void helloWorld()
    {
        Console.WriteLine("Hello");
    }
}

//class Phone : Tech
//{
//    public void sms()
//    {

//    }
//    public void call()
//    {

//    }
//}


//Open/Closed - Открыто для считывания, но закрыто для модификации
//class Phone
//{
//    private string name;
//    public string Name() => name;
//}

//L - Прицнип Лисков (Грамотный полиморфизм) Можно заменить главный класс одним из
//его подтипов

//abstract class Person
//{
//    public void move()
//    {

//    }
//    public abstract void attack();
//}

//class Mage : Person {
//    public override void attack()
//    {

//    }
//}

//class Mage : Person
//{
//    public override void attack()
//    {

//    }
//}

//Interface Разделение - прицнип того, чтобы интерфейсы не заставля классы реализовывать не нуные для них свойства

//interface IHero
//{
//    public void swordAttack();
//    public void mageDamage();
//}

//interface IKnight
//{
//    public void swordAttack();

//}

//interface IMage
//{
//    public void mageDamage();
//}

//class Knight : IHero
//{
//    public void mageDamage()
//    {

//    }
//    public void swordAttack()
//    {

//    }

//}

//Dependecy - Логическая связь между сущносятми

//DRY - Не повторяйся

//KISS - Сделай это проще

//YAGNI - От мелкого к большому


//Directions d = Directions;

//if (d == Directions.)
//{
//    Console.WriteLine(d);
//}

//enum Directions
//{
//    left,
//    right,
//    bottom,
//    down
//}
