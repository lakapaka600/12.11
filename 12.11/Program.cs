static float Velocita(float sRuota, float dRuota)
{
    float km = dRuota / sRuota;
    km = km * (float)3.6;
    return km;
}

float sRuota
    float dRuota;


while (!float.TryParse(Console.ReadLine(), out dRuota))
{
    Console.WriteLine("errore");

} while (!float.TryParse(Console.ReadLine(), out sRuota))
{
    Console.WriteLine("errore");

}
float velocita = Velocita(sRuota, dRuota);
Console.WriteLine($"velocita : {velocita}");
