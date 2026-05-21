# Wybór konwersji
wybor = input(
    "Wybierz konwersję (C - Celsjusz na Fahrenheit, F - Fahrenheit na Celsjusz): "
).upper()

# C -> F
if wybor == "C":
    while True:
        try:
            celsjusz = float(input("Podaj temperaturę w Celsjuszach: "))
            break
        except ValueError:
            print("Błędna wartość!")

    fahrenheit = celsjusz * 1.8 + 32
    print("Temperatura w Fahrenheitach:", fahrenheit)

# F -> C
elif wybor == "F":
    while True:
        try:
            fahrenheit = float(input("Podaj temperaturę w Fahrenheitach: "))
            break
        except ValueError:
            print("Błędna wartość!")

    celsjusz = (fahrenheit - 32) / 1.8
    print("Temperatura w Celsjuszach:", celsjusz)

else:
    print("Niepoprawny wybór!")