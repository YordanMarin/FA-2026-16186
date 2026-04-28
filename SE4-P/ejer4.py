import math

print("--- SISTEMA DE CALCULO DE ÁREAS ---\n")

print("1. Área del cuadrado")
print("2. Área del triángulo")
print("3. Área del rectángulo")
print("4. Área del círculo\n")

opc = int(input("Ingrese una opción: "))

match opc:
    case 1:
        l = int(input("\nIngresa el lado del cuadrado: "))
        area = l * l
        print("\nÁrea del cuadrado: ",area)
    case 2:
        b = int(input("\nIngresa la base del triángulo: "))
        h = int(input("Ingresa la altura del triángulo: "))
        area = b * h / 2
        print("\nÁrea del triángulo: ", area)
    case 3:
        br = int(input("\nIngresa la base del rectángulo: "))
        hr = int(input("Ingresa la altura del rectángulo: "))
        area = br * hr
        print("\nÁrea del triángulo: ", area)
    case 4:
        r = int(input("\nIngresa la radio del circulo: "))
        area = math.pi * math.pow(r, 2)
        print("\nÁrea del circulo: ", area)
    case _: print("\nOpción incorrecta!")
