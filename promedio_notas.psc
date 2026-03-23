Algoritmo promedio_notas
	Escribir "===Promedio notas==="
	Definir n1,n2,n3,n4,n5,promedio Como Entero
	Definir materia Como Caracter
	Escribir "Diga la materia:"
	Leer materia
	Escribir "Ingrese la primera nota: "
	Leer n1
	Escribir "Ingrese la segunda nota: "
	Leer n2
	Escribir "Ingrese la tercera nota: "
	Leer n3
	Escribir "Ingrese la cuarta nota: "
	Leer n4
	Escribir "Ingrese la quinta nota: "
	Leer n5
	promedio=(n1+n2+n3+n4+n5)/5
	si (promedio>=70) Entonces
		Escribir "Alumno aprobado"
	SiNo
		Escribir "Alumno reprobado"
	FinSi
	
	Escribir "La materia:",materia
	Escribir "El promedio: ",promedio
	
	
	
FinAlgoritmo
