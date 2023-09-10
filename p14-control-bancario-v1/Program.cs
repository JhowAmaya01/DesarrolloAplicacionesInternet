//Programa que simula un control bancario

//probar Clase bancaria
CuentaBancaria cuenta = new CuentaBancaria(100);
cuenta.Deposita(200);
Console.WriteLine($"Saldo: {cuenta.Saldo}");
cuenta.Retira(150);
if(cuenta.Retira(1500)) Console.WriteLine("Retiro Existoso!!");
else Console.WriteLine("Saldo insuficiente");
Console.WriteLine($"Saldo: {cuenta.Saldo}");

//probar clase cliente
Cliente cliente1 = new Cliente("Juan Carlos", "jcarlos@gmail.com", cuenta);
cliente1.Cuenta.Deposita(1500);
Console.WriteLine($"\n\nDatos del cliente: {cliente1.ToString()}");
Console.WriteLine($"Saldo cuenta: {cliente1.Cuenta.Saldo}");
Cliente cliente2 = new Cliente("Paola Diaz", "pdiaz@gmail.com", new CuentaBancaria(450));
Console.WriteLine($"\nDatos del cliente: {cliente2.ToString()}");
Console.WriteLine($"Saldo cuenta: {cliente2.Cuenta.Saldo}");

//probar clase banco
Banco mibanco = new Banco("Banco del bienestar", "En mi casa");
mibanco.AgregarCliente(cliente1);
mibanco.AgregarCliente(cliente2);
mibanco.AgregarCliente(new Cliente("Xochitl Marquez","xMArquez@gmail.com", new CuentaBancaria(200)));
mibanco.Clientes[2].Cuenta.Deposita(500);
Console.WriteLine(mibanco.ToString());
Console.WriteLine($"\n\nEl banco tiene {mibanco.Clientes.Count} clientes");
foreach(Cliente cl in mibanco.Clientes){
    Console.WriteLine($"Cliente: {cl.ToString()}");
    Console.WriteLine($"Saldo: {cl.Cuenta.Saldo}");
}