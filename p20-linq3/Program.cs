//
List<string> frutas = new() {"pera", "melon", "sandia", "durazno", "manzana", "platano", "kiwi", "naranja", "jicama", "piña", "papaya", "lima", "moras", "lichis", "guamuchiles", "pitayas", "chilitos", "maracuya", "xoconostle"};

var mfrutas = (from f in frutas where f.StartsWith("m") select f).ToList();
Console.WriteLine("\nFrutas que inician con la letra m "+mfrutas.Count());
mfrutas.ForEach(f=>Console.WriteLine(f+" "));

var anfrutas = (from f in frutas where f.Contains("an") select f).ToList();
Console.WriteLine("\n\nFrutas que contienen las letras an "+anfrutas.Count());
mfrutas.ForEach(f=>Console.WriteLine(f+" "));

var frutasa = (from f in frutas where f.Contains("a") select f).ToList();
Console.WriteLine("\n\nFrutas que terminan con la letras a: " + frutasa.Count());
frutasa.ForEach(f=>Console.Write(f + " "));

var xz = (from f in frutas where (f.Contains("x") || f.Contains("z")) select f).ToList();
Console.WriteLine("\n\nFrutas que contienen las letras x y z: " + xz.Count());
xz.ForEach(f=>Console.Write(f + " "));
