// Instanciar y reservar en memoria para un objeto de una clase determinada
Empleado empleado01 = new Empleado();
empleado01.Nombre =  "Juan Carlos";
empleado01.Edad = 22;
empleado01.Sexo = 'H';
empleado01.EstadoCivil = false;
empleado01.Imprimir();

//Instanciar, luego reservar espacio en memoria para un objeto de una clase determinada
Empleado empleado02;
empleado02 = new Empleado();
empleado02.Nombre = "Maria de Jesus";
empleado02.Edad = 41;
empleado02.Sexo = 'M';
empleado02.EstadoCivil = true;
empleado02.Imprimir();

//Crear nuevo objeto con constructores
Empleado empleado03 = new Empleado("Claudia S", 40, 'M', true);
empleado03.Imprimir();

Empleado empleado04 = new Empleado{Nombre = "AMLO", Edad = 75, Sexo = 'H', EstadoCivil = true};
empleado04.Imprimir();