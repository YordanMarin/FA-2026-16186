print("--- Sistema de conversión monetario ---\n")

mo = float(input("Ingrese el monto en soles: "))

print("\n1. Convertir a dolares")
print("2. Convertir a euros\n")

opc = int(input("Ingrese una opción: "))

match opc:
    case 1:
        dolares = mo/3.75
        print("\nDolares: ",round(dolares,2))
    case 2:
        euros = mo / 4.05
        print("\nEuros: ",round(euros,2))
    case _: print("\nOpción incorrecta!")


