namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto) // método estático não usa nada que está fora da função
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}