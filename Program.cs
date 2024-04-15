Console.WriteLine("Bienvenido a la calculadora que acción desea realizar?");
Console.WriteLine("""   1.- Multiplicar 2.- Dividir 3.-Sumar 4.- Restar  // Seleccione un numero !""");

int controler = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el primer numero");

int number_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");

int number_2 = int.Parse(Console.ReadLine());

int result = 0;
int result_2 = 0;

if (controler == 1){
    result = number_1 * number_2;
    Console.WriteLine($"El resultado es:{result}");

}else if( controler == 2){
    if (number_2 != 0){
        result = number_1 / number_2;
        result_2 = number_1 % number_2;
        Console.WriteLine($"El resultado es:{result}");
        Console.WriteLine($"Con residuo:{result_2}");
    }else{
        Console.WriteLine("No se puede dividir entre 0!!");
    }

}else if ( controler == 3){
    result = number_1 + number_2;
    Console.WriteLine($"El resultado es:{result}");

}else if ( controler == 4){
    result = number_1 - number_2;
    Console.WriteLine($"El resultado es:{result}");

}
