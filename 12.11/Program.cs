﻿static float Velocita(float sRuota, float dRuota)
{
    float km = dRuota / sRuota;
    km = km * (float)3.6;
    return km;
}

float sRuota, dRuota;

do
{
    Console.Write("Sruota: ");
} while (!float.TryParse(Console.ReadLine(),out sRuota));

do
{
    Console.Write("Druota: ");
    
} while (!float.TryParse(Console.ReadLine(), out dRuota));
float velocita = Velocita(sRuota, dRuota);
Console.WriteLine($"velocita : {velocita}");
