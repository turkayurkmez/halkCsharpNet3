// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
showAllMethods(typeof(string));

generateAndShowRandomNumber();


void generateAndShowRandomNumber()
{
    dynamic randomInstance = Activator.CreateInstance(typeof(Random));
    //object value = randomInstance.GetType().InvokeMember("Next", System.Reflection.BindingFlags.InvokeMethod, null, randomInstance, new object[] { 1, 100 }
    //    );

    int value = randomInstance.Next(1, 100);

    dynamic deger = "Birşey";
    Console.WriteLine(deger.ToUpper());

    DynamicProperty dynamicProperty = new DynamicProperty();
    //dynamicProperty.Sample.Uydurdum = 5;

}

void showAllMethods(Type type)
{
    Console.WriteLine($"{type.Name} isimli tipin metotları");
    Console.WriteLine("----------------------------------------");

    type.GetMethods()
        .ToList()
        .ForEach(m =>
         Console.WriteLine($"{m.ReturnType} {m.Name} ({string.Join(',', m.GetParameters().Select(p => p.ParameterType.Name + " " + p.Name))})"));

}

public class DynamicProperty
{
    public dynamic Sample { get; set; }
}