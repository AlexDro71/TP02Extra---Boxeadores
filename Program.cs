Boxeador box1 = new Boxeador("", "", 1, 1, 1), box2 = new Boxeador("", "", 1, 1, 1);
int op = ingresarInt("1. Cargar Datos Boxeador 1.\n2. Cargar Datos Boxeador 2.\n3. Pelar.\n4. Salir");
while (op != 4)
{
    switch (op)
    {
        case 1:
           box1 = cargarBoxeador1();
            break;
        case 2:
            box2 = cargarBoxeador2();
            break;
        case 3:
          Pelea(box1, box2);
            break;
    }
   op = ingresarInt("1. Cargar Datos Boxeador 1.\n2. Cargar Datos Boxeador 2.\n3. Pelar.\n4. Salir");
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

 while (num < 1 || num > 100){
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

Boxeador box = new Boxeador(nombre, pais, peso, velocidadPiernas, potenciaGolpes);
return box;
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

Boxeador box = new Boxeador(nombre, pais, peso, velocidadPiernas, potenciaGolpes);
return box;
}

static void Pelea(Boxeador box1, Boxeador box2){
int skill1 = box1.obtenerSkill();
int skill2 = box2.obtenerSkill();
int diferencia = diffPuntos(skill1, skill2);
string ganador;
if(skill1>skill2){
    ganador = box1.nombre;
}else{
ganador = box2.nombre;
}
  if(diferencia>30){
Console.WriteLine("Gano " + ganador + " por KO");
    }else if(diferencia<30 && diferencia>10){
    Console.WriteLine("Gano " + ganador + " por puntos en fallo unánime");
    }else{
Console.WriteLine("Gano " + ganador + " por puntos en fallo dividido");
    }
}

static int diffPuntos(int num1, int num2){
int diff;
if(num1>num2){
    diff = num1 - num2;
}else{
    diff = num2 - num1;
}

    return diff;
}