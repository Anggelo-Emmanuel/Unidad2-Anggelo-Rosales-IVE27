Algoritmo TipoTriangulo
	
	Definir a,b,c Como Real
	
	Escribir "Ingrese los tres angulos"
	Leer a,b,c
	
	Si a=b Y b=c Entonces
		Escribir "Triangulo Equilatero"
	Sino
		Si a=b O a=c O b=c Entonces
			Escribir "Triangulo Isosceles"
		Sino
			Escribir "Triangulo Escaleno"
		FinSi
	FinSi

	
FinAlgoritmo
