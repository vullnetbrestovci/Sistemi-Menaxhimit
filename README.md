# Sistemi i Menaxhimit të Studentëve dhe Profesorëve

Ky projekt është zhvilluar për të menaxhuar të dhënat e studentëve dhe profesorëve në një institucion arsimor.

## Karakteristikat Kryesore:
- **Trashëgimia**: Klasat `Student` dhe `Professor` trashëgojnë nga klasa abstrakte `Person`.
- **Polimorfizmi**: Metoda `ShfaqInformacion` është mbishkruar për secilën klasë të trashëguar.
- **Enkapsulimi**: Përdorim i `get` dhe `set` për të siguruar kontroll mbi atributet.
- **Abstraktimi**: Klasa `Person` siguron një strukturë abstrakte për klasat e trashëguara.

## Struktura e Projektit:
```
/Projekt-Menaxhimi
├── /src
│   ├── Person.cs
│   ├── Student.cs
│   ├── Professor.cs
│   ├── Program.cs
├── README.md
```

## Si ta përdorni:
1. Hapni projektin në një IDE të tillë si Visual Studio.
2. Ekzekutoni programin dhe ndiqni udhëzimet në ekran.
3. Mund të regjistroni studentë dhe profesorë, t'i shfaqni të dhënat e tyre ose t'i ruani në një skedar.

## Kërkesat:
- .NET Framework.

**Autorët:
Adriatik Raka,
Florian Rashiti,
Vullnet Brestovci**
