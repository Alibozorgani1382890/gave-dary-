

List<Animal> animals = new List<Animal>()
{
    new Cow () { IsMale = true , Weight=250 , BirthDate=new DateTime(2022,10,05)},
   new Sheep() { IsMale = false, Weight=100,  BirthDate = new DateTime(2021, 06, 07) },
   new Sheep() { IsMale = false, Weight=80,   BirthDate = new DateTime(2021, 06, 07) }
};




foreach (Animal animal in animals)
{
    Console.WriteLine(animal.Life());
}

public abstract class Animal
{
    static Animal()
    {
        TotalNumber = 0;
    }

    public Animal()
    {
        TotalNumber++;
        Number = TotalNumber;
    }

    public static int TotalNumber { get; private set; }
    public int Number { get; private set; }
    public double Weight { get; set; }
    public bool IsMale { get; set; }
    public DateTime BirthDate { get; set; }
    public abstract int Life();


}
public class Cow : Animal
{
    static Cow() { MaxLife = 9125; }
    public static int MaxLife { get; }
    public override int Life()
    {
        int Age = (int)(DateTime.Now - BirthDate).TotalDays;

        return MaxLife - Age;
    }
    public override string ToString() =>
        $"C{(IsMale ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}No{Number}";
}

public class Sheep : Animal
{
    public override int Life()
    {
        int Age = (int)(DateTime.Now - BirthDate).TotalDays;

        return MaxLife - Age;
    }
    static Sheep() { MaxLife = 4380; }
    public static int MaxLife { get; }
    public override string ToString() =>
       $"S{(IsMale ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}No{Number}";

}
public override int CostPerDay()
{
    throw new NotImplementedException();
}

public override int ValuePerDay()
{
    throw new NotImplementedException();
}



public class Environment
{
    public HealthParameter TDS { get; set; }

    public HealthParameter Temperature { get; set; }

    public HealthParameter Density { get; set; }

    public HealthParameter db { get; set; }

    public HealthParameter ADI { get; set; }

    public HealthParameter OX { get; set; }

    public DateTime Date { get; set; }
}

public class HealthParameter
{

}

public class CowParameter
{
    public HealthParameter TimeToStand { get; set; }

    public HealthParameter TimeToDie { get; set; }

    public HealthParameter TimeToRelax { get; set; }

    public HealthParameter NumberOfMeals { get; set; }

    public HealthParameter NumberOfMilkProduction { get; set; }

    public DateTime Date { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}