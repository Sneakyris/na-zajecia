# Pobieranie pierwszej liczby
while True:
    try:
        liczba1 = float(input("Podaj pierwszą liczbę: "))
        break
    except ValueError:
        print("Błędna liczba!")

# Pobieranie drugiej liczby
while True:
    try:
        liczba2 = float(input("Podaj drugą liczbę: "))
        break
    except ValueError:
        print("Błędna liczba!")

# Pobranie operatora
operacja = input("Podaj operację (+, -, *, /): ")

# Wybór działania
if operacja == "+":
    wynik = liczba1 + liczba2
    print("Wynik:", wynik)

elif operacja == "-":
    wynik = liczba1 - liczba2
    print("Wynik:", wynik)

elif operacja == "*":
    wynik = liczba1 * liczba2
    print("Wynik:", wynik)

elif operacja == "/":
    if liczba2 != 0:
        wynik = liczba1 / liczba2
        print("Wynik:", wynik)
    else:
        print("Nie można dzielić przez zero!")

else:
    print("Niepoprawna operacja!")