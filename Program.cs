// CONDICIONALES

// Ejercicio 1
// Console.Write("Ingrese un número: ");

// var numero = Console.ReadLine();

// if (String.IsNullOrEmpty(numero))
// {
//     Console.WriteLine("No se ingresó ningún número.");
// }
// else
// {
//     if (int.Parse(numero) % 2 == 0)
//     {
//         Console.WriteLine("El número es par.");
//     }
//     else
//     {
//         Console.WriteLine("El número es impar.");
//     }
// }

// Ejercicio 2

// Console.WriteLine("Ingrese Nombre: ");

// var usuario = Console.ReadLine();

// if (String.IsNullOrEmpty(usuario))
// {
//     Console.WriteLine("No ingresaste ningun nombre ");
// }
// else
// {

//     Console.WriteLine("El nombre es correcto "+usuario);

// }


// Ejercicio 3

// Console.WriteLine("Ingresa tu Edad: ");
// int edad = int.Parse(Console.ReadLine());

// if (edad < 18 )
// {
//     Console.WriteLine("Eres Menor de edad ");
// }
// else
// {
//     Console.WriteLine("Eres Mayor de edad ");
// }

// Ejercicio 4
// Console.WriteLine("Ingresa un  numero de 1 al 7 que corresponde a un dia de la semana: ");

// int dia = int.Parse(Console.ReadLine());

// switch (dia)
// {
//     case 1:
//         Console.WriteLine("Lunes");
//         break;

//     case 2:
//         Console.WriteLine("Martes");
//         break;

//     case 3:
//         Console.WriteLine("Miercoles");
//         break;

//     case 4:
//         Console.WriteLine("jueves");
//         break;

//     case 5:
//         Console.WriteLine("Viernes");
//         break;

//     case 6:
//         Console.WriteLine("Viernes");
//         break;

//     case 7:
//         Console.WriteLine("Domingo");
//         break;

//     default:
//         Console.WriteLine("Te equivocaste ");
//         break;

// }

// Ejercicio 6

// Console.WriteLine("Introduce el primer numero: ");
// int numero1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Introduce el Segundo numero: ");
// int numero2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Introduce el Tercer numero: ");
// int numero3 = int.Parse(Console.ReadLine());

// int mayor;

// if(numero1 >= numero2 && numero1 >= numero3)
// {
//     mayor = numero1;
// }

// else if( numero2 >= numero1 && numero2 >= numero3 )
// {
//     mayor = numero2;
// }
// else
// {
//     mayor = numero3;
// }

// Console.WriteLine($"Este es el numero mayor {mayor}");

//Ejercicio 7




Console.WriteLine("Ingresa una contraseña: ");
var contraseña = Console.ReadLine();

if(String.IsNullOrEmpty(contraseña))
{
    Console.WriteLine("La constraseña nopuede estar en blanco. ");
}
else
{
    if (contraseña.Length < 8)
    {
        Console.WriteLine("La contraseña es incorrecta. ");

    }
    
    else
    {
        Console.WriteLine("Contraseña conrrecta. ");
    }
}


