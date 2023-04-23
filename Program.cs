int op = ingresarInt("1. Cargar Datos Boxeador 1.\n2. Cargar Datos Boxeador 2.\n3. Pelar.\n4. Salir");
while (op != 4)
{
    switch (op)
    {
        case 1:
           cargarBoxeador1();
            break;
        case 2:
            cargarBoxeador2();
            break;
        case 3:
          
            break;
    }
}
static int ingresarInt(string txt)
{
    int num;
    Console.WriteLine(txt);
    num = int.Parse(Console.ReadLine());
    return num;
}
static string ingresarString(string txt)
{
    string str;
    Console.WriteLine(txt);
    str = Console.ReadLine();
    return str;
}

static int validarInt(string txt, int num){
bool condicion = num>100 && num<1;
while(condicion){
Console.WriteLine("El numero ingresado no es valido, vuelva a ingresar");
num = ingresarInt(txt);
}
return num;
}
static Boxeador cargarBoxeador1(){
string pais, nombre;
int peso, velocidadPiernas, potenciaGolpes;
nombre = ingresarString("Ingrese el nombre del Boxeador1");
pais = ingresarString("Ingrese la nacionalidad del Boxeador1");
peso = ingresarInt("Ingrese el peso del Boxeador1");
velocidadPiernas = ingresarInt("Ingrese la velocidad de piernas del Boxeador1(Entre 1 y 100)");
velocidadPiernas = validarInt("Ingrese la velocidad de piernas del Boxeador1(Entre 1 y 100)", velocidadPiernas);
potenciaGolpes = ingresarInt("Ingrese la potencia de golpe del Boxeador1(Entre 1 y 100)");
potenciaGolpes = validarInt("Ingrese la potencia de golpe del Boxeador1(Entre 1 y 100)" ,potenciaGolpes);

Boxeador box1 = new Boxeador(nombre, pais, peso, velocidadPiernas, potenciaGolpes);
return box1;
}

static Boxeador cargarBoxeador2(){
string pais, nombre;
int peso, velocidadPiernas, potenciaGolpes;
nombre = ingresarString("Ingrese el nombre del Boxeador2");
pais = ingresarString("Ingrese la nacionalidad del Boxeador2");
peso = ingresarInt("Ingrese el peso del Boxeador2");
velocidadPiernas = ingresarInt("Ingrese la velocidad de piernas del Boxeador2(Entre 1 y 100)");
velocidadPiernas = validarInt("Ingrese la velocidad de piernas del Boxeador2(Entre 1 y 100)", velocidadPiernas);
potenciaGolpes = ingresarInt("Ingrese la potencia de golpe del Boxeador2(Entre 1 y 100)");
potenciaGolpes = validarInt("Ingrese la potencia de golpe del Boxeador2(Entre 1 y 100)", potenciaGolpes);

Boxeador box1 = new Boxeador(nombre, pais, peso, velocidadPiernas, potenciaGolpes);
return box1;
}
