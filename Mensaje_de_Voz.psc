//prolema: un programa que muestre un mensaje de voz
//crear un menu 
//-1 recepcion
//2 vigilancia
//3 mantenimiento
// salir o error
Algoritmo Mensaje_de_Voz
	Escribir "===Mensaje de voz==="
	//varables
	Definir opcion Como Entero
	//menu
	Escribir "Menu principal"
	Escribir Sin Saltar " Digite una opcion:"
	Escribir "1: recepcion"
	Escribir "2: vigilancia"
	Escribir "3: mantenimiento"
	Escribir "4: salir"
	Leer opcion
	//condiciones
	si(opcion==1) Entonces
		Escribir "Bienvenido al departamento de recepcion"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	si(opcion==2) Entonces
		Escribir "Bienvenido al departamento de vigilancia"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	si(opcion==3) Entonces
		Escribir "Bienvenido al departamento de mantenimiento"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	si(opcion==4) Entonces
		Escribir "Salir del sistema"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	si(opcion<>1 o opcion<>2 y opcion<>3) Entonces
		Escribir "Salir del sistema"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
FinAlgoritmo
