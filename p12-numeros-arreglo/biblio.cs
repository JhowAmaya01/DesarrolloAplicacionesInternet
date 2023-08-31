//Bliblioteca que contiene funciones para manipular un arreglo de numeros

public static class biblio{
    public static void Imprime(double[] a){
        for(int i = 0; i < a.Length; i++)
            Console.Write($"{a[i]:f2} ");
    }
    public static double Suma(double[] a){
        double suma = 0;
        for(int i = 0; i < a.Length; i++)
            suma += a[i];
        return suma;
    }
    public static double Suma2(double[] a){
        double suma = 0, div = 0;
        for(int i = 0; i < a.Length; i++){
            div = a[i] / 2;
            suma += div;
        }
        return suma;
    }
    public static void Imprime2(double[] a){
        for(int i = a.Length - 1; i >= 0; i--)
            Console.Write($"{a[i]:f2} ");
    }
}