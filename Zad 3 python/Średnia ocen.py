# Pobranie liczby ocen
while True:
    try:
        liczba_ocen = int(input("Podaj liczbę ocen: "))

        if liczba_ocen > 0:
            break
        else:
            print("Liczba ocen musi być większa od 0!")

    except ValueError:
        print("Podaj poprawną liczbę!")

suma = 0

# Wprowadzanie ocen
for i in range(1, liczba_ocen + 1):

    while True:
        try:
            ocena = float(input(f"Podaj ocenę nr {i} (1-6): "))

            if 1 <= ocena <= 6:
                break
            else:
                print("Ocena musi być w zakresie 1-6!")

        except ValueError:
            print("Podaj poprawną ocenę!")

    suma += ocena

# Obliczanie średniej
srednia = suma / liczba_ocen

print("Średnia ocen wynosi:", srednia)

# Sprawdzenie zaliczenia
if srednia >= 3.0:
    print("Uczeń zaliczył przedmiot.")
else:
    print("Uczeń nie zaliczył przedmiotu.")