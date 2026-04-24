num = input("Ingrese un número: ")

deci = float(num)
entero = int(round(deci))

print(f"\nResto: {entero % 2}");
print(f"Dividido entre 3: {deci/3}");