num = int(input("Ingrese número: "))

while num <=0:
    num = int(input("Numero invalido. Ingrese número: "))

i=1
print()
while i<=12:
    print(f"{num} x {i} = {num*i}")
    i+=1