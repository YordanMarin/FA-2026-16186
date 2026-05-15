password = "hola"
intentos = 3

print("---------------------------------------------------")
print("|              VALIDAR CONTRASEÑA                 |")
print("---------------------------------------------------\n")

while intentos > 0:
    validar = input("Ingrese la contraseña: ")

    if validar == password: 
        print("Acceso concedido!\n")
        break
    else: 
        intentos-=1
        print("Contraseña incorrecta. Intentos restantes ",intentos,"\n")
else: print("\nAcceso denegado. Cerrando programa...")
