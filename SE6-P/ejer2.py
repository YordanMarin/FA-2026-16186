sumaP = sumaI = 0

while True:
    num = int(input("Ingrese un número positivo o 0 para salir: "))

    if(num < 0):
        print("Incorrecto. Intente nuevamente!\n")
        continue

    if(num == 0): break
    elif num%2==0: sumaP+=num
    else: SumaI+= num

    print("\n\nSuma de pares: ",sumaP)
    print("Suma de impares: ", sumaI)
