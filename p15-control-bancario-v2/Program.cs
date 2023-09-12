//Control bancario v2


//cremos un banco
Banco mibanco = new Banco ("Banco de Jhohana", "Mi casa #105");

//Agregamos dos clientes al banco (Forma 1)
mibanco.AgregarCliente(new Cliente("Carlos Fuentes", "cfuentes@gmail.com", new List<CuentaBancaria>{
    new CuentaDeAhorro(1500,0.10), new CuentaDeAhorro(2500,0.20), new CuentaDeCheques(6500,500)}));
mibanco.AgregarCliente(new Cliente("Juan de la Fuente","juanfuente@gmail.com", new List<CuentaBancaria>{
    new CuentaDeCheques(2500,500)}));

//Agregamos dos clientes al banco (Forma 2)
mibanco.AgregarCliente(new Cliente("Maria Perez", "mperez@gmail.com", new List<CuentaBancaria>()));
mibanco.Clientes[2].AgregarCuenta(new CuentaDeCheques(16500,1500));
mibanco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(116500,0.40));
mibanco.AgregarCliente(new Cliente("Petra Dominguez", "pdom@gmail.com", new List<CuentaBancaria>()));
mibanco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(12500,0.30));

//retiramos y depositamos a las diferentes cuentas de algunos clientes
mibanco.Clientes[1].Cuentas[0].Retira(3000);
mibanco.Clientes[2].Cuentas[0].Retira(17000);
mibanco.Clientes[2].Cuentas[0].Retira(1000);
mibanco.Clientes[3].Cuentas[0].Deposita(200);

//Reporte de clientes
Console.WriteLine($"Reporte de clientes del banco \n {mibanco.ToString()}");
Console.WriteLine($"Clientes: {mibanco.Clientes.Count}\n");

//Imprimir los clientes y sus respectivos datos
foreach(Cliente cte in mibanco.Clientes){
    Console.Write($"\nCliente:\n{cte.ToString()}, cuentas: {cte.Cuentas.Count}\n");
    foreach(CuentaBancaria cta in cte.Cuentas){
        Console.Write((cta is CuentaDeCheques)?"Cuenta de cheques":"Cuenta de ahorro");
        if(cta is CuentaDeAhorro)
            (cta as CuentaDeAhorro).CalcularInteres();
            Console.Write($", con un saldo de {cta.Saldo:n2}\n");
    }
}