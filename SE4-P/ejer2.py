an = int(input("Ingrese el año: "))

if ((an % 4 == 0 and an %100 != 0) or an%400 == 0):
    print("\nEl año es bisiesto")
else: print("\nEl año no es bisiesto")

if(an%2 == 0): print("\nEl año es par");
else: print("\nEl año es impar");