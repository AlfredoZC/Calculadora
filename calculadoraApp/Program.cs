using System.Diagnostics;

bool runner  = true ;

while (runner == true){


Console.WriteLine("Bienvenido a la calculadora que acción desea realizar?");
Console.WriteLine("""   1.- Multiplicar 2.- Dividir 3.-Sumar 4.- Restar 5.-Elevar a potencia  // Seleccione un numero !""");

int controler = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el primer numero");

int number_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero / o potencia en caso de haber elegido potenciación");

int number_2 = int.Parse(Console.ReadLine());

double result = 0;
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

}else if(controler == 5){

    Convert.ToDouble(number_1);
    Convert.ToDouble(number_2);
    
    result = Math.Pow( Convert.ToDouble(number_1), Convert.ToDouble(number_2));
    Console.WriteLine($"El resultado es: {result}");

}else{
    Console.WriteLine("Parece que no quieres seguir continuando o ingresaste un numero mayo al rango especificado");
}

bool answer = true;

while(answer == true){

Console.WriteLine("Deseas continuar usando la calculadora ?? 1.- SI // 2.- NO ");

int controler2 = int.Parse(Console.ReadLine());

if(controler2 == 1 ){
    runner = true;
    answer = false;
    break;
}else if( controler2  == 2 ){
    runner = false;
    answer = false;
    break;
} else {
    Console.WriteLine("Ingrese valores entre 1 y 2");
}

}//While 2 "fin" 

}//While 1 "fin"
