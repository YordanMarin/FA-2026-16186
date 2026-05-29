from Cajero import Cajero
c= Cajero()

continuar="si"

while continuar=="si":
    print("BIENVENIDOS AL SISTEMA DE CAJERO\n")
    print("1. Consultar saldo")
    print("2. Depositar dinero")
    print("3. Retirar dinero")
    print("4. Salir\n")

    while True:
        opc = int(input("Ingrese una opción: "))

        if opc in(1,2,3,4): break
        else: print("Opción no válida. Intente nuevamente.\n")

    continuar = input("\n¿Desea continar? presione [si]: ")
    
