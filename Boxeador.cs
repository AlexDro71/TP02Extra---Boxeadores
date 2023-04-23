class Boxeador{
public string nombre { get; private set;}
public string pais { get; private set;}
public int peso  { get; private set;}
public int potenciaGolpes  { get; private set;}
public int velocidadPiernas  { get; private set;}

public Boxeador(string name, string nac, int wgh, int strgth, int speed){
nombre = name;
pais = nac;
peso = wgh;
potenciaGolpes = strgth;
velocidadPiernas = speed;
}

public int obtenerSkill(){
int vel = velocidadPiernas*6/10;
int fuerza = potenciaGolpes*8/10;
int rnd = random(1, 10);
int skill = vel + fuerza + rnd;
return skill;
}

public static int random(int inicio, int fin)
        {
            int n;
            Random random = new Random();
            n = random.Next(inicio, fin);
            return n;
        }
}

