class Cajero:
    saldo = 1000

    def consultar(self)->float:
        return self.saldo

    def depositar(self, monto)->None:
        while True:
            try:
                m = float(monto)
                if monto > 0:
                    self.saldo += m
                    print("\nDéposito exitoso")
                    break
                else:
                    print("\nNo se puede depositar montos negativos")
                    break
            except ValueError:
                print("\nError: Ingrese solo números válidos!")
                break