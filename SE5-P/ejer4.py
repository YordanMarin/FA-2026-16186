cant = int(input("Ingrese la cantidad de números: "))

Cceros=Cpares=cImpares=0

print()

for i in range(0,cant):
    num = int(input(f"Ingrese número {i+1}: "))

    if (num == 0): Cceros+=1
    elif(num % 2==0): Cpares+=1
    else: cImpares+=1

print("\n\nCantidad ceros: ",Cceros)
print("Cantidad pares: ",Cpares)
print("Cantidad impares: " ,cImpares)