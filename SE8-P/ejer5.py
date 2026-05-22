def suma(x,y)->None:
    print("\nLa suma es: ",x+y)

def resta(x,y)->None:
    print("\nLa resta es: ",x-y)

def multi(x,y)->None:
    print("\nLa multiplicación es: ",x*y)

def divi(x,y)->None:
    if y != 0:
        print("\nLa División es: ",x/y)
    else: print("\nNo se puede dividir entre 0.")

while(True):
    print("MENÚ DE OPERACIONES BÁSICAS:")
    print("1. Suma")
    print("2. Resta")
    print("3. Multiplicación")
    print("4. División")
    print("5. Salir\n")

    opc = int(input("Ingrese una opción: "))

    if(opc<=4 and opc >=1):
        x = int(input("\nIngrese el primer número: "))
        y = int(input("Ingrese el segundo número: "))

    match opc:
        case 1: suma(x,y)
        case 2: resta(x,y)
        case 3: multi(x,y)
        case 4: divi(x,y)
        case 5: exit() #quit()
        case _: print("\nOpción no válida.")

    continuar = input("\n¿Desea continuar? (escriba [si]): ")
    if(continuar != "si"): break