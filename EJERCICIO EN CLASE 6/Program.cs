using EJERCICIO_EN_CLASE_6.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();  

//Para seleccionar y poner comentarios colocar control + k+ c

Chofer piloto1 = new Chofer("Monica", 25, "A");
Chofer piloto2 = new Chofer("Andrea", 21, "M");

//piloto1.mostrarInformación();
//piloto2.mostrarInformación();

//Vehiculo sedan = new Vehiculo(2025,"Azul", "Monica");

String respuesta;

//respuesta = sedan.asginarelPiloto(piloto1);
//Console.WriteLine(respuesta);
//sedan.acelerar(25);
//respuesta = sedan.Encender();
//Console.WriteLine(respuesta);

piloto2.TipoLicencia = "a";
Moto honda = new Moto(2025, "Rojo", "Honda");
Console.WriteLine(honda.AsignarPiloto(piloto2));