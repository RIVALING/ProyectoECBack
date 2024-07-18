Api rest .net core 8
teniendo instalado el visual studio
se procede a instalar los paquetes nuget:
  Herramientas - Administrador de paquetes nuget - administrar paquetes para la solición, se intala los siguientes:
  -microsoft entityframeworkcore
  -microsoft entityframeworkcore sqlserver
  -microsoft entityframeworkcore tools
  -microsoft visualstudio web codegeneration design
  -swashbuckle aspnetcore
tendremos que tener una base de datos local en nnuestra maquina sql server, proceder a instalarla dejar la de defecto local
ya termnada la instalacion se procede a ejecutar la consola de administrador de paquetes "Herramienta, administrador de paquetes, consola", dentro de esta escribiremos
  Update-database + la tecla enter
  este comando nos crea las tablas de nuestro modelo en la base de datos
