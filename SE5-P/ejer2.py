l1 = int(input("Ingrese lado 1: "))
l2 = int(input("Ingrese lado 2: "))
l3 = int(input("Ingrese lado 3: "))

if (l1 == l2 and l2 == l3):
    print("\nEQUILÁTERO")
elif (l1 == l2 or l2 == l3 or l1 == l3):
    print("\nISÓSCELES")
else:
    print("\nESCALENO")